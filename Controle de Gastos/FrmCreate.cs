using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class FrmCreate : Form
    {
        private double price = 0;
        private readonly string placeholder = "Exemplos: conta de luz, lâmpada, TV etc.";

        public FrmCreate()
        {
            InitializeComponent();
            int i = Classes.Data.SelectedId;

            if (i != -1)
            {
                if (Classes.Data.Paid[i]) RdoPaid.Checked = true;
                DtpDate.Value = Classes.Data.Date[i];
                TxtExpense.Text = Classes.Data.Expense[i];
                TxtPayment.Text = Classes.Data.Payment[i];
                TxtComments.Text = Classes.Data.Comments[i];
                price = Classes.Data.Price[i];

                TxtBalance.Enabled = false;
                RdoPaid.Enabled = false;
                BtnUpdate.Enabled = true;
                BtnCreate.Enabled = false;
                BtnCreate.BackColor = Color.Gray;
            }

            PicLogo.Select();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", price);
            TxtBalance.GotFocus += new EventHandler(TxtBalance_GotFocus);
            TxtBalance.LostFocus += new EventHandler(TxtBalance_LostFocus);

            TxtExpense_LostFocus(TxtExpense, null);
            TxtExpense.GotFocus += new EventHandler(TxtExpense_GotFocus);
            TxtExpense.LostFocus += new EventHandler(TxtExpense_LostFocus);
        }

        private void TxtBalance_GotFocus(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Format("{0:#,##0.00}", price);
        }

        private void TxtBalance_LostFocus(object sender, EventArgs e)
        {
            try
            {
                price = double.Parse(TxtBalance.Text);
            }
            catch (Exception ex)
            {
                var t = "ERRO: " + ex.Message;
                var c = "";
                var b = MessageBoxButtons.OK;
                var i = MessageBoxIcon.Error;

                MessageBox.Show(t, c, b, i);
            }

            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", price);
        }

        private void TxtExpense_GotFocus(object sender, EventArgs e)
        {
            if (TxtExpense.Text == placeholder)
            {
                TxtExpense.Text = string.Empty;
                TxtExpense.ForeColor = Color.Black;
            }
        }

        private void TxtExpense_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtExpense.Text))
            {
                TxtExpense.Text = placeholder;
                TxtExpense.ForeColor = Color.Gray;
            }
        }

        private void BtnCreateAndUpdate_Click(object sender, EventArgs e)
        {
            var paid = RdoPaid.Checked;
            var date = DtpDate.Value;
            var expense = TxtExpense.Text;
            var payment = TxtPayment.Text;
            var comments = TxtComments.Text;

            if (string.IsNullOrWhiteSpace(payment)) payment = "Nenhum";
            if (string.IsNullOrWhiteSpace(comments)) comments = "Nenhuma";

            var t = string.Empty;
            var c = string.Empty;
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Warning;

            PicLogo.Select();
            if (expense == placeholder)
            {
                t = "Por favor, preencha o campo de descrição da despesa.";
                MessageBox.Show(t, c, b, i);
            }
            else if (price <= 0.00)
            {
                t = "O preço do produto ou serviço deve ser maior que R$ 0,00.";
                MessageBox.Show(t, c, b, i);
            }
            else
            {
                var subtitle = "Você deseja adicionar a seguinte despesa?";
                var translatedPaid = "Não acertado";

                if (sender == BtnUpdate) subtitle = "Você deseja atualizar para a seguinte despesa?";
                if (paid) translatedPaid = "Acertado";

                var text = subtitle + "\n\nData: " + date.ToString("dd/MMMM/yyyy") + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price) + "\n\nDescrição: " + expense + "\nForma de pagamento: " + payment + "\nObservações: " + comments + "\n\nSituação: " + translatedPaid;
                var caption = string.Empty;
                var buttons = MessageBoxButtons.YesNo;
                var icon = MessageBoxIcon.Question;

                DialogResult dr = MessageBox.Show(text, caption, buttons, icon);
                if (dr == DialogResult.Yes)
                {
                    dr = DialogResult.No;

                    if (paid && Classes.Data.Balance >= 0 && price > Classes.Data.Balance)
                    {
                        text = "Você tem certeza que deseja prosseguir?\nSeu saldo atual se tornará negativo.\n\nSaldo atual: " + string.Format("{0:#,##0.00}", Classes.Data.Balance) + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price);
                        icon = MessageBoxIcon.Warning;

                        dr = MessageBox.Show(text, caption, buttons, icon);
                    }
                    else dr = DialogResult.Yes;

                    if (dr == DialogResult.Yes)
                    {
                        if (sender == BtnCreate) t = Classes.Data.Create(paid, date, expense, payment, comments, price);
                        else if (sender == BtnUpdate) t = Classes.Data.Update(paid, date, expense, payment, comments, price);

                        if (t != string.Empty) i = MessageBoxIcon.Information;
                        MessageBox.Show(t, c, b, i);

                        Classes.Data.SelectedId = -1;
                        BtnReturn_Click(sender, e);
                    }
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

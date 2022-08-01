using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                BtnCreate.Enabled = false;
                BtnUpdate.Enabled = true;
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

            if (expense == placeholder) expense = string.Empty;
            if (string.IsNullOrWhiteSpace(payment)) payment = string.Empty;
            if (string.IsNullOrWhiteSpace(comments)) comments = string.Empty;

            var t = string.Empty;
            var c = string.Empty;
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Warning;

            if (expense == string.Empty)
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
                if (sender == BtnCreate) t = Classes.Data.Create(paid, date, expense, payment, comments, price);
                else if (sender == BtnUpdate) t = Classes.Data.Update(paid, date, expense, payment, comments, price);

                if (t != string.Empty) i = MessageBoxIcon.Information;
                MessageBox.Show(t, c, b, i);

                Classes.Data.SelectedId = -1;
                BtnReturn_Click(sender, e);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

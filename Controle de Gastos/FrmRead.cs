using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class FrmRead : Form
    {
        private double spent = 0;

        public FrmRead()
        {
            InitializeComponent();
        }

        private void FrmRead_Load(object sender, EventArgs e)
        {
            PicLogo.Select();
            DgvSpending_Load();
            CmbCategory.SelectedIndex = 0;

            TxtBalance.GotFocus += new EventHandler(TxtBalance_GotFocus);
            TxtBalance.LostFocus += new EventHandler(TxtBalance_LostFocus);
            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", Classes.Data.Balance);
        }

        private void DgvSpending_Load(int month = 0)
        {
            spent = 0;
            DgvSpending.Rows.Clear();

            if (Classes.Data.Id != null)
            {
                for (int i = 0; i < Classes.Data.Id.Length; i++)
                {
                    if (!Classes.Data.Paid[i])
                    {
                        var date = Classes.Data.Date[i];
                        var expense = Classes.Data.Expense[i];
                        var payment = Classes.Data.Payment[i];
                        var comments = Classes.Data.Comments[i];
                        var price = Classes.Data.Price[i];

                        if (CmbCategory.SelectedIndex == 0 || date.Month == CmbCategory.SelectedIndex) DgvSpending.Rows.Add(null, i, date.ToString("dd/MM/yyyy"), expense, payment, comments, "R$ " + string.Format("{0:#,##0.00}", price), Properties.Resources.Change, Properties.Resources.Delete);
                    }
                }

                for (int i = 0; i < Classes.Data.Id.Length; i++)
                {
                    if (Classes.Data.Paid[i])
                    {
                        var paid = Properties.Resources.Paid;
                        var date = Classes.Data.Date[i];
                        var expense = Classes.Data.Expense[i];
                        var payment = Classes.Data.Payment[i];
                        var comments = Classes.Data.Comments[i];
                        var price = Classes.Data.Price[i];

                        if (CmbCategory.SelectedIndex == 0 || date.Month == CmbCategory.SelectedIndex)
                        {
                            spent += price;
                            DgvSpending.Rows.Add(paid, i, date.ToString("dd/MM/yyyy"), expense, payment, comments, "R$ " + string.Format("{0:#,##0.00}", price, null ,null));
                        }
                    }
                }
            }

            TxtSpent.Text = "R$ " + string.Format("{0:#,##0.00}", spent);
            DgvSpending.ClearSelection();
        }

        private void DgvSpending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var r = e.RowIndex;
            if (r >= 0)
            {
                var c = e.ColumnIndex;
                var id = int.Parse(DgvSpending.Rows[r].Cells[1].Value.ToString());

                if (c == 0)
                {
                    if (Classes.Data.Paid[id])
                    {
                        Classes.Data.Balance += Classes.Data.Price[id];
                        Classes.Data.Paid[id] = false;
                    }
                    else
                    {
                        var d = DialogResult.Yes;
                        var price = Classes.Data.Price[id];
                        var balance = Classes.Data.Balance;

                        if (balance >= 0 && price > balance)
                        {
                            var t = "Você tem certeza que deseja prosseguir?\nSeu saldo atual se tornará negativo.\n\nSaldo atual: " + string.Format("{0:#,##0.00}", balance) + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price); ;
                            var caption = string.Empty;
                            var b = MessageBoxButtons.YesNo;
                            var i = MessageBoxIcon.Warning;

                            d = MessageBox.Show(t, caption, b, i);
                        }

                        if (d == DialogResult.Yes)
                        {
                            Classes.Data.Balance -= Classes.Data.Price[id];
                            Classes.Data.Paid[id] = true;
                        }
                    }
                }
                else if ((c == 7 || c == 8) && Classes.Data.Paid[id])
                {
                    var t = "Para alterar ou remover a despesa, aperte no ícone de pago.";
                    var caption = string.Empty;
                    var b = MessageBoxButtons.OK;
                    var i = MessageBoxIcon.Warning;

                    MessageBox.Show(t, caption, b, i);
                }
                else if (c == 7)
                {
                    Classes.Data.SelectedId = id;

                    FrmCreate frmCreate = new FrmCreate();
                    frmCreate.ShowDialog();

                    Classes.Data.SelectedId = -1;
                }
                else if (c == 8)
                {
                    var t = "Você tem certeza que deseja remover a despesa?";
                    var caption = string.Empty;
                    var b = MessageBoxButtons.YesNo;
                    var i = MessageBoxIcon.Warning;

                    DialogResult d = MessageBox.Show(t, caption, b, i);
                    if (d == DialogResult.Yes)
                    {
                        Classes.Data.SelectedId = id;
                        Classes.Data.Delete();
                        Classes.Data.SelectedId = -1;
                    }
                }
                else
                {
                    var date = Classes.Data.Date[id].ToString("dd/MMMM/yyyy");
                    var price = Classes.Data.Price[id];
                    var expense = Classes.Data.Expense[id];
                    var payment = Classes.Data.Payment[id];
                    var comments = Classes.Data.Comments[id];

                    var translatedPaid = "Não acertado";
                    if (Classes.Data.Paid[id]) translatedPaid = "Acertado";

                    var t = "Data: " + date + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price) + "\n\nDescrição: " + expense + "\nForma de pagamento: " + payment + "\nObservações: " + comments + "\n\nSituação: " + translatedPaid;
                    var caption = string.Empty;
                    var b = MessageBoxButtons.OK;
                    var i = MessageBoxIcon.Information;

                    MessageBox.Show(t, caption, b, i);
                }
            }
            
            DgvSpending_Load();
            DgvSpending.ClearSelection();
            TxtBalance_GotFocus(sender, e);
            TxtBalance_LostFocus(sender, e);
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvSpending_Load(CmbCategory.SelectedIndex);
        }

        private void TxtBalance_GotFocus(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Format("{0:#,##0.00}", Classes.Data.Balance);
        }

        private void TxtBalance_LostFocus(object sender, EventArgs e)
        {
            try
            {
                Classes.Data.Balance = double.Parse(TxtBalance.Text);
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", Classes.Data.Balance);
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrWhiteSpace(TxtBalance.Text))
                {
                    var t = "ERRO: " + ex.Message;
                    var c = "";
                    var b = MessageBoxButtons.OK;
                    var i = MessageBoxIcon.Error;

                    MessageBox.Show(t, c, b, i);
                }

                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", Classes.Data.Balance);
            }

            Classes.File.Save();
        }

        private void BtnBalanceAndSpentAndDate_Click(object sender, EventArgs e)
        {
            var t = string.Empty;
            var c = "";
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Information;

            if (sender == BtnBalance) t = "Você possui R$ " + string.Format("{0:#,##0.00}", Classes.Data.Balance) + " de saldo.";
            else if (sender == BtnSpent)
            {
                var s = string.Format("{0:#,##0.00}", spent);
                var m = CmbCategory.Text;

                if (CmbCategory.SelectedIndex == 0) t = "Você gastou R$ " + string.Format("{0:#,##0.00}", spent) + " durante o ano.";
                else t = "Você gastou R$ " + s + " em " + m.ToLower() + '.';
            }
            else if (sender == BtnDate) t = "Utilize-o para visualizar os gastos por mês.";

            PicLogo.Select();
            MessageBox.Show(t, c, b, i);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

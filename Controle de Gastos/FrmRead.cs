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

                        if (CmbCategory.SelectedIndex == 0 || date.Month == CmbCategory.SelectedIndex) DgvSpending.Rows.Add(null, i, date.ToString("dd/MM/yyyy"), expense, payment, comments, "R$ " + string.Format("{0:#,##0.00}", price));
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
                            DgvSpending.Rows.Add(paid, i, date.ToString("dd/MM/yyyy"), expense, payment, comments, "R$ " + string.Format("{0:#,##0.00}", price));
                        }
                    }
                }
            }

            TxtSpent.Text = "R$ " + string.Format("{0:#,##0.00}", spent);
            DgvSpending.ClearSelection();
        }

        private void DgvSpending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvSpending.ClearSelection();

            // Implementar funções de acertar/desacertar, atualizar e remover gasto, ao clique.
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
                var t = "ERRO: " + ex.Message;
                var c = "";
                var b = MessageBoxButtons.OK;
                var i = MessageBoxIcon.Error;

                MessageBox.Show(t, c, b, i);
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

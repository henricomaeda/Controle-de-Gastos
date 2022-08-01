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
    public partial class FrmRead : Form
    {
        private double balance = 0;
        private double spent = 0;

        public FrmRead()
        {
            InitializeComponent();
            CmbCategory.SelectedIndex = 0;

            TxtSpent.Text = "R$ " + string.Format("{0:#,##0.00}", spent);
            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", balance);
            DgvSpending.Rows.Add(null, 0, DateTime.Now.ToString("dd/MMMM/yyyy"), "Mercado", "Cartão de crédito", "Nenhuma.", "R$ 1.500,00");
            DgvSpending.Rows.Add(null, 1, DateTime.Now.ToString("dd/MMMM/yyyy"), "Conta da luz", "Dinheiro", "Nenhuma.", "R$ 900,00");
            DgvSpending.ClearSelection();
            PicLogo.Select();
        }

        private void FrmRead_Load(object sender, EventArgs e)
        {
            TxtBalance.GotFocus += new EventHandler(TxtBalance_GotFocus);
            TxtBalance.LostFocus += new EventHandler(TxtBalance_LostFocus);
        }

        private void TxtBalance_GotFocus(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Format("{0:#,##0.00}", balance);
        }

        private void TxtBalance_LostFocus(object sender, EventArgs e)
        {
            try
            {
                balance = double.Parse(TxtBalance.Text);
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", balance);
            }
            catch (Exception ex)
            {
                var t = "ERRO: " + ex.Message;
                var c = "";
                var b = MessageBoxButtons.OK;
                var i = MessageBoxIcon.Error;

                MessageBox.Show(t, c, b, i);
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", balance);
            }
        }

        private void BtnBalanceAndSpentAndDate_Click(object sender, EventArgs e)
        {
            var t = string.Empty;
            var c = "";
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Information;

            if (sender == BtnBalance) t = "Você possui R$ " + string.Format("{0:#,##0.00}", balance) + " de saldo.";
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

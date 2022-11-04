using Controle_de_Gastos.Classes;
using System.Windows.Forms;
using System;

namespace Controle_de_Gastos
{
    public partial class FrmReceipt : Form
    {
        private static double actualBalance = 0;

        public FrmReceipt()
        {
            InitializeComponent();
            Select();
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            CmbReceiptDay.SelectedIndex = Receipt.receiptDay_01;
            actualBalance = Receipt.balance_01;
            ChkReceive.Checked = Receipt.receive_01;

            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", actualBalance);
            TxtBalance.GotFocus += new EventHandler(TxtBalance_GotFocus);
            TxtBalance.LostFocus += new EventHandler(TxtBalance_LostFocus);
        }

        private void TxtBalance_GotFocus(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Format("{0:#,##0.00}", actualBalance);
        }

        private void TxtBalance_LostFocus(object sender, EventArgs e)
        {
            try
            {
                TxtBalance.Text = string.Format("{0:0.00}", double.Parse(TxtBalance.Text));
                actualBalance = double.Parse(TxtBalance.Text);
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
            }

            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", actualBalance);
        }

        private void BtnReturnAndUpdate_Click(object sender, EventArgs e)
        {
            LblBalance.Select();
            var dr = DialogResult.Yes;
            if (sender == BtnUpdate)
            {
                var t = "Você deseja mesmo atualizar as informações?\n\nDe acordo com as informações que serão atualizadas:";
                var c = string.Empty;
                var b = MessageBoxButtons.YesNo;
                var i = MessageBoxIcon.Information;

                if (!ChkReceive.Checked || CmbReceiptDay.SelectedIndex == 0) t += "\nVocê não receberá nada mensalmente.";
                else t += "\nVocê receberá, mensalmente, " + TxtBalance.Text + '.';

                dr = MessageBox.Show(t, c, b, i);
            }

            if (dr == DialogResult.Yes)
            {
                if (sender == BtnUpdate)
                {
                    if (TxtPaymentSelected.Text == "Primeiro pagamento.") Receipt.UpdateInfo(CmbReceiptDay.SelectedIndex, actualBalance, ChkReceive.Checked);
                    else Receipt.UpdateInfo(CmbReceiptDay.SelectedIndex, actualBalance, ChkReceive.Checked, false);
                }

                Close();
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            LblPaymentSelected.Select();
            if (sender == BtnPayment_01)
            {
                CmbReceiptDay.SelectedIndex = Receipt.receiptDay_01;
                actualBalance = Receipt.balance_01;
                ChkReceive.Checked = Receipt.receive_01;

                TxtPaymentSelected.Text = "Primeiro pagamento.";
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", actualBalance);
            }
            else
            {
                CmbReceiptDay.SelectedIndex = Receipt.receiptDay_02;
                actualBalance = Receipt.balance_02;
                ChkReceive.Checked = Receipt.receive_02;

                TxtPaymentSelected.Text = "Segundo pagamento.";
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", actualBalance);
            }
        }
    }
}

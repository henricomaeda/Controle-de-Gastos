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
        private float balance = 0;

        public FrmCreate()
        {
            InitializeComponent();
            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", balance);
            PicLogo.Select();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            int i = Classes.Data.SelectedId;
            if (i != -1)
            {
                balance = Classes.Data.Balance[i];

                DtpDate.Value = Classes.Data.Date[i];
                TxtExpense.Text = Classes.Data.Expense[i];
                TxtPayment.Text = Classes.Data.Payment[i];
                TxtComments.Text = Classes.Data.Comments[i];
                TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", balance);
                if (Classes.Data.Paid[i]) RdoPaid.Checked = true;

                TxtBalance.Enabled = false;
                RdoPaid.Enabled = false;
                BtnCreate.Enabled = false;
                BtnUpdate.Enabled = true;
            }
        }

        private void BtnCreateAndUpdate_Click(object sender, EventArgs e)
        {
            var date = DtpDate.Value;
            var expense = TxtExpense.Text;
            var payment = TxtPayment.Text;
            var comments = TxtComments.Text;
            var paid = RdoPaid.Checked;

            var t = "Por favor, preencha todos os campos obrigatórios.\n\nOs campos obrigatórios, geralmente, se identificam com *";
            var c = "";
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Warning;

            if (string.IsNullOrWhiteSpace(expense)) MessageBox.Show(t, c, b, i);
            else if (balance < 0.01)
            {
                t = "O valor do produto ou serviço deve ser maior que R$ 0,00.";
                MessageBox.Show(t, c, b, i);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

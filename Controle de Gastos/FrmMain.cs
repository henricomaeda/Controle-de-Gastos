using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            PicLogo.Select();
        }

        private void BtnCreateAndRead_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            var frm = new Form();

            if (sender == BtnCreate) frm = new FrmCreate();
            else if (sender == BtnRead) frm = new FrmRead();
            
            frm.ShowDialog();
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var t = "Você tem certeza que deseja finalizar?";
            var c = "";
            var b = MessageBoxButtons.YesNo;
            var i = MessageBoxIcon.Question;

            DialogResult r = MessageBox.Show(t, c, b, i);
            if (r == DialogResult.Yes) BtnLeave_Click(null, e);
            else e.Cancel = true;
        }
    }
}

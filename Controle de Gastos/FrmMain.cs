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
    }
}

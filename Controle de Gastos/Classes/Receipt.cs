using System;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_Gastos.Classes
{
    internal class Receipt
    {
        private readonly static string path = @"C:\Controle de Gastos\";
        private readonly static string file_01 = "receipt_01.db";
        private readonly static string file_02 = "receipt_02.db";

        public static int receiptDay_01 = 0;
        public static double balance_01 = 0;
        public static bool receive_01 = false;
        public static DateTime lastLogin_01 = DateTime.Now;

        public static int receiptDay_02 = 0;
        public static double balance_02 = 0;
        public static bool receive_02 = false;
        public static DateTime lastLogin_02 = DateTime.Now;

        public static void RegisterInfo()
        {
            if (!Directory.Exists(path) || !System.IO.File.Exists(path + file_01) || new FileInfo(path + file_01).Length == 0)
            {
                Directory.CreateDirectory(path);

                StreamWriter sw = new StreamWriter(path + file_01);
                string encrypted = Code.Encrypt(Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(false.ToString()) + '|' + Code.Encrypt(DateTime.Now.ToString()));
                sw.WriteLine(encrypted);
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(path + file_01);
                string content = Code.Decrypt(sr.ReadLine());
                string[] information = content.Split('|');

                receiptDay_01 = int.Parse(Code.Decrypt(information[0]));
                balance_01 = double.Parse(Code.Decrypt(information[1]));
                receive_01 = bool.Parse(Code.Decrypt(information[2]));
                lastLogin_01 = DateTime.Parse(Code.Decrypt(information[3]));

                sr.Close();
                ValidateLogin();
            }

            if (!System.IO.File.Exists(path + file_02) || new FileInfo(path + file_02).Length == 0)
            {
                StreamWriter sw = new StreamWriter(path + file_02);
                string encrypted = Code.Encrypt(Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(false.ToString()) + '|' + Code.Encrypt(DateTime.Now.ToString()));
                sw.WriteLine(encrypted);
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(path + file_02);
                string content = Code.Decrypt(sr.ReadLine());
                string[] information = content.Split('|');

                receiptDay_02 = int.Parse(Code.Decrypt(information[0]));
                balance_02 = double.Parse(Code.Decrypt(information[1]));
                receive_02 = bool.Parse(Code.Decrypt(information[2]));
                lastLogin_02 = DateTime.Parse(Code.Decrypt(information[3]));

                sr.Close();
                ValidateLogin();
            }
        }

        private static void ValidateLogin()
        {
            DateTime oldLogin_01 = lastLogin_01;
            lastLogin_01 = DateTime.Now;
            DateTime dt_01 = oldLogin_01;

            if (receive_01 && receiptDay_01 != 0)
            {
                int passed = 0;
                while (dt_01.Year != lastLogin_01.Year && dt_01.Month != lastLogin_01.Month && dt_01.Day != lastLogin_01.Day)
                {
                    dt_01.AddDays(1);
                    if (dt_01.Day == receiptDay_01) passed++;
                }

                double newBalance = balance_01 * passed;
                var t = "Se passaram " + passed + " meses.\nR$ " + string.Format("{0:#,##0.00}", newBalance) + " será adicionado em seu saldo!";
                var c = string.Empty;
                var b = MessageBoxButtons.OKCancel;
                var i = MessageBoxIcon.Information;

                DialogResult dr = DialogResult.None;
                if (passed > 0)
                {
                    dr = MessageBox.Show(t, c, b, i);
                    if (dr == DialogResult.OK)
                    {
                        Data.balance += newBalance;
                        File.Save();
                    }
                    else if (dr == DialogResult.Cancel) lastLogin_01 = oldLogin_01;
                }
            }

            Directory.CreateDirectory(path);
            StreamWriter sw_01 = new StreamWriter(path + file_01);
            string encrypted_01 = Code.Encrypt(Code.Encrypt(receiptDay_01.ToString()) + '|' + Code.Encrypt(balance_01.ToString()) + '|' + Code.Encrypt(receive_01.ToString()) + '|' + Code.Encrypt(lastLogin_01.ToString()));
            sw_01.WriteLine(encrypted_01);
            sw_01.Close();

            DateTime oldLogin_02 = lastLogin_02;
            lastLogin_02 = DateTime.Now;
            DateTime dt_02 = oldLogin_02;

            if (receive_02 && receiptDay_02 != 0)
            {
                int passed = 0;
                while (dt_02.Year != lastLogin_02.Year && dt_02.Month != lastLogin_02.Month && dt_02.Day != lastLogin_02.Day)
                {
                    dt_02.AddDays(1);
                    if (dt_02.Day == receiptDay_02) passed++;
                }

                double newBalance = balance_02 * passed;
                var t = "Se passaram " + passed + " meses.\nR$ " + string.Format("{0:#,##0.00}", newBalance) + " será adicionado em seu saldo!";
                var c = string.Empty;
                var b = MessageBoxButtons.OKCancel;
                var i = MessageBoxIcon.Information;

                DialogResult dr = DialogResult.None;
                if (passed > 0)
                {
                    dr = MessageBox.Show(t, c, b, i);
                    if (dr == DialogResult.OK)
                    {
                        Data.balance += newBalance;
                        File.Save();
                    }
                    else if (dr == DialogResult.Cancel) lastLogin_02 = oldLogin_02;
                }
            }

            StreamWriter sw_02 = new StreamWriter(path + file_02);
            string encrypted_02 = Code.Encrypt(Code.Encrypt(receiptDay_02.ToString()) + '|' + Code.Encrypt(balance_02.ToString()) + '|' + Code.Encrypt(receive_02.ToString()) + '|' + Code.Encrypt(lastLogin_02.ToString()));
            sw_02.WriteLine(encrypted_02);
            sw_02.Close();
        }

        public static void UpdateInfo(int rd, double b, bool r, bool first = true)
        {
            if (first)
            {
                receiptDay_01 = rd;
                balance_01 = b;
                receive_01 = r;

                Directory.CreateDirectory(path);
                StreamWriter sw = new StreamWriter(path + file_01);
                string encrypted = Code.Encrypt(Code.Encrypt(receiptDay_01.ToString()) + '|' + Code.Encrypt(balance_01.ToString()) + '|' + Code.Encrypt(receive_01.ToString()) + '|' + Code.Encrypt(lastLogin_01.ToString()));
                sw.WriteLine(encrypted);
                sw.Close();
            }
            else
            {
                receiptDay_02 = rd;
                balance_02 = b;
                receive_02 = r;

                Directory.CreateDirectory(path);
                StreamWriter sw = new StreamWriter(path + file_02);
                string encrypted = Code.Encrypt(Code.Encrypt(receiptDay_02.ToString()) + '|' + Code.Encrypt(balance_02.ToString()) + '|' + Code.Encrypt(receive_02.ToString()) + '|' + Code.Encrypt(lastLogin_02.ToString()));
                sw.WriteLine(encrypted);
                sw.Close();
            }
        }
    }
}

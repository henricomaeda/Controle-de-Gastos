using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace Controle_de_Gastos.Classes
{
    internal class Receipt
    {
        private readonly static string path = @"C:\Controle de Gastos\";
        private readonly static string file = "receipt.db";

        public static int receiptDay = 0;
        public static double balance = 0;
        public static bool receive = false;
        public static DateTime lastLogin = DateTime.Now;

        public static void RegisterInfo()
        {
            if (!Directory.Exists(path) || !System.IO.File.Exists(path + file) || new FileInfo(path + file).Length == 0)
            {
                Directory.CreateDirectory(path);
                StreamWriter sw = new StreamWriter(path + file);
                string encrypted = Code.Encrypt(Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(0.ToString()) + '|' + Code.Encrypt(false.ToString()) + '|' + Code.Encrypt(DateTime.Now.ToString()));
                sw.WriteLine(encrypted);
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(path + file);
                string content = Code.Decrypt(sr.ReadLine());
                string[] information = content.Split('|');

                receiptDay = int.Parse(Code.Decrypt(information[0]));
                balance = double.Parse(Code.Decrypt(information[1]));
                receive = bool.Parse(Code.Decrypt(information[2]));
                lastLogin = DateTime.Parse(Code.Decrypt(information[3]));

                sr.Close();
                ValidateLogin();
            }
        }

        private static void ValidateLogin()
        {
            DateTime oldLogin = lastLogin;
            lastLogin = DateTime.Now;
            DateTime dt = oldLogin;

            if (receive && receiptDay != 0)
            {
                int passed = 0;
                while (dt.Year != lastLogin.Year && dt.Month != lastLogin.Month && dt.Day != lastLogin.Day)
                {
                    dt.AddDays(1);
                    if (dt.Day == receiptDay) passed++;
                }

                double newBalance = balance * passed;
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
                    else if (dr == DialogResult.Cancel) lastLogin = oldLogin;
                }
            }

            Directory.CreateDirectory(path);
            StreamWriter sw = new StreamWriter(path + file);
            string encrypted = Code.Encrypt(Code.Encrypt(receiptDay.ToString()) + '|' + Code.Encrypt(balance.ToString()) + '|' + Code.Encrypt(receive.ToString()) + '|' + Code.Encrypt(lastLogin.ToString()));
            sw.WriteLine(encrypted);
            sw.Close();
        }

        public static void UpdateInfo(int rd, double b, bool r)
        {
            receiptDay = rd;
            balance = b;
            receive = r;

            Directory.CreateDirectory(path);
            StreamWriter sw = new StreamWriter(path + file);
            string encrypted = Code.Encrypt(Code.Encrypt(receiptDay.ToString()) + '|' + Code.Encrypt(balance.ToString()) + '|' + Code.Encrypt(receive.ToString()) + '|' + Code.Encrypt(lastLogin.ToString()));
            sw.WriteLine(encrypted);
            sw.Close();
        }
    }
}

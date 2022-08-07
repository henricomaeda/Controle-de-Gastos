using System;
using System.IO;
using System.Collections.Generic;

namespace Controle_de_Gastos.Classes
{
    internal class File
    {
        private readonly static string path = @"C:\Controle de Gastos\";
        private readonly static string file = "database.db";

        public static void Save()
        {
            if (Data.Id != null)
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                StreamWriter writer = new StreamWriter(path + file);

                for (int i = 0; i < Data.Id.Length; i++)
                {
                    var paid = Code.Encrypt(Data.Paid[i].ToString());
                    var date = Code.Encrypt(Data.Date[i].ToString());
                    var expense = Code.Encrypt(Data.Expense[i]);
                    var payment = string.Empty;
                    var comments = string.Empty;
                    var price = Code.Encrypt(Data.Price[i].ToString());

                    if (string.IsNullOrWhiteSpace(Data.Payment[i])) payment = Code.Encrypt(payment);
                    else payment = Code.Encrypt(Data.Payment[i]);

                    if (string.IsNullOrWhiteSpace(Data.Comments[i])) comments = Code.Encrypt(comments);
                    else comments = Code.Encrypt(Data.Comments[i]);

                    string encrypted = Code.Encrypt(paid + '|' + date + '|' + expense + '|' + payment + '|' + comments + '|' + price);
                    writer.WriteLine(encrypted);
                }

                writer.Close();
            }
        }

        public static void Load()
        {
            if (System.IO.File.Exists(path + file) && new FileInfo(path + file).Length != 0)
            {
                Data.Id = null;
                Data.Paid = null;
                Data.Date = null;
                Data.Expense = null;
                Data.Payment = null;
                Data.Comments = null;
                Data.Price = null;

                List<int> idList = new List<int>();
                List<bool> paidList = new List<bool>();
                List<DateTime> dateList = new List<DateTime>();
                List<string> expenseList = new List<string>();
                List<string> paymentList = new List<string>();
                List<string> commentsList = new List<string>();
                List<double> priceList = new List<double>();

                StreamReader reader = new StreamReader(path + file);
                string line = reader.ReadLine();

                while (line != null)
                {
                    string lineDecrypted = Code.Decrypt(line);
                    string[] content = lineDecrypted.Split('|');

                    idList.Add(idList.Count);
                    paidList.Add(bool.Parse(Code.Decrypt(content[0])));
                    dateList.Add(DateTime.Parse(Code.Decrypt(content[1])));
                    expenseList.Add(Code.Decrypt(content[2]));
                    paymentList.Add(Code.Decrypt(content[3]));
                    commentsList.Add(Code.Decrypt(content[4]));
                    priceList.Add(double.Parse(Code.Decrypt(content[5])));

                    line = reader.ReadLine();
                }

                Data.Id = idList.ToArray();
                Data.Paid = paidList.ToArray();
                Data.Date = dateList.ToArray();
                Data.Expense = expenseList.ToArray();
                Data.Payment = paymentList.ToArray();
                Data.Comments = commentsList.ToArray();
                Data.Price = priceList.ToArray();

                reader.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Gastos.Classes
{
    internal class Data
    {
        private static int selectedId = -1;
        private static double balance = 0;

        private static int[] id;
        private static bool[] paid;
        private static DateTime[] date;
        private static string[] expense;
        private static string[] payment;
        private static string[] comments;
        private static double[] price;

        public static int SelectedId
        {
            get { return selectedId; }
            set { selectedId = value; }
        }

        public static double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static int[] Id
        {
            get { return id; }
            set { id = value; }
        }

        public static bool[] Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public static DateTime[] Date
        {
            get { return date; }
            set { date = value; }
        }

        public static string[] Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public static string[] Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public static string[] Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public static double[] Price
        {
            get { return price; }
            set { price = value; }
        }

        public static string Create(bool paid, DateTime d, string e, string p, string c, double price)
        {
            try
            {
                List<int> idList = new List<int>();
                List<bool> paidList = new List<bool>();
                List<DateTime> dateList = new List<DateTime>();
                List<string> expenseList = new List<string>();
                List<string> paymentList = new List<string>();
                List<string> commentsList = new List<string>();
                List<double> priceList = new List<double>();

                if (Id != null)
                {
                    for (int i = 0; i < Id.Length; i++)
                    {
                        idList.Add(idList.Count);
                        paidList.Add(Paid[i]);
                        dateList.Add(Date[i]);
                        expenseList.Add(Expense[i]);
                        paymentList.Add(Payment[i]);
                        commentsList.Add(Comments[i]);
                        priceList.Add(Price[i]);
                    }
                }
                else idList.Add(idList.Count);
                paidList.Add(paid);
                dateList.Add(d);
                expenseList.Add(e);
                paymentList.Add(p);
                commentsList.Add(c);
                priceList.Add(price);

                Id = idList.ToArray();
                Paid = paidList.ToArray();
                Date = dateList.ToArray();
                Expense = expenseList.ToArray();
                Payment = paymentList.ToArray();
                Comments = commentsList.ToArray();
                Price = priceList.ToArray();

                return "Despesa criada com sucesso!";
            }
            catch (Exception exception)
            {
                return "ERRO: " + exception.Message;
            }
        }

        public static string Update(bool paid, DateTime d, string e, string p, string c, double price)
        {
            try
            {
                Paid[SelectedId] = paid;
                Date[SelectedId] = d;
                Expense[SelectedId] = e;
                Payment[SelectedId] = p;
                Comments[SelectedId] = c;
                Price[SelectedId] = price;

                return "Despesa atualizada com sucesso!";
            }
            catch (Exception exception)
            {
                return "ERRO: " + exception.Message;
            }
        }

        public static string Delete()
        {
            try
            {
                List<int> idList = new List<int>();
                List<bool> paidList = new List<bool>();
                List<DateTime> dateList = new List<DateTime>();
                List<string> expenseList = new List<string>();
                List<string> paymentList = new List<string>();
                List<string> commentsList = new List<string>();
                List<double> priceList = new List<double>();

                if (Id.Length <= 1)
                {
                    Id = null;
                    Paid = null;
                    Date = null;
                    Expense = null;
                    Payment = null;
                    Comments = null;
                    Price = null;
                }
                else if (Id != null)
                {
                    for (int i = 0; i < Id.Length; i++)
                    {
                        if (i != SelectedId)
                        {
                            idList.Add(idList.Count);
                            paidList.Add(Paid[i]);
                            dateList.Add(Date[i]);
                            expenseList.Add(Expense[i]);
                            paymentList.Add(Payment[i]);
                            commentsList.Add(Comments[i]);
                            priceList.Add(Price[i]);
                        }
                    }

                    Id = idList.ToArray();
                    Paid = paidList.ToArray();
                    Date = dateList.ToArray();
                    Expense = expenseList.ToArray();
                    Payment = paymentList.ToArray();
                    Comments = commentsList.ToArray();
                    Price = priceList.ToArray();
                }

                return "Despesa removida com sucesso!";
            }
            catch (Exception exception)
            {
                return "ERRO: " + exception.Message;
            }
        }
    }
}

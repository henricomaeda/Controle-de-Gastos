using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Gastos.Classes
{
    internal class Data
    {
        private static int selected_id = -1;
        private static int[] id;
        private static bool[] paid;
        private static DateTime[] date;
        private static string[] expense;
        private static string[] payment;
        private static string[] comments;
        private static float[] balance;

        public static int SelectedId
        {
            get { return selected_id; }
            set { selected_id = value; }
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

        public static float[] Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}

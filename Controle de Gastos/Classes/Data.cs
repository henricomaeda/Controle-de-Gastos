using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Gastos.Classes
{
    internal class Data
    {
        private static int[] id;
        private static bool[] paid;
        private static DateTime[] date;
        private static string[] expense;
        private static string[] payment;
        private static string[] information;
        private static float[] cost;

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

        public static string[] Information
        {
            get { return information; }
            set { information = value; }
        }

        public static float[] Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}

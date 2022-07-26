﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class FrmCreate : Form
    {
        private double price = 0;
        private readonly string placeholder = "Exemplos: conta de luz, lâmpada ou TV.";

        public FrmCreate()
        {
            InitializeComponent();
            int i = Classes.Data.SelectedId;

            if (i != -1)
            {
                DtpDate.Value = Classes.Data.Date[i];
                TxtExpense.Text = Classes.Data.Expense[i];
                if (Classes.Data.Payment[i] != "Nenhum") CmbPayment.Text = Classes.Data.Payment[i];
                if (Classes.Data.Comments[i] != "Nenhuma") TxtComments.Text = Classes.Data.Comments[i];
                price = Classes.Data.Price[i];

                BtnUpdate.Enabled = true;
                BtnCreate.Enabled = false;
                BtnCreate.BackColor = Color.Gray;
                NudDuplicate.Enabled = false;
            }

            PicLogo.Select();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", price);
            TxtBalance.GotFocus += new EventHandler(TxtBalance_GotFocus);
            TxtBalance.LostFocus += new EventHandler(TxtBalance_LostFocus);

            TxtExpense_LostFocus(TxtExpense, null);
            TxtExpense.GotFocus += new EventHandler(TxtExpense_GotFocus);
            TxtExpense.LostFocus += new EventHandler(TxtExpense_LostFocus);
        }

        private void TxtBalance_GotFocus(object sender, EventArgs e)
        {
            TxtBalance.Text = string.Format("{0:#,##0.00}", price);
        }

        private void TxtBalance_LostFocus(object sender, EventArgs e)
        {
            try
            {
                TxtBalance.Text = string.Format("{0:0.00}", double.Parse(TxtBalance.Text));
                price = double.Parse(TxtBalance.Text);
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

            TxtBalance.Text = "R$ " + string.Format("{0:#,##0.00}", price);
        }

        private void TxtExpense_GotFocus(object sender, EventArgs e)
        {
            if (TxtExpense.Text == placeholder)
            {
                TxtExpense.Text = string.Empty;
                TxtExpense.ForeColor = Color.Black;
            }
        }

        private void TxtExpense_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtExpense.Text))
            {
                TxtExpense.Text = placeholder;
                TxtExpense.ForeColor = Color.Gray;
            }
        }

        private void BtnCreateAndUpdate_Click(object sender, EventArgs e)
        {
            var paid = false;
            var date = DtpDate.Value;
            var expense = TxtExpense.Text;
            var payment = CmbPayment.Text;
            var comments = TxtComments.Text;

            if (string.IsNullOrWhiteSpace(payment)) payment = "Nenhum";
            if (string.IsNullOrWhiteSpace(comments)) comments = "Nenhuma";

            var t = string.Empty;
            var c = string.Empty;
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Warning;

            PicLogo.Select();
            if (expense == placeholder)
            {
                t = "Por favor, preencha o campo de descrição da despesa.";
                MessageBox.Show(t, c, b, i);
            }
            else if (price < 0.00)
            {
                t = "O preço do produto ou serviço deve ser positivo.";
                MessageBox.Show(t, c, b, i);
            }
            else
            {
                var subtitle = "Você deseja adicionar a seguinte despesa?";
                if (sender == BtnUpdate) subtitle = "Você deseja atualizar para a seguinte despesa?";

                var text = subtitle + "\n\nData: " + date.ToString("dd/MMMM/yyyy") + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price) + "\n\nDescrição: " + expense + "\nForma de pagamento: " + payment + "\nObservações: " + comments + "\n\nSituação: Não acertado";
                var caption = string.Empty;
                var buttons = MessageBoxButtons.YesNo;
                var icon = MessageBoxIcon.Question;

                DialogResult dr = MessageBox.Show(text, caption, buttons, icon);
                if (dr == DialogResult.Yes)
                {
                    dr = DialogResult.No;

                    if (paid && Classes.Data.Balance >= 0 && price > Classes.Data.Balance)
                    {
                        text = "Você tem certeza que deseja prosseguir?\nSeu saldo atual se tornará negativo.\n\nSaldo atual: " + string.Format("{0:#,##0.00}", Classes.Data.Balance) + "\nPreço: R$ " + string.Format("{0:#,##0.00}", price);
                        icon = MessageBoxIcon.Warning;

                        dr = MessageBox.Show(text, caption, buttons, icon);
                    }
                    else dr = DialogResult.Yes;

                    if (dr == DialogResult.Yes)
                    {
                        if (sender == BtnCreate) t = Classes.Data.Create(int.Parse(NudDuplicate.Value.ToString()), paid, date, expense, payment, comments, price);
                        else if (sender == BtnUpdate) t = Classes.Data.Update(paid, date, expense, payment, comments, price);

                        if (t != string.Empty) i = MessageBoxIcon.Information;
                        MessageBox.Show(t, c, b, i);

                        Classes.Data.SelectedId = -1;
                        BtnReturn_Click(sender, e);
                    }
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

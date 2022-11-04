namespace Controle_de_Gastos
{
    partial class FrmReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceipt));
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.LblBalance = new System.Windows.Forms.Label();
            this.CmbReceiptDay = new System.Windows.Forms.ComboBox();
            this.LblReceiptDay = new System.Windows.Forms.Label();
            this.ChkReceive = new System.Windows.Forms.CheckBox();
            this.TxtPaymentSelected = new System.Windows.Forms.TextBox();
            this.LblPaymentSelected = new System.Windows.Forms.Label();
            this.BtnPayment_01 = new System.Windows.Forms.Button();
            this.BtnPayment_02 = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtBalance.Location = new System.Drawing.Point(12, 166);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(437, 26);
            this.TxtBalance.TabIndex = 0;
            // 
            // LblBalance
            // 
            this.LblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBalance.AutoSize = true;
            this.LblBalance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblBalance.Location = new System.Drawing.Point(8, 144);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(136, 19);
            this.LblBalance.TabIndex = 5;
            this.LblBalance.Text = "Quanto receberá";
            // 
            // CmbReceiptDay
            // 
            this.CmbReceiptDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbReceiptDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbReceiptDay.Font = new System.Drawing.Font("Arial", 12F);
            this.CmbReceiptDay.FormattingEnabled = true;
            this.CmbReceiptDay.Items.AddRange(new object[] {
            "Nenhum",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "Último dia do mês"});
            this.CmbReceiptDay.Location = new System.Drawing.Point(12, 100);
            this.CmbReceiptDay.Name = "CmbReceiptDay";
            this.CmbReceiptDay.Size = new System.Drawing.Size(437, 26);
            this.CmbReceiptDay.TabIndex = 6;
            // 
            // LblReceiptDay
            // 
            this.LblReceiptDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblReceiptDay.AutoSize = true;
            this.LblReceiptDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblReceiptDay.Location = new System.Drawing.Point(8, 78);
            this.LblReceiptDay.Name = "LblReceiptDay";
            this.LblReceiptDay.Size = new System.Drawing.Size(156, 19);
            this.LblReceiptDay.TabIndex = 7;
            this.LblReceiptDay.Text = "Dia de recebimento";
            // 
            // ChkReceive
            // 
            this.ChkReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkReceive.AutoSize = true;
            this.ChkReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkReceive.Location = new System.Drawing.Point(12, 209);
            this.ChkReceive.Name = "ChkReceive";
            this.ChkReceive.Size = new System.Drawing.Size(193, 21);
            this.ChkReceive.TabIndex = 8;
            this.ChkReceive.Text = "Receber automaticamente";
            this.ChkReceive.UseVisualStyleBackColor = true;
            // 
            // TxtPaymentSelected
            // 
            this.TxtPaymentSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPaymentSelected.Enabled = false;
            this.TxtPaymentSelected.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtPaymentSelected.Location = new System.Drawing.Point(12, 33);
            this.TxtPaymentSelected.Name = "TxtPaymentSelected";
            this.TxtPaymentSelected.ReadOnly = true;
            this.TxtPaymentSelected.Size = new System.Drawing.Size(326, 26);
            this.TxtPaymentSelected.TabIndex = 11;
            this.TxtPaymentSelected.Text = "Primeiro pagamento";
            // 
            // LblPaymentSelected
            // 
            this.LblPaymentSelected.AutoSize = true;
            this.LblPaymentSelected.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblPaymentSelected.Location = new System.Drawing.Point(8, 12);
            this.LblPaymentSelected.Name = "LblPaymentSelected";
            this.LblPaymentSelected.Size = new System.Drawing.Size(193, 19);
            this.LblPaymentSelected.TabIndex = 12;
            this.LblPaymentSelected.Text = "Pagamento selecionado";
            // 
            // BtnPayment_01
            // 
            this.BtnPayment_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPayment_01.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnPayment_01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPayment_01.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment_01.Image = global::Controle_de_Gastos.Properties.Resources._1;
            this.BtnPayment_01.Location = new System.Drawing.Point(344, 12);
            this.BtnPayment_01.Name = "BtnPayment_01";
            this.BtnPayment_01.Size = new System.Drawing.Size(49, 47);
            this.BtnPayment_01.TabIndex = 10;
            this.BtnPayment_01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPayment_01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPayment_01.UseVisualStyleBackColor = false;
            this.BtnPayment_01.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnPayment_02
            // 
            this.BtnPayment_02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPayment_02.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnPayment_02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPayment_02.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment_02.Image = global::Controle_de_Gastos.Properties.Resources._2;
            this.BtnPayment_02.Location = new System.Drawing.Point(399, 12);
            this.BtnPayment_02.Name = "BtnPayment_02";
            this.BtnPayment_02.Size = new System.Drawing.Size(49, 47);
            this.BtnPayment_02.TabIndex = 9;
            this.BtnPayment_02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPayment_02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPayment_02.UseVisualStyleBackColor = false;
            this.BtnPayment_02.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.MintCream;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = global::Controle_de_Gastos.Properties.Resources.UpdateReceive;
            this.BtnUpdate.Location = new System.Drawing.Point(214, 247);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(235, 87);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "ATUALIZAR";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnReturnAndUpdate_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Image = global::Controle_de_Gastos.Properties.Resources.Return;
            this.BtnReturn.Location = new System.Drawing.Point(12, 247);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(185, 87);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "VOLTAR";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturnAndUpdate_Click);
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 346);
            this.Controls.Add(this.LblPaymentSelected);
            this.Controls.Add(this.TxtPaymentSelected);
            this.Controls.Add(this.BtnPayment_01);
            this.Controls.Add(this.BtnPayment_02);
            this.Controls.Add(this.ChkReceive);
            this.Controls.Add(this.LblReceiptDay);
            this.Controls.Add(this.CmbReceiptDay);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimento Mensal";
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.ComboBox CmbReceiptDay;
        private System.Windows.Forms.Label LblReceiptDay;
        private System.Windows.Forms.CheckBox ChkReceive;
        private System.Windows.Forms.Button BtnPayment_02;
        private System.Windows.Forms.Button BtnPayment_01;
        private System.Windows.Forms.TextBox TxtPaymentSelected;
        private System.Windows.Forms.Label LblPaymentSelected;
    }
}
namespace Controle_de_Gastos
{
    partial class FrmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreate));
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TxtExpense = new System.Windows.Forms.TextBox();
            this.TxtComments = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblExpense = new System.Windows.Forms.Label();
            this.LblPayment = new System.Windows.Forms.Label();
            this.LblComments = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblRequired_00 = new System.Windows.Forms.Label();
            this.LblRequired_01 = new System.Windows.Forms.Label();
            this.LblRequired_02 = new System.Windows.Forms.Label();
            this.NudDuplicate = new System.Windows.Forms.NumericUpDown();
            this.LblDuplicate = new System.Windows.Forms.Label();
            this.CmbPayment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDuplicate)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Image = global::Controle_de_Gastos.Properties.Resources.Return;
            this.BtnReturn.Location = new System.Drawing.Point(23, 543);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(171, 63);
            this.BtnReturn.TabIndex = 9;
            this.BtnReturn.Text = "VOLTAR";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = global::Controle_de_Gastos.Properties.Resources.Update;
            this.BtnUpdate.Location = new System.Drawing.Point(209, 543);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(221, 63);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "ATUALIZAR";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnCreateAndUpdate_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreate.Image = global::Controle_de_Gastos.Properties.Resources.Add;
            this.BtnCreate.Location = new System.Drawing.Point(446, 543);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(265, 63);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "ADICIONAR";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreateAndUpdate_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpDate.CustomFormat = "";
            this.DtpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Location = new System.Drawing.Point(23, 149);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(688, 26);
            this.DtpDate.TabIndex = 10;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLogo.Image = global::Controle_de_Gastos.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(23, 21);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(688, 94);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 11;
            this.PicLogo.TabStop = false;
            // 
            // TxtExpense
            // 
            this.TxtExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExpense.Location = new System.Drawing.Point(23, 210);
            this.TxtExpense.Name = "TxtExpense";
            this.TxtExpense.Size = new System.Drawing.Size(688, 26);
            this.TxtExpense.TabIndex = 12;
            // 
            // TxtComments
            // 
            this.TxtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComments.Location = new System.Drawing.Point(23, 328);
            this.TxtComments.Multiline = true;
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(688, 140);
            this.TxtComments.TabIndex = 14;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBalance.Location = new System.Drawing.Point(24, 501);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(455, 26);
            this.TxtBalance.TabIndex = 15;
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(20, 128);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(160, 19);
            this.LblDate.TabIndex = 17;
            this.LblDate.Text = "Data de vencimento";
            // 
            // LblExpense
            // 
            this.LblExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExpense.AutoSize = true;
            this.LblExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpense.Location = new System.Drawing.Point(20, 189);
            this.LblExpense.Name = "LblExpense";
            this.LblExpense.Size = new System.Drawing.Size(178, 19);
            this.LblExpense.TabIndex = 18;
            this.LblExpense.Text = "Descrição da despesa";
            // 
            // LblPayment
            // 
            this.LblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPayment.AutoSize = true;
            this.LblPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPayment.Location = new System.Drawing.Point(20, 247);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(171, 19);
            this.LblPayment.TabIndex = 19;
            this.LblPayment.Text = "Forma de pagamento";
            // 
            // LblComments
            // 
            this.LblComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblComments.AutoSize = true;
            this.LblComments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComments.Location = new System.Drawing.Point(20, 307);
            this.LblComments.Name = "LblComments";
            this.LblComments.Size = new System.Drawing.Size(110, 19);
            this.LblComments.TabIndex = 20;
            this.LblComments.Text = "Observações";
            // 
            // LblBalance
            // 
            this.LblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBalance.AutoSize = true;
            this.LblBalance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBalance.Location = new System.Drawing.Point(21, 480);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(146, 19);
            this.LblBalance.TabIndex = 21;
            this.LblBalance.Text = "Preço da despesa";
            // 
            // LblRequired_00
            // 
            this.LblRequired_00.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRequired_00.AutoSize = true;
            this.LblRequired_00.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequired_00.ForeColor = System.Drawing.Color.Red;
            this.LblRequired_00.Location = new System.Drawing.Point(176, 127);
            this.LblRequired_00.Name = "LblRequired_00";
            this.LblRequired_00.Size = new System.Drawing.Size(15, 19);
            this.LblRequired_00.TabIndex = 23;
            this.LblRequired_00.Text = "*";
            // 
            // LblRequired_01
            // 
            this.LblRequired_01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRequired_01.AutoSize = true;
            this.LblRequired_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequired_01.ForeColor = System.Drawing.Color.Red;
            this.LblRequired_01.Location = new System.Drawing.Point(194, 189);
            this.LblRequired_01.Name = "LblRequired_01";
            this.LblRequired_01.Size = new System.Drawing.Size(15, 19);
            this.LblRequired_01.TabIndex = 24;
            this.LblRequired_01.Text = "*";
            // 
            // LblRequired_02
            // 
            this.LblRequired_02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRequired_02.AutoSize = true;
            this.LblRequired_02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequired_02.ForeColor = System.Drawing.Color.Red;
            this.LblRequired_02.Location = new System.Drawing.Point(164, 480);
            this.LblRequired_02.Name = "LblRequired_02";
            this.LblRequired_02.Size = new System.Drawing.Size(15, 19);
            this.LblRequired_02.TabIndex = 25;
            this.LblRequired_02.Text = "*";
            // 
            // NudDuplicate
            // 
            this.NudDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NudDuplicate.Font = new System.Drawing.Font("Arial", 12F);
            this.NudDuplicate.Location = new System.Drawing.Point(485, 501);
            this.NudDuplicate.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NudDuplicate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDuplicate.Name = "NudDuplicate";
            this.NudDuplicate.Size = new System.Drawing.Size(227, 26);
            this.NudDuplicate.TabIndex = 26;
            this.NudDuplicate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblDuplicate
            // 
            this.LblDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuplicate.AutoSize = true;
            this.LblDuplicate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuplicate.Location = new System.Drawing.Point(496, 480);
            this.LblDuplicate.Name = "LblDuplicate";
            this.LblDuplicate.Size = new System.Drawing.Size(216, 19);
            this.LblDuplicate.TabIndex = 27;
            this.LblDuplicate.Text = "Duplicar conteúdo por mês";
            // 
            // CmbPayment
            // 
            this.CmbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPayment.Font = new System.Drawing.Font("Arial", 12F);
            this.CmbPayment.FormattingEnabled = true;
            this.CmbPayment.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Boleto Bancário",
            "PIX",
            "Crediário",
            "Transferência bancária"});
            this.CmbPayment.Location = new System.Drawing.Point(25, 268);
            this.CmbPayment.Name = "CmbPayment";
            this.CmbPayment.Size = new System.Drawing.Size(686, 26);
            this.CmbPayment.TabIndex = 28;
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 627);
            this.Controls.Add(this.CmbPayment);
            this.Controls.Add(this.LblDuplicate);
            this.Controls.Add(this.NudDuplicate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.LblRequired_02);
            this.Controls.Add(this.LblRequired_01);
            this.Controls.Add(this.LblRequired_00);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblComments);
            this.Controls.Add(this.LblPayment);
            this.Controls.Add(this.LblExpense);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtComments);
            this.Controls.Add(this.TxtExpense);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDuplicate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox TxtExpense;
        private System.Windows.Forms.TextBox TxtComments;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblExpense;
        private System.Windows.Forms.Label LblPayment;
        private System.Windows.Forms.Label LblComments;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label LblRequired_00;
        private System.Windows.Forms.Label LblRequired_01;
        private System.Windows.Forms.Label LblRequired_02;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.NumericUpDown NudDuplicate;
        private System.Windows.Forms.Label LblDuplicate;
        private System.Windows.Forms.ComboBox CmbPayment;
    }
}
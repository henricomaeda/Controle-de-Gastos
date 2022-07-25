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
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.TxtComments = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.RdoPaid = new System.Windows.Forms.RadioButton();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblExpense = new System.Windows.Forms.Label();
            this.LblPayment = new System.Windows.Forms.Label();
            this.LblComments = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblPaid = new System.Windows.Forms.Label();
            this.LblRequired_00 = new System.Windows.Forms.Label();
            this.LblRequired_01 = new System.Windows.Forms.Label();
            this.LblRequired_02 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Image = global::Controle_de_Gastos.Properties.Resources.Return;
            this.BtnReturn.Location = new System.Drawing.Point(23, 550);
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
            this.BtnUpdate.Location = new System.Drawing.Point(209, 550);
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
            this.BtnCreate.Location = new System.Drawing.Point(446, 550);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(247, 63);
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
            this.DtpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Location = new System.Drawing.Point(23, 149);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(670, 26);
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
            this.PicLogo.Size = new System.Drawing.Size(670, 94);
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
            this.TxtExpense.Size = new System.Drawing.Size(670, 26);
            this.TxtExpense.TabIndex = 12;
            // 
            // TxtPayment
            // 
            this.TxtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPayment.Location = new System.Drawing.Point(23, 268);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(670, 26);
            this.TxtPayment.TabIndex = 13;
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
            this.TxtComments.Size = new System.Drawing.Size(670, 82);
            this.TxtComments.TabIndex = 14;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBalance.Location = new System.Drawing.Point(23, 446);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(670, 26);
            this.TxtBalance.TabIndex = 15;
            // 
            // RdoPaid
            // 
            this.RdoPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RdoPaid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoPaid.Location = new System.Drawing.Point(23, 488);
            this.RdoPaid.Name = "RdoPaid";
            this.RdoPaid.Size = new System.Drawing.Size(670, 24);
            this.RdoPaid.TabIndex = 16;
            this.RdoPaid.TabStop = true;
            this.RdoPaid.Text = "A despesa acima, no momento, está paga?";
            this.RdoPaid.UseVisualStyleBackColor = true;
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(20, 128);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(44, 19);
            this.LblDate.TabIndex = 17;
            this.LblDate.Text = "Data";
            // 
            // LblExpense
            // 
            this.LblExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExpense.AutoSize = true;
            this.LblExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExpense.Location = new System.Drawing.Point(20, 189);
            this.LblExpense.Name = "LblExpense";
            this.LblExpense.Size = new System.Drawing.Size(180, 19);
            this.LblExpense.TabIndex = 18;
            this.LblExpense.Text = "Descrição da Despesa";
            // 
            // LblPayment
            // 
            this.LblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPayment.AutoSize = true;
            this.LblPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPayment.Location = new System.Drawing.Point(20, 247);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(172, 19);
            this.LblPayment.TabIndex = 19;
            this.LblPayment.Text = "Forma de Pagamento";
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
            this.LblBalance.Location = new System.Drawing.Point(20, 425);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(48, 19);
            this.LblBalance.TabIndex = 21;
            this.LblBalance.Text = "Valor";
            // 
            // LblPaid
            // 
            this.LblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPaid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaid.ForeColor = System.Drawing.Color.Red;
            this.LblPaid.Location = new System.Drawing.Point(20, 515);
            this.LblPaid.Name = "LblPaid";
            this.LblPaid.Size = new System.Drawing.Size(673, 18);
            this.LblPaid.TabIndex = 22;
            this.LblPaid.Text = "Caso o botão de seleção esteja marcado, o valor inserido acima será removido do s" +
    "eu \"saldo\".";
            // 
            // LblRequired_00
            // 
            this.LblRequired_00.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRequired_00.AutoSize = true;
            this.LblRequired_00.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequired_00.ForeColor = System.Drawing.Color.Red;
            this.LblRequired_00.Location = new System.Drawing.Point(70, 129);
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
            this.LblRequired_01.Location = new System.Drawing.Point(206, 189);
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
            this.LblRequired_02.Location = new System.Drawing.Point(74, 426);
            this.LblRequired_02.Name = "LblRequired_02";
            this.LblRequired_02.Size = new System.Drawing.Size(15, 19);
            this.LblRequired_02.TabIndex = 25;
            this.LblRequired_02.Text = "*";
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 634);
            this.Controls.Add(this.LblRequired_02);
            this.Controls.Add(this.LblRequired_01);
            this.Controls.Add(this.LblRequired_00);
            this.Controls.Add(this.LblPaid);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblComments);
            this.Controls.Add(this.LblPayment);
            this.Controls.Add(this.LblExpense);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.RdoPaid);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtComments);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.TxtExpense);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox TxtExpense;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.TextBox TxtComments;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.RadioButton RdoPaid;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblExpense;
        private System.Windows.Forms.Label LblPayment;
        private System.Windows.Forms.Label LblComments;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label LblPaid;
        private System.Windows.Forms.Label LblRequired_00;
        private System.Windows.Forms.Label LblRequired_01;
        private System.Windows.Forms.Label LblRequired_02;
    }
}
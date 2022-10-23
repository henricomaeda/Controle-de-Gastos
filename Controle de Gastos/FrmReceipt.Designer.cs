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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtBalance.Location = new System.Drawing.Point(12, 106);
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
            this.LblBalance.Location = new System.Drawing.Point(8, 84);
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
            this.CmbReceiptDay.Location = new System.Drawing.Point(12, 40);
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
            this.LblReceiptDay.Location = new System.Drawing.Point(8, 18);
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
            this.ChkReceive.Location = new System.Drawing.Point(12, 149);
            this.ChkReceive.Name = "ChkReceive";
            this.ChkReceive.Size = new System.Drawing.Size(193, 21);
            this.ChkReceive.TabIndex = 8;
            this.ChkReceive.Text = "Receber automaticamente";
            this.ChkReceive.UseVisualStyleBackColor = true;
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
            this.BtnUpdate.Location = new System.Drawing.Point(214, 184);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(235, 89);
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
            this.BtnReturn.Location = new System.Drawing.Point(12, 184);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(185, 89);
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
            this.ClientSize = new System.Drawing.Size(460, 285);
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
    }
}
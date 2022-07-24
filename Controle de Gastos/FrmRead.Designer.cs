namespace Controle_de_Gastos
{
    partial class FrmRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRead));
            this.DgvSpending = new System.Windows.Forms.DataGridView();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.TxtSpent = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.BtnDate = new System.Windows.Forms.Button();
            this.BtnSpent = new System.Windows.Forms.Button();
            this.BtnBalance = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSpending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSpending
            // 
            this.DgvSpending.AllowUserToAddRows = false;
            this.DgvSpending.AllowUserToDeleteRows = false;
            this.DgvSpending.AllowUserToResizeColumns = false;
            this.DgvSpending.AllowUserToResizeRows = false;
            this.DgvSpending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSpending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSpending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvSpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSpending.EnableHeadersVisualStyles = false;
            this.DgvSpending.Location = new System.Drawing.Point(22, 207);
            this.DgvSpending.MultiSelect = false;
            this.DgvSpending.Name = "DgvSpending";
            this.DgvSpending.ReadOnly = true;
            this.DgvSpending.RowHeadersVisible = false;
            this.DgvSpending.Size = new System.Drawing.Size(946, 366);
            this.DgvSpending.TabIndex = 1;
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "TODOS OS MESES",
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.CmbCategory.Location = new System.Drawing.Point(318, 144);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(241, 35);
            this.CmbCategory.TabIndex = 5;
            // 
            // TxtSpent
            // 
            this.TxtSpent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSpent.Enabled = false;
            this.TxtSpent.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSpent.Location = new System.Drawing.Point(754, 145);
            this.TxtSpent.Name = "TxtSpent";
            this.TxtSpent.Size = new System.Drawing.Size(205, 35);
            this.TxtSpent.TabIndex = 6;
            this.TxtSpent.Text = "0";
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBalance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBalance.Location = new System.Drawing.Point(752, 53);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(207, 35);
            this.TxtBalance.TabIndex = 9;
            this.TxtBalance.Text = "0";
            // 
            // BtnDate
            // 
            this.BtnDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDate.Font = new System.Drawing.Font("Arial", 20F);
            this.BtnDate.Image = global::Controle_de_Gastos.Properties.Resources.Date;
            this.BtnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDate.Location = new System.Drawing.Point(200, 132);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Size = new System.Drawing.Size(368, 60);
            this.BtnDate.TabIndex = 13;
            this.BtnDate.Text = "MÊS:";
            this.BtnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDate.UseVisualStyleBackColor = true;
            this.BtnDate.Click += new System.EventHandler(this.BtnBalanceAndSpentAndDate_Click);
            // 
            // BtnSpent
            // 
            this.BtnSpent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSpent.Font = new System.Drawing.Font("Arial", 20F);
            this.BtnSpent.Image = global::Controle_de_Gastos.Properties.Resources.Spent;
            this.BtnSpent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSpent.Location = new System.Drawing.Point(587, 132);
            this.BtnSpent.Name = "BtnSpent";
            this.BtnSpent.Size = new System.Drawing.Size(381, 60);
            this.BtnSpent.TabIndex = 12;
            this.BtnSpent.Text = "GASTO:";
            this.BtnSpent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSpent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSpent.UseVisualStyleBackColor = true;
            this.BtnSpent.Click += new System.EventHandler(this.BtnBalanceAndSpentAndDate_Click);
            // 
            // BtnBalance
            // 
            this.BtnBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBalance.Font = new System.Drawing.Font("Arial", 20F);
            this.BtnBalance.Image = global::Controle_de_Gastos.Properties.Resources.Balance;
            this.BtnBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBalance.Location = new System.Drawing.Point(587, 22);
            this.BtnBalance.Name = "BtnBalance";
            this.BtnBalance.Size = new System.Drawing.Size(381, 94);
            this.BtnBalance.TabIndex = 11;
            this.BtnBalance.Text = "SALDO:";
            this.BtnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBalance.UseVisualStyleBackColor = true;
            this.BtnBalance.Click += new System.EventHandler(this.BtnBalanceAndSpentAndDate_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Image = global::Controle_de_Gastos.Properties.Resources.Return;
            this.BtnReturn.Location = new System.Drawing.Point(22, 132);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(162, 60);
            this.BtnReturn.TabIndex = 2;
            this.BtnReturn.Text = "VOLTAR";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLogo.Image = global::Controle_de_Gastos.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(22, 22);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(546, 94);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // FrmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 595);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.BtnDate);
            this.Controls.Add(this.TxtSpent);
            this.Controls.Add(this.BtnSpent);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.BtnBalance);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DgvSpending);
            this.Controls.Add(this.PicLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.Load += new System.EventHandler(this.FrmRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSpending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.DataGridView DgvSpending;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.TextBox TxtSpent;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.Button BtnBalance;
        private System.Windows.Forms.Button BtnSpent;
        private System.Windows.Forms.Button BtnDate;
    }
}
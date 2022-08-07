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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRead));
            this.DgvSpending = new System.Windows.Forms.DataGridView();
            this.Column_00 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_07 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_08 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.TxtSpent = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.DgvSpending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSpending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSpending.BackgroundColor = System.Drawing.Color.Silver;
            this.DgvSpending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSpending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvSpending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSpending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSpending.ColumnHeadersHeight = 50;
            this.DgvSpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSpending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_00,
            this.Column_01,
            this.Column_02,
            this.Column_03,
            this.Column_04,
            this.Column_05,
            this.Column_06,
            this.Column_07,
            this.Column_08});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSpending.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSpending.EnableHeadersVisualStyles = false;
            this.DgvSpending.Location = new System.Drawing.Point(22, 207);
            this.DgvSpending.MultiSelect = false;
            this.DgvSpending.Name = "DgvSpending";
            this.DgvSpending.ReadOnly = true;
            this.DgvSpending.RowHeadersVisible = false;
            this.DgvSpending.RowTemplate.Height = 40;
            this.DgvSpending.RowTemplate.ReadOnly = true;
            this.DgvSpending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSpending.Size = new System.Drawing.Size(946, 366);
            this.DgvSpending.TabIndex = 1;
            // 
            // Column_00
            // 
            this.Column_00.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_00.FillWeight = 91.37056F;
            this.Column_00.HeaderText = "";
            this.Column_00.Image = global::Controle_de_Gastos.Properties.Resources.Unpaid;
            this.Column_00.Name = "Column_00";
            this.Column_00.ReadOnly = true;
            this.Column_00.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_00.Width = 40;
            // 
            // Column_01
            // 
            this.Column_01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_01.HeaderText = "Identificador";
            this.Column_01.Name = "Column_01";
            this.Column_01.ReadOnly = true;
            this.Column_01.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_01.Visible = false;
            // 
            // Column_02
            // 
            this.Column_02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_02.FillWeight = 101.7259F;
            this.Column_02.HeaderText = "Data";
            this.Column_02.Name = "Column_02";
            this.Column_02.ReadOnly = true;
            this.Column_02.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_02.Width = 53;
            // 
            // Column_03
            // 
            this.Column_03.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_03.FillWeight = 101.7259F;
            this.Column_03.HeaderText = "Despesa";
            this.Column_03.Name = "Column_03";
            this.Column_03.ReadOnly = true;
            this.Column_03.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_03.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_03.Width = 91;
            // 
            // Column_04
            // 
            this.Column_04.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_04.FillWeight = 101.7259F;
            this.Column_04.HeaderText = "Pagamento";
            this.Column_04.Name = "Column_04";
            this.Column_04.ReadOnly = true;
            this.Column_04.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_04.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_04.Width = 111;
            // 
            // Column_05
            // 
            this.Column_05.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_05.FillWeight = 101.7259F;
            this.Column_05.HeaderText = "Observações";
            this.Column_05.Name = "Column_05";
            this.Column_05.ReadOnly = true;
            this.Column_05.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_05.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_06
            // 
            this.Column_06.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_06.FillWeight = 101.7259F;
            this.Column_06.HeaderText = "Valor";
            this.Column_06.Name = "Column_06";
            this.Column_06.ReadOnly = true;
            this.Column_06.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_06.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_06.Width = 57;
            // 
            // Column_07
            // 
            this.Column_07.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_07.HeaderText = "";
            this.Column_07.Image = global::Controle_de_Gastos.Properties.Resources.Change;
            this.Column_07.Name = "Column_07";
            this.Column_07.ReadOnly = true;
            this.Column_07.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_07.Width = 40;
            // 
            // Column_08
            // 
            this.Column_08.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_08.HeaderText = "";
            this.Column_08.Image = global::Controle_de_Gastos.Properties.Resources.Delete;
            this.Column_08.Name = "Column_08";
            this.Column_08.ReadOnly = true;
            this.Column_08.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_08.Width = 40;
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
            this.CmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 91.37056F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Controle_de_Gastos.Properties.Resources.Unpaid;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Controle_de_Gastos.Properties.Resources.Change;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Controle_de_Gastos.Properties.Resources.Delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 40;
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
        private System.Windows.Forms.DataGridViewImageColumn Column_00;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_02;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_03;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_04;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_05;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_06;
        private System.Windows.Forms.DataGridViewImageColumn Column_07;
        private System.Windows.Forms.DataGridViewImageColumn Column_08;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
    }
}
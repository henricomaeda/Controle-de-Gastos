namespace Controle_de_Gastos
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GrpControl = new System.Windows.Forms.GroupBox();
            this.LblLine = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.GrpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpControl
            // 
            this.GrpControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpControl.Controls.Add(this.LblLine);
            this.GrpControl.Controls.Add(this.BtnCreate);
            this.GrpControl.Controls.Add(this.BtnReceipt);
            this.GrpControl.Controls.Add(this.BtnLeave);
            this.GrpControl.Controls.Add(this.BtnRead);
            this.GrpControl.Location = new System.Drawing.Point(673, 12);
            this.GrpControl.Name = "GrpControl";
            this.GrpControl.Size = new System.Drawing.Size(260, 542);
            this.GrpControl.TabIndex = 5;
            this.GrpControl.TabStop = false;
            // 
            // LblLine
            // 
            this.LblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLine.Location = new System.Drawing.Point(15, 151);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(231, 2);
            this.LblLine.TabIndex = 5;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreate.Image = global::Controle_de_Gastos.Properties.Resources.Create;
            this.BtnCreate.Location = new System.Drawing.Point(15, 28);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(231, 109);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "ADICIONAR";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnNavigation_Click);
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReceipt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceipt.Image = global::Controle_de_Gastos.Properties.Resources.Receipt;
            this.BtnReceipt.Location = new System.Drawing.Point(15, 292);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(231, 109);
            this.BtnReceipt.TabIndex = 4;
            this.BtnReceipt.Text = "RECEBER";
            this.BtnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReceipt.UseVisualStyleBackColor = true;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnNavigation_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLeave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeave.Image = global::Controle_de_Gastos.Properties.Resources.Leave;
            this.BtnLeave.Location = new System.Drawing.Point(15, 417);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(231, 109);
            this.BtnLeave.TabIndex = 3;
            this.BtnLeave.Text = "FINALIZAR";
            this.BtnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLeave.UseVisualStyleBackColor = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRead.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Image = global::Controle_de_Gastos.Properties.Resources.Read;
            this.BtnRead.Location = new System.Drawing.Point(15, 166);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(231, 109);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "CONSULTAR";
            this.BtnRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnNavigation_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.Image = global::Controle_de_Gastos.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(12, 12);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(655, 542);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 566);
            this.Controls.Add(this.GrpControl);
            this.Controls.Add(this.PicLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.GrpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnLeave;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Windows.Forms.GroupBox GrpControl;
        private System.Windows.Forms.Label LblLine;
    }
}


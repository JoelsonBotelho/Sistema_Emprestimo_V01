namespace Emprestimo_V01
{
    partial class frmGrupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.lblGestaoDosGrupos = new DevComponents.DotNetBar.LabelX();
            this.btnGruposEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnGruposRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnGruposInserir = new DevComponents.DotNetBar.ButtonX();
            this.lblGruposNome = new DevComponents.DotNetBar.LabelX();
            this.txtGruposNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvGrupos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblGrupos = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            // 
            // 
            // 
            this.lblVersao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersao.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(257, 431);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(210, 23);
            this.lblVersao.TabIndex = 34;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblGestaoDosGrupos
            // 
            // 
            // 
            // 
            this.lblGestaoDosGrupos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDosGrupos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDosGrupos.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDosGrupos.Location = new System.Drawing.Point(225, 43);
            this.lblGestaoDosGrupos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDosGrupos.Name = "lblGestaoDosGrupos";
            this.lblGestaoDosGrupos.Size = new System.Drawing.Size(274, 45);
            this.lblGestaoDosGrupos.Symbol = "";
            this.lblGestaoDosGrupos.TabIndex = 42;
            this.lblGestaoDosGrupos.Text = " Gestão dos Grupos";
            // 
            // btnGruposEditar
            // 
            this.btnGruposEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGruposEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnGruposEditar.Location = new System.Drawing.Point(365, 124);
            this.btnGruposEditar.Name = "btnGruposEditar";
            this.btnGruposEditar.Size = new System.Drawing.Size(104, 35);
            this.btnGruposEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnGruposEditar.Symbol = "";
            this.btnGruposEditar.SymbolSize = 15F;
            this.btnGruposEditar.TabIndex = 41;
            this.btnGruposEditar.Text = " Editar";
            this.btnGruposEditar.TextColor = System.Drawing.Color.White;
            this.btnGruposEditar.Click += new System.EventHandler(this.btnGruposEditar_Click);
            // 
            // btnGruposRemover
            // 
            this.btnGruposRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGruposRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnGruposRemover.Location = new System.Drawing.Point(475, 124);
            this.btnGruposRemover.Name = "btnGruposRemover";
            this.btnGruposRemover.Size = new System.Drawing.Size(141, 35);
            this.btnGruposRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnGruposRemover.Symbol = "";
            this.btnGruposRemover.SymbolSize = 15F;
            this.btnGruposRemover.TabIndex = 40;
            this.btnGruposRemover.Text = " Remover";
            this.btnGruposRemover.TextColor = System.Drawing.Color.White;
            this.btnGruposRemover.Click += new System.EventHandler(this.btnGruposRemover_Click);
            // 
            // btnGruposInserir
            // 
            this.btnGruposInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGruposInserir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnGruposInserir.Location = new System.Drawing.Point(238, 124);
            this.btnGruposInserir.Name = "btnGruposInserir";
            this.btnGruposInserir.Size = new System.Drawing.Size(121, 35);
            this.btnGruposInserir.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnGruposInserir.Symbol = "";
            this.btnGruposInserir.SymbolSize = 15F;
            this.btnGruposInserir.TabIndex = 39;
            this.btnGruposInserir.Text = " Inserir";
            this.btnGruposInserir.TextColor = System.Drawing.Color.White;
            this.btnGruposInserir.Click += new System.EventHandler(this.btnGruposInserir_Click);
            // 
            // lblGruposNome
            // 
            // 
            // 
            // 
            this.lblGruposNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGruposNome.ForeColor = System.Drawing.Color.White;
            this.lblGruposNome.Location = new System.Drawing.Point(105, 323);
            this.lblGruposNome.Name = "lblGruposNome";
            this.lblGruposNome.Size = new System.Drawing.Size(92, 34);
            this.lblGruposNome.Symbol = "";
            this.lblGruposNome.SymbolSize = 13F;
            this.lblGruposNome.TabIndex = 38;
            this.lblGruposNome.Text = " Nome";
            // 
            // txtGruposNome
            // 
            // 
            // 
            // 
            this.txtGruposNome.Border.Class = "TextBoxBorder";
            this.txtGruposNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGruposNome.Location = new System.Drawing.Point(203, 323);
            this.txtGruposNome.Name = "txtGruposNome";
            this.txtGruposNome.PreventEnterBeep = true;
            this.txtGruposNome.Size = new System.Drawing.Size(413, 34);
            this.txtGruposNome.TabIndex = 37;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGrupos.Location = new System.Drawing.Point(105, 164);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.RowTemplate.Height = 24;
            this.dgvGrupos.Size = new System.Drawing.Size(511, 150);
            this.dgvGrupos.TabIndex = 36;
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            // 
            // 
            // 
            this.lblGrupos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGrupos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupos.ForeColor = System.Drawing.Color.White;
            this.lblGrupos.Location = new System.Drawing.Point(105, 124);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(129, 34);
            this.lblGrupos.Symbol = "";
            this.lblGrupos.TabIndex = 35;
            this.lblGrupos.Text = " Grupos";
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(693, 424);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(32, 35);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 54;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.lblGestaoDosGrupos);
            this.Controls.Add(this.btnGruposEditar);
            this.Controls.Add(this.btnGruposRemover);
            this.Controls.Add(this.btnGruposInserir);
            this.Controls.Add(this.lblGruposNome);
            this.Controls.Add(this.txtGruposNome);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.lblGrupos);
            this.Controls.Add(this.lblVersao);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrupo";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.LabelX lblGestaoDosGrupos;
        private DevComponents.DotNetBar.ButtonX btnGruposEditar;
        private DevComponents.DotNetBar.ButtonX btnGruposRemover;
        private DevComponents.DotNetBar.ButtonX btnGruposInserir;
        private DevComponents.DotNetBar.LabelX lblGruposNome;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGruposNome;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGrupos;
        private DevComponents.DotNetBar.LabelX lblGrupos;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
    }
}
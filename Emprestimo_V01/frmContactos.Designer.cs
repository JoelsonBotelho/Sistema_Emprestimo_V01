namespace Emprestimo_V01
{
    partial class frmContactos
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
            this.lblGestaoDosContactos = new DevComponents.DotNetBar.LabelX();
            this.btnContactosEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnContactosRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnContactosInserir = new DevComponents.DotNetBar.ButtonX();
            this.cmbContactosNome = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblContactosNome = new DevComponents.DotNetBar.LabelX();
            this.lblContactosNumero = new DevComponents.DotNetBar.LabelX();
            this.txtContactosNumero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvContactos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblContactos = new DevComponents.DotNetBar.LabelX();
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestaoDosContactos
            // 
            // 
            // 
            // 
            this.lblGestaoDosContactos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDosContactos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDosContactos.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDosContactos.Location = new System.Drawing.Point(227, 29);
            this.lblGestaoDosContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDosContactos.Name = "lblGestaoDosContactos";
            this.lblGestaoDosContactos.Size = new System.Drawing.Size(299, 45);
            this.lblGestaoDosContactos.Symbol = "";
            this.lblGestaoDosContactos.TabIndex = 42;
            this.lblGestaoDosContactos.Text = " Gestão dos Contactos";
            // 
            // btnContactosEditar
            // 
            this.btnContactosEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactosEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnContactosEditar.Location = new System.Drawing.Point(382, 111);
            this.btnContactosEditar.Name = "btnContactosEditar";
            this.btnContactosEditar.Size = new System.Drawing.Size(104, 35);
            this.btnContactosEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnContactosEditar.Symbol = "";
            this.btnContactosEditar.SymbolSize = 15F;
            this.btnContactosEditar.TabIndex = 41;
            this.btnContactosEditar.Text = " Editar";
            this.btnContactosEditar.TextColor = System.Drawing.Color.White;
            this.btnContactosEditar.Click += new System.EventHandler(this.btnContactosEditar_Click);
            // 
            // btnContactosRemover
            // 
            this.btnContactosRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactosRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnContactosRemover.Location = new System.Drawing.Point(492, 111);
            this.btnContactosRemover.Name = "btnContactosRemover";
            this.btnContactosRemover.Size = new System.Drawing.Size(126, 35);
            this.btnContactosRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnContactosRemover.Symbol = "";
            this.btnContactosRemover.SymbolSize = 15F;
            this.btnContactosRemover.TabIndex = 40;
            this.btnContactosRemover.Text = " Remover";
            this.btnContactosRemover.TextColor = System.Drawing.Color.White;
            this.btnContactosRemover.Click += new System.EventHandler(this.btnContactosRemover_Click);
            // 
            // btnContactosInserir
            // 
            this.btnContactosInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContactosInserir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnContactosInserir.Location = new System.Drawing.Point(270, 111);
            this.btnContactosInserir.Name = "btnContactosInserir";
            this.btnContactosInserir.Size = new System.Drawing.Size(106, 35);
            this.btnContactosInserir.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnContactosInserir.Symbol = "";
            this.btnContactosInserir.SymbolSize = 15F;
            this.btnContactosInserir.TabIndex = 39;
            this.btnContactosInserir.Text = " Inserir";
            this.btnContactosInserir.TextColor = System.Drawing.Color.White;
            this.btnContactosInserir.Click += new System.EventHandler(this.btnContactosInserir_Click);
            // 
            // cmbContactosNome
            // 
            this.cmbContactosNome.DisplayMember = "Text";
            this.cmbContactosNome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbContactosNome.FormattingEnabled = true;
            this.cmbContactosNome.ItemHeight = 29;
            this.cmbContactosNome.Location = new System.Drawing.Point(212, 368);
            this.cmbContactosNome.Name = "cmbContactosNome";
            this.cmbContactosNome.Size = new System.Drawing.Size(406, 35);
            this.cmbContactosNome.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbContactosNome.TabIndex = 38;
            this.cmbContactosNome.SelectedIndexChanged += new System.EventHandler(this.cmbContactosNome_SelectedIndexChanged);
            // 
            // lblContactosNome
            // 
            // 
            // 
            // 
            this.lblContactosNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactosNome.ForeColor = System.Drawing.Color.White;
            this.lblContactosNome.Location = new System.Drawing.Point(107, 368);
            this.lblContactosNome.Name = "lblContactosNome";
            this.lblContactosNome.Size = new System.Drawing.Size(99, 35);
            this.lblContactosNome.Symbol = "";
            this.lblContactosNome.SymbolSize = 13F;
            this.lblContactosNome.TabIndex = 37;
            this.lblContactosNome.Text = " Nome";
            // 
            // lblContactosNumero
            // 
            // 
            // 
            // 
            this.lblContactosNumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactosNumero.ForeColor = System.Drawing.Color.White;
            this.lblContactosNumero.Location = new System.Drawing.Point(107, 310);
            this.lblContactosNumero.Name = "lblContactosNumero";
            this.lblContactosNumero.Size = new System.Drawing.Size(124, 34);
            this.lblContactosNumero.Symbol = "";
            this.lblContactosNumero.SymbolSize = 13F;
            this.lblContactosNumero.TabIndex = 36;
            this.lblContactosNumero.Text = " Numero";
            // 
            // txtContactosNumero
            // 
            // 
            // 
            // 
            this.txtContactosNumero.Border.Class = "TextBoxBorder";
            this.txtContactosNumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactosNumero.Location = new System.Drawing.Point(227, 310);
            this.txtContactosNumero.Name = "txtContactosNumero";
            this.txtContactosNumero.PreventEnterBeep = true;
            this.txtContactosNumero.Size = new System.Drawing.Size(391, 34);
            this.txtContactosNumero.TabIndex = 35;
            // 
            // dgvContactos
            // 
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContactos.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContactos.Location = new System.Drawing.Point(107, 151);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowTemplate.Height = 24;
            this.dgvContactos.Size = new System.Drawing.Size(511, 150);
            this.dgvContactos.TabIndex = 34;
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            // 
            // 
            // 
            this.lblContactos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContactos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactos.ForeColor = System.Drawing.Color.White;
            this.lblContactos.Location = new System.Drawing.Point(107, 111);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(157, 34);
            this.lblContactos.Symbol = "";
            this.lblContactos.TabIndex = 33;
            this.lblContactos.Text = " Contactos";
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
            this.lblVersao.TabIndex = 43;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(690, 426);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(34, 32);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 44;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblGestaoDosContactos);
            this.Controls.Add(this.btnContactosEditar);
            this.Controls.Add(this.btnContactosRemover);
            this.Controls.Add(this.btnContactosInserir);
            this.Controls.Add(this.cmbContactosNome);
            this.Controls.Add(this.lblContactosNome);
            this.Controls.Add(this.lblContactosNumero);
            this.Controls.Add(this.txtContactosNumero);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.lblContactos);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContactos";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblGestaoDosContactos;
        private DevComponents.DotNetBar.ButtonX btnContactosEditar;
        private DevComponents.DotNetBar.ButtonX btnContactosRemover;
        private DevComponents.DotNetBar.ButtonX btnContactosInserir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbContactosNome;
        private DevComponents.DotNetBar.LabelX lblContactosNome;
        private DevComponents.DotNetBar.LabelX lblContactosNumero;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContactosNumero;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContactos;
        private DevComponents.DotNetBar.LabelX lblContactos;
        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
    }
}
namespace Emprestimo_V01
{
    partial class frmAmigos
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
            this.btnAmigosEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnAmigosRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnAmigosInserir = new DevComponents.DotNetBar.ButtonX();
            this.cmbAmigosGrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblAmigosGrupo = new DevComponents.DotNetBar.LabelX();
            this.lblAmigosNome = new DevComponents.DotNetBar.LabelX();
            this.txtAmigosNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvAmigos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblAmigos = new DevComponents.DotNetBar.LabelX();
            this.lblGestaoDosAmigos = new DevComponents.DotNetBar.LabelX();
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAmigosEditar
            // 
            this.btnAmigosEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAmigosEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnAmigosEditar.Location = new System.Drawing.Point(367, 98);
            this.btnAmigosEditar.Name = "btnAmigosEditar";
            this.btnAmigosEditar.Size = new System.Drawing.Size(104, 35);
            this.btnAmigosEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAmigosEditar.Symbol = "";
            this.btnAmigosEditar.SymbolSize = 15F;
            this.btnAmigosEditar.TabIndex = 31;
            this.btnAmigosEditar.Text = " Editar";
            this.btnAmigosEditar.TextColor = System.Drawing.Color.White;
            this.btnAmigosEditar.Click += new System.EventHandler(this.btnAmigosEditar_Click);
            // 
            // btnAmigosRemover
            // 
            this.btnAmigosRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAmigosRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnAmigosRemover.Location = new System.Drawing.Point(477, 98);
            this.btnAmigosRemover.Name = "btnAmigosRemover";
            this.btnAmigosRemover.Size = new System.Drawing.Size(141, 35);
            this.btnAmigosRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAmigosRemover.Symbol = "";
            this.btnAmigosRemover.SymbolSize = 15F;
            this.btnAmigosRemover.TabIndex = 30;
            this.btnAmigosRemover.Text = " Remover";
            this.btnAmigosRemover.TextColor = System.Drawing.Color.White;
            this.btnAmigosRemover.Click += new System.EventHandler(this.btnAmigosRemover_Click);
            // 
            // btnAmigosInserir
            // 
            this.btnAmigosInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAmigosInserir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnAmigosInserir.Location = new System.Drawing.Point(240, 98);
            this.btnAmigosInserir.Name = "btnAmigosInserir";
            this.btnAmigosInserir.Size = new System.Drawing.Size(121, 35);
            this.btnAmigosInserir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAmigosInserir.Symbol = "";
            this.btnAmigosInserir.SymbolSize = 15F;
            this.btnAmigosInserir.TabIndex = 29;
            this.btnAmigosInserir.Text = " Inserir";
            this.btnAmigosInserir.TextColor = System.Drawing.Color.White;
            this.btnAmigosInserir.Click += new System.EventHandler(this.btnAmigosInserir_Click);
            // 
            // cmbAmigosGrupo
            // 
            this.cmbAmigosGrupo.DisplayMember = "Text";
            this.cmbAmigosGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAmigosGrupo.FormattingEnabled = true;
            this.cmbAmigosGrupo.ItemHeight = 29;
            this.cmbAmigosGrupo.Location = new System.Drawing.Point(212, 355);
            this.cmbAmigosGrupo.Name = "cmbAmigosGrupo";
            this.cmbAmigosGrupo.Size = new System.Drawing.Size(406, 35);
            this.cmbAmigosGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbAmigosGrupo.TabIndex = 28;
            this.cmbAmigosGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbAmigosGrupo_SelectedIndexChanged);
            // 
            // lblAmigosGrupo
            // 
            // 
            // 
            // 
            this.lblAmigosGrupo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAmigosGrupo.ForeColor = System.Drawing.Color.White;
            this.lblAmigosGrupo.Location = new System.Drawing.Point(107, 355);
            this.lblAmigosGrupo.Name = "lblAmigosGrupo";
            this.lblAmigosGrupo.Size = new System.Drawing.Size(99, 35);
            this.lblAmigosGrupo.Symbol = "";
            this.lblAmigosGrupo.SymbolSize = 13F;
            this.lblAmigosGrupo.TabIndex = 27;
            this.lblAmigosGrupo.Text = " Grupo";
            // 
            // lblAmigosNome
            // 
            // 
            // 
            // 
            this.lblAmigosNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAmigosNome.ForeColor = System.Drawing.Color.White;
            this.lblAmigosNome.Location = new System.Drawing.Point(107, 297);
            this.lblAmigosNome.Name = "lblAmigosNome";
            this.lblAmigosNome.Size = new System.Drawing.Size(92, 34);
            this.lblAmigosNome.Symbol = "";
            this.lblAmigosNome.SymbolSize = 13F;
            this.lblAmigosNome.TabIndex = 26;
            this.lblAmigosNome.Text = " Nome";
            // 
            // txtAmigosNome
            // 
            // 
            // 
            // 
            this.txtAmigosNome.Border.Class = "TextBoxBorder";
            this.txtAmigosNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmigosNome.Location = new System.Drawing.Point(205, 297);
            this.txtAmigosNome.Name = "txtAmigosNome";
            this.txtAmigosNome.PreventEnterBeep = true;
            this.txtAmigosNome.Size = new System.Drawing.Size(413, 34);
            this.txtAmigosNome.TabIndex = 25;
            // 
            // dgvAmigos
            // 
            this.dgvAmigos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAmigos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAmigos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAmigos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAmigos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAmigos.Location = new System.Drawing.Point(107, 138);
            this.dgvAmigos.Name = "dgvAmigos";
            this.dgvAmigos.RowTemplate.Height = 24;
            this.dgvAmigos.Size = new System.Drawing.Size(511, 150);
            this.dgvAmigos.TabIndex = 24;
            // 
            // lblAmigos
            // 
            this.lblAmigos.AutoSize = true;
            // 
            // 
            // 
            this.lblAmigos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAmigos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmigos.ForeColor = System.Drawing.Color.White;
            this.lblAmigos.Location = new System.Drawing.Point(107, 98);
            this.lblAmigos.Name = "lblAmigos";
            this.lblAmigos.Size = new System.Drawing.Size(129, 34);
            this.lblAmigos.Symbol = "";
            this.lblAmigos.TabIndex = 23;
            this.lblAmigos.Text = " Amigos";
            // 
            // lblGestaoDosAmigos
            // 
            // 
            // 
            // 
            this.lblGestaoDosAmigos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDosAmigos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDosAmigos.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDosAmigos.Location = new System.Drawing.Point(227, 22);
            this.lblGestaoDosAmigos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDosAmigos.Name = "lblGestaoDosAmigos";
            this.lblGestaoDosAmigos.Size = new System.Drawing.Size(274, 45);
            this.lblGestaoDosAmigos.Symbol = "";
            this.lblGestaoDosAmigos.TabIndex = 32;
            this.lblGestaoDosAmigos.Text = " Gestão dos Amigos";
            // 
            // lblVersao
            // 
            // 
            // 
            // 
            this.lblVersao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersao.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(257, 432);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(210, 23);
            this.lblVersao.TabIndex = 33;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(685, 422);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(39, 34);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 34;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // frmAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblGestaoDosAmigos);
            this.Controls.Add(this.btnAmigosEditar);
            this.Controls.Add(this.btnAmigosRemover);
            this.Controls.Add(this.btnAmigosInserir);
            this.Controls.Add(this.cmbAmigosGrupo);
            this.Controls.Add(this.lblAmigosGrupo);
            this.Controls.Add(this.lblAmigosNome);
            this.Controls.Add(this.txtAmigosNome);
            this.Controls.Add(this.dgvAmigos);
            this.Controls.Add(this.lblAmigos);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAmigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAmigos";
            this.Load += new System.EventHandler(this.frmAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAmigosEditar;
        private DevComponents.DotNetBar.ButtonX btnAmigosRemover;
        private DevComponents.DotNetBar.ButtonX btnAmigosInserir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbAmigosGrupo;
        private DevComponents.DotNetBar.LabelX lblAmigosGrupo;
        private DevComponents.DotNetBar.LabelX lblAmigosNome;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAmigosNome;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAmigos;
        private DevComponents.DotNetBar.LabelX lblAmigos;
        private DevComponents.DotNetBar.LabelX lblGestaoDosAmigos;
        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
    }
}
namespace Emprestimo_V01
{
    partial class frmCategoria
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
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.lblGestaoDasCategorias = new DevComponents.DotNetBar.LabelX();
            this.btnCategoriasEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnCategoriasRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnCategoriasInserir = new DevComponents.DotNetBar.ButtonX();
            this.lblCategoriasNome = new DevComponents.DotNetBar.LabelX();
            this.txtCategoriasNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvCategorias = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblCategorias = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
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
            this.lblVersao.TabIndex = 44;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblGestaoDasCategorias
            // 
            // 
            // 
            // 
            this.lblGestaoDasCategorias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDasCategorias.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDasCategorias.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDasCategorias.Location = new System.Drawing.Point(213, 38);
            this.lblGestaoDasCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDasCategorias.Name = "lblGestaoDasCategorias";
            this.lblGestaoDasCategorias.Size = new System.Drawing.Size(299, 45);
            this.lblGestaoDasCategorias.Symbol = "";
            this.lblGestaoDasCategorias.TabIndex = 45;
            this.lblGestaoDasCategorias.Text = " Gestão das Categorias";
            // 
            // btnCategoriasEditar
            // 
            this.btnCategoriasEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCategoriasEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCategoriasEditar.Location = new System.Drawing.Point(387, 131);
            this.btnCategoriasEditar.Name = "btnCategoriasEditar";
            this.btnCategoriasEditar.Size = new System.Drawing.Size(96, 35);
            this.btnCategoriasEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCategoriasEditar.Symbol = "";
            this.btnCategoriasEditar.SymbolSize = 15F;
            this.btnCategoriasEditar.TabIndex = 52;
            this.btnCategoriasEditar.Text = " Editar";
            this.btnCategoriasEditar.TextColor = System.Drawing.Color.White;
            this.btnCategoriasEditar.Click += new System.EventHandler(this.btnCategoriasEditar_Click);
            // 
            // btnCategoriasRemover
            // 
            this.btnCategoriasRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCategoriasRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCategoriasRemover.Location = new System.Drawing.Point(489, 131);
            this.btnCategoriasRemover.Name = "btnCategoriasRemover";
            this.btnCategoriasRemover.Size = new System.Drawing.Size(129, 35);
            this.btnCategoriasRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCategoriasRemover.Symbol = "";
            this.btnCategoriasRemover.SymbolSize = 15F;
            this.btnCategoriasRemover.TabIndex = 51;
            this.btnCategoriasRemover.Text = " Remover";
            this.btnCategoriasRemover.TextColor = System.Drawing.Color.White;
            this.btnCategoriasRemover.Click += new System.EventHandler(this.btnCategoriasRemover_Click);
            // 
            // btnCategoriasInserir
            // 
            this.btnCategoriasInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCategoriasInserir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCategoriasInserir.Location = new System.Drawing.Point(273, 131);
            this.btnCategoriasInserir.Name = "btnCategoriasInserir";
            this.btnCategoriasInserir.Size = new System.Drawing.Size(108, 35);
            this.btnCategoriasInserir.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCategoriasInserir.Symbol = "";
            this.btnCategoriasInserir.SymbolSize = 15F;
            this.btnCategoriasInserir.TabIndex = 50;
            this.btnCategoriasInserir.Text = " Inserir";
            this.btnCategoriasInserir.TextColor = System.Drawing.Color.White;
            this.btnCategoriasInserir.Click += new System.EventHandler(this.btnCategoriasInserir_Click);
            // 
            // lblCategoriasNome
            // 
            // 
            // 
            // 
            this.lblCategoriasNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCategoriasNome.ForeColor = System.Drawing.Color.White;
            this.lblCategoriasNome.Location = new System.Drawing.Point(107, 330);
            this.lblCategoriasNome.Name = "lblCategoriasNome";
            this.lblCategoriasNome.Size = new System.Drawing.Size(92, 34);
            this.lblCategoriasNome.Symbol = "";
            this.lblCategoriasNome.SymbolSize = 13F;
            this.lblCategoriasNome.TabIndex = 49;
            this.lblCategoriasNome.Text = " Nome";
            // 
            // txtCategoriasNome
            // 
            // 
            // 
            // 
            this.txtCategoriasNome.Border.Class = "TextBoxBorder";
            this.txtCategoriasNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCategoriasNome.Location = new System.Drawing.Point(205, 330);
            this.txtCategoriasNome.Name = "txtCategoriasNome";
            this.txtCategoriasNome.PreventEnterBeep = true;
            this.txtCategoriasNome.Size = new System.Drawing.Size(413, 34);
            this.txtCategoriasNome.TabIndex = 48;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCategorias.Location = new System.Drawing.Point(107, 171);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(511, 150);
            this.dgvCategorias.TabIndex = 47;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            // 
            // 
            // 
            this.lblCategorias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCategorias.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.Color.White;
            this.lblCategorias.Location = new System.Drawing.Point(107, 131);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(166, 34);
            this.lblCategorias.Symbol = "";
            this.lblCategorias.TabIndex = 46;
            this.lblCategorias.Text = " Categorias";
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(687, 425);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(38, 33);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 53;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnCategoriasEditar);
            this.Controls.Add(this.btnCategoriasRemover);
            this.Controls.Add(this.btnCategoriasInserir);
            this.Controls.Add(this.lblCategoriasNome);
            this.Controls.Add(this.txtCategoriasNome);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.lblGestaoDasCategorias);
            this.Controls.Add(this.lblVersao);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.LabelX lblGestaoDasCategorias;
        private DevComponents.DotNetBar.ButtonX btnCategoriasEditar;
        private DevComponents.DotNetBar.ButtonX btnCategoriasRemover;
        private DevComponents.DotNetBar.ButtonX btnCategoriasInserir;
        private DevComponents.DotNetBar.LabelX lblCategoriasNome;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCategoriasNome;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCategorias;
        private DevComponents.DotNetBar.LabelX lblCategorias;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
    }
}
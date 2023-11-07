namespace Emprestimo_V01
{
    partial class frmItens
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
            this.btnItensEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnItensRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnItensInserir = new DevComponents.DotNetBar.ButtonX();
            this.cmbItensCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblItensCategoria = new DevComponents.DotNetBar.LabelX();
            this.lblItensQuantidade = new DevComponents.DotNetBar.LabelX();
            this.lblNomeItens = new DevComponents.DotNetBar.LabelX();
            this.txtItensNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblItens = new DevComponents.DotNetBar.LabelX();
            this.dgvItens = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.lblGestaoDosItens = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            this.nudItensQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItensQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItensEditar
            // 
            this.btnItensEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnItensEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnItensEditar.Location = new System.Drawing.Point(367, 82);
            this.btnItensEditar.Name = "btnItensEditar";
            this.btnItensEditar.Size = new System.Drawing.Size(104, 35);
            this.btnItensEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnItensEditar.Symbol = "";
            this.btnItensEditar.SymbolSize = 15F;
            this.btnItensEditar.TabIndex = 26;
            this.btnItensEditar.Text = " Editar";
            this.btnItensEditar.TextColor = System.Drawing.Color.White;
            this.btnItensEditar.Click += new System.EventHandler(this.btnItensEditar_Click);
            // 
            // btnItensRemover
            // 
            this.btnItensRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnItensRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnItensRemover.Location = new System.Drawing.Point(477, 82);
            this.btnItensRemover.Name = "btnItensRemover";
            this.btnItensRemover.Size = new System.Drawing.Size(141, 35);
            this.btnItensRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnItensRemover.Symbol = "";
            this.btnItensRemover.SymbolSize = 15F;
            this.btnItensRemover.TabIndex = 25;
            this.btnItensRemover.Text = " Remover";
            this.btnItensRemover.TextColor = System.Drawing.Color.White;
            this.btnItensRemover.Click += new System.EventHandler(this.btnItensRemover_Click);
            // 
            // btnItensInserir
            // 
            this.btnItensInserir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnItensInserir.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnItensInserir.Location = new System.Drawing.Point(240, 82);
            this.btnItensInserir.Name = "btnItensInserir";
            this.btnItensInserir.Size = new System.Drawing.Size(121, 35);
            this.btnItensInserir.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnItensInserir.Symbol = "";
            this.btnItensInserir.SymbolSize = 15F;
            this.btnItensInserir.TabIndex = 24;
            this.btnItensInserir.Text = " Inserir";
            this.btnItensInserir.TextColor = System.Drawing.Color.White;
            this.btnItensInserir.Click += new System.EventHandler(this.btnItensInserir_Click);
            // 
            // cmbItensCategoria
            // 
            this.cmbItensCategoria.DisplayMember = "Text";
            this.cmbItensCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItensCategoria.FormattingEnabled = true;
            this.cmbItensCategoria.ItemHeight = 29;
            this.cmbItensCategoria.Location = new System.Drawing.Point(255, 370);
            this.cmbItensCategoria.Name = "cmbItensCategoria";
            this.cmbItensCategoria.Size = new System.Drawing.Size(363, 35);
            this.cmbItensCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbItensCategoria.TabIndex = 23;
            this.cmbItensCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbItensCategoria_SelectedIndexChanged);
            // 
            // lblItensCategoria
            // 
            // 
            // 
            // 
            this.lblItensCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblItensCategoria.ForeColor = System.Drawing.Color.White;
            this.lblItensCategoria.Location = new System.Drawing.Point(107, 370);
            this.lblItensCategoria.Name = "lblItensCategoria";
            this.lblItensCategoria.Size = new System.Drawing.Size(131, 35);
            this.lblItensCategoria.Symbol = "";
            this.lblItensCategoria.SymbolSize = 13F;
            this.lblItensCategoria.TabIndex = 22;
            this.lblItensCategoria.Text = " Categoria";
            // 
            // lblItensQuantidade
            // 
            // 
            // 
            // 
            this.lblItensQuantidade.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblItensQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblItensQuantidade.Location = new System.Drawing.Point(107, 324);
            this.lblItensQuantidade.Name = "lblItensQuantidade";
            this.lblItensQuantidade.Size = new System.Drawing.Size(155, 34);
            this.lblItensQuantidade.Symbol = "";
            this.lblItensQuantidade.SymbolSize = 13F;
            this.lblItensQuantidade.TabIndex = 21;
            this.lblItensQuantidade.Text = " Quantidade";
            // 
            // lblNomeItens
            // 
            // 
            // 
            // 
            this.lblNomeItens.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomeItens.ForeColor = System.Drawing.Color.White;
            this.lblNomeItens.Location = new System.Drawing.Point(107, 278);
            this.lblNomeItens.Name = "lblNomeItens";
            this.lblNomeItens.Size = new System.Drawing.Size(92, 34);
            this.lblNomeItens.Symbol = "";
            this.lblNomeItens.SymbolSize = 13F;
            this.lblNomeItens.TabIndex = 19;
            this.lblNomeItens.Text = " Nome";
            // 
            // txtItensNome
            // 
            // 
            // 
            // 
            this.txtItensNome.Border.Class = "TextBoxBorder";
            this.txtItensNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtItensNome.Location = new System.Drawing.Point(205, 278);
            this.txtItensNome.Name = "txtItensNome";
            this.txtItensNome.PreventEnterBeep = true;
            this.txtItensNome.Size = new System.Drawing.Size(413, 34);
            this.txtItensNome.TabIndex = 18;
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            // 
            // 
            // 
            this.lblItens.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblItens.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.ForeColor = System.Drawing.Color.White;
            this.lblItens.Location = new System.Drawing.Point(107, 82);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(99, 34);
            this.lblItens.Symbol = "";
            this.lblItens.TabIndex = 17;
            this.lblItens.Text = " Itens";
            // 
            // dgvItens
            // 
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvItens.Location = new System.Drawing.Point(107, 122);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(511, 150);
            this.dgvItens.TabIndex = 16;
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
            this.lblVersao.TabIndex = 27;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblGestaoDosItens
            // 
            // 
            // 
            // 
            this.lblGestaoDosItens.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDosItens.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDosItens.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDosItens.Location = new System.Drawing.Point(244, 16);
            this.lblGestaoDosItens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDosItens.Name = "lblGestaoDosItens";
            this.lblGestaoDosItens.Size = new System.Drawing.Size(236, 45);
            this.lblGestaoDosItens.Symbol = "";
            this.lblGestaoDosItens.TabIndex = 28;
            this.lblGestaoDosItens.Text = " Gestão dos Itens";
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(685, 425);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(40, 32);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 29;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // nudItensQuantidade
            // 
            this.nudItensQuantidade.Location = new System.Drawing.Point(287, 324);
            this.nudItensQuantidade.Name = "nudItensQuantidade";
            this.nudItensQuantidade.Size = new System.Drawing.Size(98, 34);
            this.nudItensQuantidade.TabIndex = 30;
            // 
            // frmItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(725, 458);
            this.Controls.Add(this.nudItensQuantidade);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.lblGestaoDosItens);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnItensEditar);
            this.Controls.Add(this.btnItensRemover);
            this.Controls.Add(this.btnItensInserir);
            this.Controls.Add(this.cmbItensCategoria);
            this.Controls.Add(this.lblItensCategoria);
            this.Controls.Add(this.lblItensQuantidade);
            this.Controls.Add(this.lblNomeItens);
            this.Controls.Add(this.txtItensNome);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.dgvItens);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItens";
            this.Load += new System.EventHandler(this.frmItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItensQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnItensEditar;
        private DevComponents.DotNetBar.ButtonX btnItensRemover;
        private DevComponents.DotNetBar.ButtonX btnItensInserir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbItensCategoria;
        private DevComponents.DotNetBar.LabelX lblItensCategoria;
        private DevComponents.DotNetBar.LabelX lblItensQuantidade;
        private DevComponents.DotNetBar.LabelX lblNomeItens;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItensNome;
        private DevComponents.DotNetBar.LabelX lblItens;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvItens;
        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.LabelX lblGestaoDosItens;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
        private System.Windows.Forms.NumericUpDown nudItensQuantidade;

    }
}
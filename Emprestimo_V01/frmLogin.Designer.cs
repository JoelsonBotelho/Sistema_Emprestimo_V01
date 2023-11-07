namespace Emprestimo_V01
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLogin = new DevComponents.DotNetBar.LabelX();
            this.txtNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnEntrar = new DevComponents.DotNetBar.ButtonX();
            this.btnInfo = new DevComponents.DotNetBar.ButtonX();
            this.btnSair = new DevComponents.DotNetBar.ButtonX();
            this.lblNome = new DevComponents.DotNetBar.LabelX();
            this.lblSenha = new DevComponents.DotNetBar.LabelX();
            this.lblVersao = new DevComponents.DotNetBar.LabelX();
            this.tmrNome = new System.Windows.Forms.Timer(this.components);
            this.tmrSenha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            // 
            // 
            // 
            this.lblLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(140, 15);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(128, 98);
            this.lblLogin.Symbol = "";
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = " LOGIN";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.Border.Class = "TextBoxBorder";
            this.txtNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNome.Location = new System.Drawing.Point(12, 213);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.PreventEnterBeep = true;
            this.txtNome.Size = new System.Drawing.Size(362, 34);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(12, 165);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(120, 43);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 15F;
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = " Nome:";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Location = new System.Drawing.Point(12, 303);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(362, 34);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(12, 253);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(120, 43);
            this.labelX3.Symbol = "";
            this.labelX3.SymbolSize = 15F;
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = " Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.btnEntrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(278, 345);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(120, 53);
            this.btnEntrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnEntrar.Symbol = "";
            this.btnEntrar.SymbolSize = 15F;
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = " Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.White;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Location = new System.Drawing.Point(-1, 1);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 33);
            this.btnInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnInfo.Symbol = "";
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TextColor = System.Drawing.Color.White;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSair
            // 
            this.btnSair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSair.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(354, 1);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 33);
            this.btnSair.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnSair.Symbol = "";
            this.btnSair.TabIndex = 7;
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Lime;
            // 
            // 
            // 
            this.lblNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(376, 213);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(20, 34);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "√";
            this.lblNome.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.Lime;
            // 
            // 
            // 
            this.lblSenha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(376, 303);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(20, 34);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "√";
            this.lblSenha.Visible = false;
            // 
            // lblVersao
            // 
            // 
            // 
            // 
            this.lblVersao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblVersao.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(7, 373);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(120, 23);
            this.lblVersao.TabIndex = 10;
            this.lblVersao.Text = "© Emprestimo V01";
            // 
            // tmrNome
            // 
            this.tmrNome.Tick += new System.EventHandler(this.tmrNome_Tick);
            // 
            // tmrSenha
            // 
            this.tmrSenha.Tick += new System.EventHandler(this.tmrSenha_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.labelX2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNome;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnEntrar;
        private DevComponents.DotNetBar.ButtonX btnInfo;
        private DevComponents.DotNetBar.ButtonX btnSair;
        private DevComponents.DotNetBar.LabelX lblNome;
        private DevComponents.DotNetBar.LabelX lblSenha;
        private DevComponents.DotNetBar.LabelX lblVersao;
        private System.Windows.Forms.Timer tmrNome;
        private System.Windows.Forms.Timer tmrSenha;
    }
}


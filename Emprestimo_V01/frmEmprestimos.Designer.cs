namespace Emprestimo_V01
{
    partial class frmEmprestimos
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
            this.lblGestaoDosEmprestimos = new DevComponents.DotNetBar.LabelX();
            this.btnEmprestarEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnEmprestarRemover = new DevComponents.DotNetBar.ButtonX();
            this.btnEmprestar = new DevComponents.DotNetBar.ButtonX();
            this.lblEmprestarDevolver = new DevComponents.DotNetBar.LabelX();
            this.lblEmprestarEmprestar = new DevComponents.DotNetBar.LabelX();
            this.cmbEmprestarNome = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblEmprestarNome = new DevComponents.DotNetBar.LabelX();
            this.cmbEmprestarAmigos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblEmprestarAmigos = new DevComponents.DotNetBar.LabelX();
            this.lblEmprestarQuantidade = new DevComponents.DotNetBar.LabelX();
            this.dgvEmprestar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblEmpretsar = new DevComponents.DotNetBar.LabelX();
            this.btnMenuInicial = new DevComponents.DotNetBar.ButtonX();
            this.nudEmprestimosQuantidade = new System.Windows.Forms.NumericUpDown();
            this.DataEmprestar = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.DataDevolver = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnDevolver = new DevComponents.DotNetBar.ButtonX();
            this.lblDevolver = new DevComponents.DotNetBar.LabelX();
            this.nudDevolver = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmprestimosQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEmprestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDevolver)).BeginInit();
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
            this.lblVersao.Location = new System.Drawing.Point(446, 485);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(210, 23);
            this.lblVersao.TabIndex = 35;
            this.lblVersao.Text = "© Emprestimo V01";
            this.lblVersao.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblGestaoDosEmprestimos
            // 
            // 
            // 
            // 
            this.lblGestaoDosEmprestimos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGestaoDosEmprestimos.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDosEmprestimos.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDosEmprestimos.Location = new System.Drawing.Point(381, 45);
            this.lblGestaoDosEmprestimos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblGestaoDosEmprestimos.Name = "lblGestaoDosEmprestimos";
            this.lblGestaoDosEmprestimos.Size = new System.Drawing.Size(340, 45);
            this.lblGestaoDosEmprestimos.Symbol = "";
            this.lblGestaoDosEmprestimos.TabIndex = 46;
            this.lblGestaoDosEmprestimos.Text = " Gestão dos Emprestimos";
            // 
            // btnEmprestarEditar
            // 
            this.btnEmprestarEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEmprestarEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnEmprestarEditar.Location = new System.Drawing.Point(273, 140);
            this.btnEmprestarEditar.Name = "btnEmprestarEditar";
            this.btnEmprestarEditar.Size = new System.Drawing.Size(151, 35);
            this.btnEmprestarEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnEmprestarEditar.Symbol = "";
            this.btnEmprestarEditar.SymbolSize = 15F;
            this.btnEmprestarEditar.TabIndex = 61;
            this.btnEmprestarEditar.Text = " Editar";
            this.btnEmprestarEditar.TextColor = System.Drawing.Color.White;
            this.btnEmprestarEditar.Click += new System.EventHandler(this.btnEmprestarEditar_Click);
            // 
            // btnEmprestarRemover
            // 
            this.btnEmprestarRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEmprestarRemover.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnEmprestarRemover.Location = new System.Drawing.Point(446, 141);
            this.btnEmprestarRemover.Name = "btnEmprestarRemover";
            this.btnEmprestarRemover.Size = new System.Drawing.Size(170, 35);
            this.btnEmprestarRemover.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnEmprestarRemover.Symbol = "";
            this.btnEmprestarRemover.SymbolSize = 15F;
            this.btnEmprestarRemover.TabIndex = 60;
            this.btnEmprestarRemover.Text = " Remover";
            this.btnEmprestarRemover.TextColor = System.Drawing.Color.White;
            this.btnEmprestarRemover.Click += new System.EventHandler(this.btnEmprestarRemover_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEmprestar.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnEmprestar.Location = new System.Drawing.Point(623, 140);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(198, 34);
            this.btnEmprestar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnEmprestar.Symbol = "";
            this.btnEmprestar.SymbolSize = 15F;
            this.btnEmprestar.TabIndex = 59;
            this.btnEmprestar.Text = " Emprestar";
            this.btnEmprestar.TextColor = System.Drawing.Color.White;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // lblEmprestarDevolver
            // 
            this.lblEmprestarDevolver.AutoSize = true;
            // 
            // 
            // 
            this.lblEmprestarDevolver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmprestarDevolver.ForeColor = System.Drawing.Color.White;
            this.lblEmprestarDevolver.Location = new System.Drawing.Point(303, 336);
            this.lblEmprestarDevolver.Name = "lblEmprestarDevolver";
            this.lblEmprestarDevolver.Size = new System.Drawing.Size(193, 30);
            this.lblEmprestarDevolver.Symbol = "";
            this.lblEmprestarDevolver.SymbolSize = 13F;
            this.lblEmprestarDevolver.TabIndex = 56;
            this.lblEmprestarDevolver.Text = " Data à Devolver";
            // 
            // lblEmprestarEmprestar
            // 
            this.lblEmprestarEmprestar.AutoSize = true;
            // 
            // 
            // 
            this.lblEmprestarEmprestar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmprestarEmprestar.ForeColor = System.Drawing.Color.White;
            this.lblEmprestarEmprestar.Location = new System.Drawing.Point(76, 336);
            this.lblEmprestarEmprestar.Name = "lblEmprestarEmprestar";
            this.lblEmprestarEmprestar.Size = new System.Drawing.Size(211, 30);
            this.lblEmprestarEmprestar.Symbol = "";
            this.lblEmprestarEmprestar.SymbolSize = 13F;
            this.lblEmprestarEmprestar.TabIndex = 55;
            this.lblEmprestarEmprestar.Text = " Data à Emprestar";
            // 
            // cmbEmprestarNome
            // 
            this.cmbEmprestarNome.DisplayMember = "Text";
            this.cmbEmprestarNome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmprestarNome.FormattingEnabled = true;
            this.cmbEmprestarNome.ItemHeight = 29;
            this.cmbEmprestarNome.Location = new System.Drawing.Point(697, 216);
            this.cmbEmprestarNome.Name = "cmbEmprestarNome";
            this.cmbEmprestarNome.Size = new System.Drawing.Size(329, 35);
            this.cmbEmprestarNome.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEmprestarNome.TabIndex = 53;
            this.cmbEmprestarNome.SelectedIndexChanged += new System.EventHandler(this.cmbEmprestarNome_SelectedIndexChanged);
            // 
            // lblEmprestarNome
            // 
            this.lblEmprestarNome.AutoSize = true;
            // 
            // 
            // 
            this.lblEmprestarNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmprestarNome.ForeColor = System.Drawing.Color.White;
            this.lblEmprestarNome.Location = new System.Drawing.Point(696, 184);
            this.lblEmprestarNome.Name = "lblEmprestarNome";
            this.lblEmprestarNome.Size = new System.Drawing.Size(92, 30);
            this.lblEmprestarNome.Symbol = "";
            this.lblEmprestarNome.SymbolSize = 13F;
            this.lblEmprestarNome.TabIndex = 52;
            this.lblEmprestarNome.Text = " Nome";
            // 
            // cmbEmprestarAmigos
            // 
            this.cmbEmprestarAmigos.DisplayMember = "Text";
            this.cmbEmprestarAmigos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmprestarAmigos.FormattingEnabled = true;
            this.cmbEmprestarAmigos.ItemHeight = 29;
            this.cmbEmprestarAmigos.Location = new System.Drawing.Point(695, 285);
            this.cmbEmprestarAmigos.Name = "cmbEmprestarAmigos";
            this.cmbEmprestarAmigos.Size = new System.Drawing.Size(329, 35);
            this.cmbEmprestarAmigos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbEmprestarAmigos.TabIndex = 51;
            this.cmbEmprestarAmigos.SelectedIndexChanged += new System.EventHandler(this.cmbEmprestarAmigos_SelectedIndexChanged);
            // 
            // lblEmprestarAmigos
            // 
            this.lblEmprestarAmigos.AutoSize = true;
            // 
            // 
            // 
            this.lblEmprestarAmigos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmprestarAmigos.ForeColor = System.Drawing.Color.White;
            this.lblEmprestarAmigos.Location = new System.Drawing.Point(694, 253);
            this.lblEmprestarAmigos.Name = "lblEmprestarAmigos";
            this.lblEmprestarAmigos.Size = new System.Drawing.Size(108, 30);
            this.lblEmprestarAmigos.Symbol = "";
            this.lblEmprestarAmigos.SymbolSize = 13F;
            this.lblEmprestarAmigos.TabIndex = 50;
            this.lblEmprestarAmigos.Text = " Amigos";
            // 
            // lblEmprestarQuantidade
            // 
            // 
            // 
            // 
            this.lblEmprestarQuantidade.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmprestarQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblEmprestarQuantidade.Location = new System.Drawing.Point(514, 337);
            this.lblEmprestarQuantidade.Name = "lblEmprestarQuantidade";
            this.lblEmprestarQuantidade.Size = new System.Drawing.Size(274, 30);
            this.lblEmprestarQuantidade.Symbol = "";
            this.lblEmprestarQuantidade.SymbolSize = 13F;
            this.lblEmprestarQuantidade.TabIndex = 49;
            this.lblEmprestarQuantidade.Text = " Quantidade Emprestar";
            // 
            // dgvEmprestar
            // 
            this.dgvEmprestar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmprestar.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmprestar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmprestar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEmprestar.Location = new System.Drawing.Point(76, 180);
            this.dgvEmprestar.Name = "dgvEmprestar";
            this.dgvEmprestar.RowTemplate.Height = 24;
            this.dgvEmprestar.Size = new System.Drawing.Size(612, 150);
            this.dgvEmprestar.TabIndex = 48;
            // 
            // lblEmpretsar
            // 
            this.lblEmpretsar.AutoSize = true;
            // 
            // 
            // 
            this.lblEmpretsar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmpretsar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpretsar.ForeColor = System.Drawing.Color.White;
            this.lblEmpretsar.Location = new System.Drawing.Point(76, 140);
            this.lblEmpretsar.Name = "lblEmpretsar";
            this.lblEmpretsar.Size = new System.Drawing.Size(166, 34);
            this.lblEmpretsar.Symbol = "";
            this.lblEmpretsar.TabIndex = 47;
            this.lblEmpretsar.Text = " Emprestar";
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMenuInicial.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMenuInicial.Location = new System.Drawing.Point(1056, 474);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(45, 35);
            this.btnMenuInicial.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnMenuInicial.Symbol = "";
            this.btnMenuInicial.SymbolSize = 15F;
            this.btnMenuInicial.TabIndex = 62;
            this.btnMenuInicial.TextColor = System.Drawing.Color.White;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // nudEmprestimosQuantidade
            // 
            this.nudEmprestimosQuantidade.Location = new System.Drawing.Point(514, 373);
            this.nudEmprestimosQuantidade.Name = "nudEmprestimosQuantidade";
            this.nudEmprestimosQuantidade.Size = new System.Drawing.Size(151, 34);
            this.nudEmprestimosQuantidade.TabIndex = 63;
            // 
            // DataEmprestar
            // 
            // 
            // 
            // 
            this.DataEmprestar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DataEmprestar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataEmprestar.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DataEmprestar.ButtonDropDown.Visible = true;
            this.DataEmprestar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataEmprestar.IsPopupCalendarOpen = false;
            this.DataEmprestar.Location = new System.Drawing.Point(76, 373);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DataEmprestar.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataEmprestar.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DataEmprestar.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DataEmprestar.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataEmprestar.MonthCalendar.DisplayMonth = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DataEmprestar.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DataEmprestar.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DataEmprestar.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DataEmprestar.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataEmprestar.MonthCalendar.TodayButtonVisible = true;
            this.DataEmprestar.Name = "DataEmprestar";
            this.DataEmprestar.Size = new System.Drawing.Size(211, 34);
            this.DataEmprestar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DataEmprestar.TabIndex = 64;
            this.DataEmprestar.WatermarkColor = System.Drawing.SystemColors.Desktop;
            // 
            // DataDevolver
            // 
            // 
            // 
            // 
            this.DataDevolver.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DataDevolver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataDevolver.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DataDevolver.ButtonDropDown.Visible = true;
            this.DataDevolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataDevolver.IsPopupCalendarOpen = false;
            this.DataDevolver.Location = new System.Drawing.Point(303, 373);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DataDevolver.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataDevolver.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DataDevolver.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DataDevolver.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataDevolver.MonthCalendar.DisplayMonth = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DataDevolver.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DataDevolver.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DataDevolver.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DataDevolver.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataDevolver.MonthCalendar.TodayButtonVisible = true;
            this.DataDevolver.Name = "DataDevolver";
            this.DataDevolver.Size = new System.Drawing.Size(193, 34);
            this.DataDevolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DataDevolver.TabIndex = 70;
            this.DataDevolver.WatermarkColor = System.Drawing.SystemColors.Desktop;
            // 
            // btnDevolver
            // 
            this.btnDevolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDevolver.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDevolver.Location = new System.Drawing.Point(840, 141);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(184, 34);
            this.btnDevolver.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnDevolver.Symbol = "";
            this.btnDevolver.SymbolSize = 15F;
            this.btnDevolver.TabIndex = 71;
            this.btnDevolver.Text = " Devolver";
            this.btnDevolver.TextColor = System.Drawing.Color.White;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblDevolver
            // 
            // 
            // 
            // 
            this.lblDevolver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDevolver.ForeColor = System.Drawing.Color.White;
            this.lblDevolver.Location = new System.Drawing.Point(794, 337);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(251, 30);
            this.lblDevolver.Symbol = "";
            this.lblDevolver.SymbolSize = 13F;
            this.lblDevolver.TabIndex = 72;
            this.lblDevolver.Text = " Quantidade Devolver";
            // 
            // nudDevolver
            // 
            this.nudDevolver.Location = new System.Drawing.Point(794, 373);
            this.nudDevolver.Name = "nudDevolver";
            this.nudDevolver.Size = new System.Drawing.Size(151, 34);
            this.nudDevolver.TabIndex = 73;
            // 
            // frmEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1103, 511);
            this.Controls.Add(this.nudDevolver);
            this.Controls.Add(this.lblDevolver);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.DataDevolver);
            this.Controls.Add(this.DataEmprestar);
            this.Controls.Add(this.nudEmprestimosQuantidade);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnEmprestarEditar);
            this.Controls.Add(this.btnEmprestarRemover);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.lblEmprestarDevolver);
            this.Controls.Add(this.lblEmprestarEmprestar);
            this.Controls.Add(this.cmbEmprestarNome);
            this.Controls.Add(this.lblEmprestarNome);
            this.Controls.Add(this.cmbEmprestarAmigos);
            this.Controls.Add(this.lblEmprestarAmigos);
            this.Controls.Add(this.lblEmprestarQuantidade);
            this.Controls.Add(this.dgvEmprestar);
            this.Controls.Add(this.lblEmpretsar);
            this.Controls.Add(this.lblGestaoDosEmprestimos);
            this.Controls.Add(this.lblVersao);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmprestimos";
            this.Load += new System.EventHandler(this.frmEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmprestimosQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEmprestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblVersao;
        private DevComponents.DotNetBar.LabelX lblGestaoDosEmprestimos;
        private DevComponents.DotNetBar.ButtonX btnEmprestarEditar;
        private DevComponents.DotNetBar.ButtonX btnEmprestarRemover;
        private DevComponents.DotNetBar.ButtonX btnEmprestar;
        private DevComponents.DotNetBar.LabelX lblEmprestarDevolver;
        private DevComponents.DotNetBar.LabelX lblEmprestarEmprestar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEmprestarNome;
        private DevComponents.DotNetBar.LabelX lblEmprestarNome;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbEmprestarAmigos;
        private DevComponents.DotNetBar.LabelX lblEmprestarAmigos;
        private DevComponents.DotNetBar.LabelX lblEmprestarQuantidade;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvEmprestar;
        private DevComponents.DotNetBar.LabelX lblEmpretsar;
        private DevComponents.DotNetBar.ButtonX btnMenuInicial;
        private System.Windows.Forms.NumericUpDown nudEmprestimosQuantidade;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DataEmprestar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DataDevolver;
        private DevComponents.DotNetBar.ButtonX btnDevolver;
        private DevComponents.DotNetBar.LabelX lblDevolver;
        private System.Windows.Forms.NumericUpDown nudDevolver;
    }
}
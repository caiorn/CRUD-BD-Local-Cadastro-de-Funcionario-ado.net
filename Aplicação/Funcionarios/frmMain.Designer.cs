namespace Funcionarios
{
    partial class frmMain
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1ColumnView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.esconderColunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNascToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAdmissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeDaFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.chkAtivos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkSemDatasAdmissao = new System.Windows.Forms.CheckBox();
            this.dtpDataAdmissaoMax = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkComDatasAdmissao = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAtivaFiltroSalario = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioMax = new System.Windows.Forms.TextBox();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.chkFeminino = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            this.btnAlterarFunc = new System.Windows.Forms.Button();
            this.chkFiltroAvançado = new System.Windows.Forms.CheckBox();
            this.btnConsultarFunc = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.lblQtdRegistrosExibidos = new System.Windows.Forms.Label();
            this.lblTotalCadastrados = new System.Windows.Forms.Label();
            this.dtpDataAdmissaoMin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.contextMenuStrip1ColumnView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnDataNasc,
            this.ColumnSexo,
            this.ColumnCelular,
            this.ColumnEmail,
            this.ColumnDataAdmissao,
            this.ColumnDepartamento,
            this.ColumnSalario,
            this.ColumnFoto,
            this.ColumnAtivo});
            this.dgvFuncionarios.ContextMenuStrip = this.contextMenuStrip1ColumnView;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFuncionarios.Location = new System.Drawing.Point(-4, 138);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(660, 308);
            this.dgvFuncionarios.TabIndex = 32;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "Id_F";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 30;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 148;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnCPF.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            this.ColumnCPF.Width = 90;
            // 
            // ColumnDataNasc
            // 
            this.ColumnDataNasc.DataPropertyName = "DataNascimento";
            this.ColumnDataNasc.HeaderText = "Data Nasc";
            this.ColumnDataNasc.Name = "ColumnDataNasc";
            this.ColumnDataNasc.ReadOnly = true;
            this.ColumnDataNasc.Visible = false;
            this.ColumnDataNasc.Width = 90;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnSexo.DataPropertyName = "Sexo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSexo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Width = 56;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.DataPropertyName = "Celular";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnCelular.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCelular.HeaderText = "Celular";
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            this.ColumnCelular.Visible = false;
            this.ColumnCelular.Width = 80;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "Email";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Visible = false;
            this.ColumnEmail.Width = 130;
            // 
            // ColumnDataAdmissao
            // 
            this.ColumnDataAdmissao.DataPropertyName = "DataAdmissao";
            this.ColumnDataAdmissao.HeaderText = "Data Admissão";
            this.ColumnDataAdmissao.Name = "ColumnDataAdmissao";
            this.ColumnDataAdmissao.ReadOnly = true;
            this.ColumnDataAdmissao.Width = 105;
            // 
            // ColumnDepartamento
            // 
            this.ColumnDepartamento.DataPropertyName = "Nome Departamento";
            this.ColumnDepartamento.HeaderText = "Departamento";
            this.ColumnDepartamento.Name = "ColumnDepartamento";
            this.ColumnDepartamento.ReadOnly = true;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.DataPropertyName = "Salario";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ColumnSalario.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnSalario.HeaderText = "Salario";
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.ReadOnly = true;
            this.ColumnSalario.Width = 80;
            // 
            // ColumnFoto
            // 
            this.ColumnFoto.DataPropertyName = "Foto";
            this.ColumnFoto.HeaderText = "Nome Foto";
            this.ColumnFoto.Name = "ColumnFoto";
            this.ColumnFoto.ReadOnly = true;
            this.ColumnFoto.Visible = false;
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAtivo.DataPropertyName = "Ativo";
            this.ColumnAtivo.HeaderText = "Ativo?";
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.ReadOnly = true;
            this.ColumnAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAtivo.Width = 62;
            // 
            // contextMenuStrip1ColumnView
            // 
            this.contextMenuStrip1ColumnView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esconderColunasToolStripMenuItem});
            this.contextMenuStrip1ColumnView.Name = "contextMenuStrip1ColumnView";
            this.contextMenuStrip1ColumnView.Size = new System.Drawing.Size(149, 26);
            // 
            // esconderColunasToolStripMenuItem
            // 
            this.esconderColunasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.nomeToolStripMenuItem,
            this.cPFToolStripMenuItem,
            this.dataNascToolStripMenuItem,
            this.sexoToolStripMenuItem,
            this.celularToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.dataAdmissãoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.salárioToolStripMenuItem,
            this.ativoToolStripMenuItem,
            this.nomeDaFotoToolStripMenuItem});
            this.esconderColunasToolStripMenuItem.Name = "esconderColunasToolStripMenuItem";
            this.esconderColunasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.esconderColunasToolStripMenuItem.Text = "Exibir Colunas";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Checked = true;
            this.iDToolStripMenuItem.CheckOnClick = true;
            this.iDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.iDToolStripMenuItem.Tag = "ColumnID";
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Checked = true;
            this.nomeToolStripMenuItem.CheckOnClick = true;
            this.nomeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nomeToolStripMenuItem.Tag = "ColumnNome";
            this.nomeToolStripMenuItem.Text = "Nome";
            this.nomeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // cPFToolStripMenuItem
            // 
            this.cPFToolStripMenuItem.Checked = true;
            this.cPFToolStripMenuItem.CheckOnClick = true;
            this.cPFToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cPFToolStripMenuItem.Name = "cPFToolStripMenuItem";
            this.cPFToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cPFToolStripMenuItem.Tag = "ColumnCPF";
            this.cPFToolStripMenuItem.Text = "CPF";
            this.cPFToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // dataNascToolStripMenuItem
            // 
            this.dataNascToolStripMenuItem.CheckOnClick = true;
            this.dataNascToolStripMenuItem.Name = "dataNascToolStripMenuItem";
            this.dataNascToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dataNascToolStripMenuItem.Tag = "ColumnDataNasc";
            this.dataNascToolStripMenuItem.Text = "Data Nasc";
            this.dataNascToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.Checked = true;
            this.sexoToolStripMenuItem.CheckOnClick = true;
            this.sexoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sexoToolStripMenuItem.Tag = "ColumnSexo";
            this.sexoToolStripMenuItem.Text = "Sexo";
            this.sexoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // celularToolStripMenuItem
            // 
            this.celularToolStripMenuItem.CheckOnClick = true;
            this.celularToolStripMenuItem.Name = "celularToolStripMenuItem";
            this.celularToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.celularToolStripMenuItem.Tag = "ColumnCelular";
            this.celularToolStripMenuItem.Text = "Celular";
            this.celularToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.CheckOnClick = true;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.emailToolStripMenuItem.Tag = "ColumnEmail";
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // dataAdmissãoToolStripMenuItem
            // 
            this.dataAdmissãoToolStripMenuItem.Checked = true;
            this.dataAdmissãoToolStripMenuItem.CheckOnClick = true;
            this.dataAdmissãoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataAdmissãoToolStripMenuItem.Name = "dataAdmissãoToolStripMenuItem";
            this.dataAdmissãoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dataAdmissãoToolStripMenuItem.Tag = "ColumnDataAdmissao";
            this.dataAdmissãoToolStripMenuItem.Text = "Data Admissão";
            this.dataAdmissãoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Checked = true;
            this.departamentoToolStripMenuItem.CheckOnClick = true;
            this.departamentoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.departamentoToolStripMenuItem.Tag = "ColumnDepartamento";
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // salárioToolStripMenuItem
            // 
            this.salárioToolStripMenuItem.Checked = true;
            this.salárioToolStripMenuItem.CheckOnClick = true;
            this.salárioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.salárioToolStripMenuItem.Name = "salárioToolStripMenuItem";
            this.salárioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salárioToolStripMenuItem.Tag = "ColumnSalario";
            this.salárioToolStripMenuItem.Text = "Salário";
            this.salárioToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // ativoToolStripMenuItem
            // 
            this.ativoToolStripMenuItem.Checked = true;
            this.ativoToolStripMenuItem.CheckOnClick = true;
            this.ativoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoToolStripMenuItem.Name = "ativoToolStripMenuItem";
            this.ativoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ativoToolStripMenuItem.Tag = "ColumnAtivo";
            this.ativoToolStripMenuItem.Text = "Ativo";
            this.ativoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // nomeDaFotoToolStripMenuItem
            // 
            this.nomeDaFotoToolStripMenuItem.CheckOnClick = true;
            this.nomeDaFotoToolStripMenuItem.Name = "nomeDaFotoToolStripMenuItem";
            this.nomeDaFotoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nomeDaFotoToolStripMenuItem.Tag = "ColumnFoto";
            this.nomeDaFotoToolStripMenuItem.Text = "Nome da Foto";
            this.nomeDaFotoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 42);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(170, 22);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFunc.Location = new System.Drawing.Point(12, 476);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(129, 32);
            this.btnNovoFunc.TabIndex = 36;
            this.btnNovoFunc.Tag = "Novo";
            this.btnNovoFunc.Text = "Novo Funcionario";
            this.btnNovoFunc.UseVisualStyleBackColor = true;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnsNovoAlterarConsultarFunc_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(549, 476);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 32);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(9, 23);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(177, 16);
            this.lblPesquisa.TabIndex = 37;
            this.lblPesquisa.Text = "Pesquisar por Nome/Id/CPF";
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Checked = true;
            this.chkInativos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInativos.Location = new System.Drawing.Point(9, 24);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(63, 17);
            this.chkInativos.TabIndex = 38;
            this.chkInativos.Text = "Inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            // 
            // chkAtivos
            // 
            this.chkAtivos.AutoSize = true;
            this.chkAtivos.Checked = true;
            this.chkAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivos.Location = new System.Drawing.Point(9, 42);
            this.chkAtivos.Name = "chkAtivos";
            this.chkAtivos.Size = new System.Drawing.Size(55, 17);
            this.chkAtivos.TabIndex = 39;
            this.chkAtivos.Text = "Ativos";
            this.chkAtivos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboDepartamentos);
            this.groupBox1.Controls.Add(this.chkInativos);
            this.groupBox1.Controls.Add(this.chkAtivos);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 120);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpDataAdmissaoMin);
            this.groupBox4.Controls.Add(this.chkSemDatasAdmissao);
            this.groupBox4.Controls.Add(this.dtpDataAdmissaoMax);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.chkComDatasAdmissao);
            this.groupBox4.Location = new System.Drawing.Point(323, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 103);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data de Admissão";
            // 
            // chkSemDatasAdmissao
            // 
            this.chkSemDatasAdmissao.AutoSize = true;
            this.chkSemDatasAdmissao.Checked = true;
            this.chkSemDatasAdmissao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSemDatasAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSemDatasAdmissao.Location = new System.Drawing.Point(6, 78);
            this.chkSemDatasAdmissao.Name = "chkSemDatasAdmissao";
            this.chkSemDatasAdmissao.Size = new System.Drawing.Size(94, 19);
            this.chkSemDatasAdmissao.TabIndex = 46;
            this.chkSemDatasAdmissao.Text = "Sem datas";
            this.chkSemDatasAdmissao.UseVisualStyleBackColor = true;
            // 
            // dtpDataAdmissaoMax
            // 
            this.dtpDataAdmissaoMax.Enabled = false;
            this.dtpDataAdmissaoMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissaoMax.Location = new System.Drawing.Point(34, 56);
            this.dtpDataAdmissaoMax.Name = "dtpDataAdmissaoMax";
            this.dtpDataAdmissaoMax.Size = new System.Drawing.Size(99, 20);
            this.dtpDataAdmissaoMax.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Até:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "De:";
            // 
            // chkComDatasAdmissao
            // 
            this.chkComDatasAdmissao.AutoSize = true;
            this.chkComDatasAdmissao.Checked = true;
            this.chkComDatasAdmissao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComDatasAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComDatasAdmissao.Location = new System.Drawing.Point(7, 14);
            this.chkComDatasAdmissao.Name = "chkComDatasAdmissao";
            this.chkComDatasAdmissao.Size = new System.Drawing.Size(96, 19);
            this.chkComDatasAdmissao.TabIndex = 44;
            this.chkComDatasAdmissao.Text = "Com Datas";
            this.chkComDatasAdmissao.UseVisualStyleBackColor = true;
            this.chkComDatasAdmissao.CheckedChanged += new System.EventHandler(this.chksDataAdimissaoESalario_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAtivaFiltroSalario);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSalarioMax);
            this.groupBox3.Controls.Add(this.txtSalarioMin);
            this.groupBox3.Location = new System.Drawing.Point(182, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 66);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salário";
            // 
            // chkAtivaFiltroSalario
            // 
            this.chkAtivaFiltroSalario.AutoSize = true;
            this.chkAtivaFiltroSalario.Location = new System.Drawing.Point(45, 0);
            this.chkAtivaFiltroSalario.Name = "chkAtivaFiltroSalario";
            this.chkAtivaFiltroSalario.Size = new System.Drawing.Size(15, 14);
            this.chkAtivaFiltroSalario.TabIndex = 44;
            this.chkAtivaFiltroSalario.UseVisualStyleBackColor = true;
            this.chkAtivaFiltroSalario.CheckedChanged += new System.EventHandler(this.chksDataAdimissaoESalario_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "De:";
            // 
            // txtSalarioMax
            // 
            this.txtSalarioMax.Enabled = false;
            this.txtSalarioMax.Location = new System.Drawing.Point(36, 40);
            this.txtSalarioMax.Name = "txtSalarioMax";
            this.txtSalarioMax.Size = new System.Drawing.Size(85, 20);
            this.txtSalarioMax.TabIndex = 3;
            this.txtSalarioMax.TextChanged += new System.EventHandler(this.txtSalarioMinMax_TextChanged);
            this.txtSalarioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMinMax_KeyPress);
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Enabled = false;
            this.txtSalarioMin.Location = new System.Drawing.Point(36, 19);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(85, 20);
            this.txtSalarioMin.TabIndex = 2;
            this.txtSalarioMin.TextChanged += new System.EventHandler(this.txtSalarioMinMax_TextChanged);
            this.txtSalarioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMinMax_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMasculino);
            this.groupBox2.Controls.Add(this.chkFeminino);
            this.groupBox2.Location = new System.Drawing.Point(78, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 54);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Checked = true;
            this.chkMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMasculino.Location = new System.Drawing.Point(6, 31);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(74, 17);
            this.chkMasculino.TabIndex = 40;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Checked = true;
            this.chkFeminino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFeminino.Location = new System.Drawing.Point(6, 14);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(68, 17);
            this.chkFeminino.TabIndex = 39;
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Departamento:";
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(6, 90);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(162, 21);
            this.cboDepartamentos.TabIndex = 40;
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFunc.Location = new System.Drawing.Point(148, 476);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.Size = new System.Drawing.Size(129, 32);
            this.btnAlterarFunc.TabIndex = 41;
            this.btnAlterarFunc.Tag = "Alterar";
            this.btnAlterarFunc.Text = "Alterar Funcionario";
            this.btnAlterarFunc.UseVisualStyleBackColor = true;
            this.btnAlterarFunc.Click += new System.EventHandler(this.btnsNovoAlterarConsultarFunc_Click);
            // 
            // chkFiltroAvançado
            // 
            this.chkFiltroAvançado.AutoSize = true;
            this.chkFiltroAvançado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFiltroAvançado.Location = new System.Drawing.Point(12, 71);
            this.chkFiltroAvançado.Name = "chkFiltroAvançado";
            this.chkFiltroAvançado.Size = new System.Drawing.Size(121, 20);
            this.chkFiltroAvançado.TabIndex = 42;
            this.chkFiltroAvançado.Text = "Filtro Avançado";
            this.chkFiltroAvançado.UseVisualStyleBackColor = true;
            this.chkFiltroAvançado.CheckedChanged += new System.EventHandler(this.chkFiltroAvançado_CheckedChanged);
            // 
            // btnConsultarFunc
            // 
            this.btnConsultarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFunc.Location = new System.Drawing.Point(346, 476);
            this.btnConsultarFunc.Name = "btnConsultarFunc";
            this.btnConsultarFunc.Size = new System.Drawing.Size(129, 32);
            this.btnConsultarFunc.TabIndex = 43;
            this.btnConsultarFunc.Tag = "Consultar";
            this.btnConsultarFunc.Text = "Consultar";
            this.btnConsultarFunc.UseVisualStyleBackColor = true;
            this.btnConsultarFunc.Click += new System.EventHandler(this.btnsNovoAlterarConsultarFunc_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(12, 97);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(160, 23);
            this.btnPesquisarFuncionario.TabIndex = 44;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Visible = false;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // lblQtdRegistrosExibidos
            // 
            this.lblQtdRegistrosExibidos.AutoSize = true;
            this.lblQtdRegistrosExibidos.Location = new System.Drawing.Point(9, 449);
            this.lblQtdRegistrosExibidos.Name = "lblQtdRegistrosExibidos";
            this.lblQtdRegistrosExibidos.Size = new System.Drawing.Size(116, 13);
            this.lblQtdRegistrosExibidos.TabIndex = 45;
            this.lblQtdRegistrosExibidos.Text = "Qtd Registros Exibidos:";
            // 
            // lblTotalCadastrados
            // 
            this.lblTotalCadastrados.AutoSize = true;
            this.lblTotalCadastrados.Location = new System.Drawing.Point(532, 449);
            this.lblTotalCadastrados.Name = "lblTotalCadastrados";
            this.lblTotalCadastrados.Size = new System.Drawing.Size(96, 13);
            this.lblTotalCadastrados.TabIndex = 46;
            this.lblTotalCadastrados.Text = "Total Cadastrados:";
            // 
            // dtpDataAdmissaoMin
            // 
            this.dtpDataAdmissaoMin.Enabled = false;
            this.dtpDataAdmissaoMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissaoMin.Location = new System.Drawing.Point(34, 31);
            this.dtpDataAdmissaoMin.Name = "dtpDataAdmissaoMin";
            this.dtpDataAdmissaoMin.Size = new System.Drawing.Size(99, 20);
            this.dtpDataAdmissaoMin.TabIndex = 47;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 520);
            this.Controls.Add(this.lblTotalCadastrados);
            this.Controls.Add(this.lblQtdRegistrosExibidos);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.btnConsultarFunc);
            this.Controls.Add(this.chkFiltroAvançado);
            this.Controls.Add(this.btnAlterarFunc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnNovoFunc);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.contextMenuStrip1ColumnView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.CheckBox chkAtivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterarFunc;
        private System.Windows.Forms.ComboBox cboDepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkComDatasAdmissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.CheckBox chkFeminino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkFiltroAvançado;
        private System.Windows.Forms.Button btnConsultarFunc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1ColumnView;
        private System.Windows.Forms.ToolStripMenuItem esconderColunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataNascToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAdmissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeDaFotoToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioMax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissaoMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAtivaFiltroSalario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.CheckBox chkSemDatasAdmissao;
        private System.Windows.Forms.Label lblQtdRegistrosExibidos;
        private System.Windows.Forms.Label lblTotalCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAtivo;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissaoMin;
    }
}
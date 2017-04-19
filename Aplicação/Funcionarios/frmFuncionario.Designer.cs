namespace Funcionarios
{
    partial class frmFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDataAdmisao = new System.Windows.Forms.CheckBox();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddDepartamento = new System.Windows.Forms.Button();
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtCelularFunc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtCpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataAdmissaoFunc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoverImagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrarOuAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDataAdmisao);
            this.groupBox1.Controls.Add(this.txtIdFunc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddDepartamento);
            this.groupBox1.Controls.Add(this.cboDepartamentos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEmailFunc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mtxtCelularFunc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtxtCpfFunc);
            this.groupBox1.Controls.Add(this.mtxtDataNascFunc);
            this.groupBox1.Controls.Add(this.dtpDataAdmissaoFunc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnRemoverImagem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalarioFunc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomeFunc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 319);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // chkDataAdmisao
            // 
            this.chkDataAdmisao.AutoSize = true;
            this.chkDataAdmisao.Location = new System.Drawing.Point(203, 226);
            this.chkDataAdmisao.Name = "chkDataAdmisao";
            this.chkDataAdmisao.Size = new System.Drawing.Size(15, 14);
            this.chkDataAdmisao.TabIndex = 30;
            this.chkDataAdmisao.UseVisualStyleBackColor = true;
            this.chkDataAdmisao.CheckedChanged += new System.EventHandler(this.chkDataAdmisao_CheckedChanged);
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(205, 56);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.ReadOnly = true;
            this.txtIdFunc.Size = new System.Drawing.Size(46, 21);
            this.txtIdFunc.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cod:";
            // 
            // btnAddDepartamento
            // 
            this.btnAddDepartamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartamento.Location = new System.Drawing.Point(312, 281);
            this.btnAddDepartamento.Name = "btnAddDepartamento";
            this.btnAddDepartamento.Size = new System.Drawing.Size(35, 21);
            this.btnAddDepartamento.TabIndex = 27;
            this.btnAddDepartamento.Text = "+";
            this.btnAddDepartamento.UseVisualStyleBackColor = true;
            this.btnAddDepartamento.Click += new System.EventHandler(this.btnAddDepartamento_Click);
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(203, 281);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(101, 23);
            this.cboDepartamentos.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Departamento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAtivo);
            this.groupBox3.Location = new System.Drawing.Point(320, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 45);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(6, 19);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(51, 19);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(168, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 28);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cadastro de Funcionario";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email:";
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(203, 193);
            this.txtEmailFunc.MaxLength = 80;
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(202, 21);
            this.txtEmailFunc.TabIndex = 22;
            this.txtEmailFunc.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailFunc_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Celular:";
            // 
            // mtxtCelularFunc
            // 
            this.mtxtCelularFunc.Location = new System.Drawing.Point(203, 140);
            this.mtxtCelularFunc.Mask = "(00) 0000-00000";
            this.mtxtCelularFunc.Name = "mtxtCelularFunc";
            this.mtxtCelularFunc.Size = new System.Drawing.Size(97, 21);
            this.mtxtCelularFunc.TabIndex = 20;
            this.mtxtCelularFunc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCelularFunc.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtCelularFunc_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "CPF:";
            // 
            // mtxtCpfFunc
            // 
            this.mtxtCpfFunc.Location = new System.Drawing.Point(203, 113);
            this.mtxtCpfFunc.Mask = "000,000,000-00";
            this.mtxtCpfFunc.Name = "mtxtCpfFunc";
            this.mtxtCpfFunc.Size = new System.Drawing.Size(97, 21);
            this.mtxtCpfFunc.TabIndex = 18;
            this.mtxtCpfFunc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCpfFunc.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtCpfFunc_Validating);
            // 
            // mtxtDataNascFunc
            // 
            this.mtxtDataNascFunc.Location = new System.Drawing.Point(203, 167);
            this.mtxtDataNascFunc.Mask = "00/00/0000";
            this.mtxtDataNascFunc.Name = "mtxtDataNascFunc";
            this.mtxtDataNascFunc.Size = new System.Drawing.Size(75, 21);
            this.mtxtDataNascFunc.TabIndex = 14;
            this.mtxtDataNascFunc.ValidatingType = typeof(System.DateTime);
            this.mtxtDataNascFunc.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtDataNascFunc_Validating);
            // 
            // dtpDataAdmissaoFunc
            // 
            this.dtpDataAdmissaoFunc.Enabled = false;
            this.dtpDataAdmissaoFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissaoFunc.Location = new System.Drawing.Point(219, 223);
            this.dtpDataAdmissaoFunc.Name = "dtpDataAdmissaoFunc";
            this.dtpDataAdmissaoFunc.Size = new System.Drawing.Size(85, 21);
            this.dtpDataAdmissaoFunc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtFeminino);
            this.groupBox2.Controls.Add(this.rbtMasculino);
            this.groupBox2.Location = new System.Drawing.Point(326, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 72);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(13, 45);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(77, 19);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(13, 23);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(82, 19);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRemoverImagem
            // 
            this.btnRemoverImagem.Location = new System.Drawing.Point(10, 172);
            this.btnRemoverImagem.Name = "btnRemoverImagem";
            this.btnRemoverImagem.Size = new System.Drawing.Size(65, 24);
            this.btnRemoverImagem.TabIndex = 11;
            this.btnRemoverImagem.Text = "Remover";
            this.btnRemoverImagem.UseVisualStyleBackColor = true;
            this.btnRemoverImagem.Click += new System.EventHandler(this.btnRemoverImagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salário:";
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.Location = new System.Drawing.Point(203, 250);
            this.txtSalarioFunc.MaxLength = 10;
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(85, 21);
            this.txtSalarioFunc.TabIndex = 8;
            this.txtSalarioFunc.TextChanged += new System.EventHandler(this.txtSalarioFunc_TextChanged);
            this.txtSalarioFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioFunc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data de Admissão:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(203, 86);
            this.txtNomeFunc.MaxLength = 60;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(202, 21);
            this.txtNomeFunc.TabIndex = 7;
            this.txtNomeFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFunc_KeyPress);
            this.txtNomeFunc.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeFunc_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCadastrarOuAlterar
            // 
            this.btnCadastrarOuAlterar.Location = new System.Drawing.Point(284, 345);
            this.btnCadastrarOuAlterar.Name = "btnCadastrarOuAlterar";
            this.btnCadastrarOuAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarOuAlterar.TabIndex = 37;
            this.btnCadastrarOuAlterar.Text = "Cadastrar";
            this.btnCadastrarOuAlterar.UseVisualStyleBackColor = true;
            this.btnCadastrarOuAlterar.Click += new System.EventHandler(this.btnCadastrarOuAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 380);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarOuAlterar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtCelularFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtCpfFunc;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascFunc;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissaoFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoverImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button btnAddDepartamento;
        private System.Windows.Forms.ComboBox cboDepartamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarOuAlterar;
        private System.Windows.Forms.CheckBox chkDataAdmisao;
        private System.Windows.Forms.TextBox txtSalarioFunc;
    }
}


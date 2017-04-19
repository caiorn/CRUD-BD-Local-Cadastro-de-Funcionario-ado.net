namespace Funcionarios
{
    partial class frmDepartamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcelarAlteracao = new System.Windows.Forms.Button();
            this.btnPesquisarDepartamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDepart = new System.Windows.Forms.TextBox();
            this.btnCadastrarDepartamento = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluirDepartamento = new System.Windows.Forms.Button();
            this.btnAlterarDepartamento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcelarAlteracao);
            this.groupBox1.Controls.Add(this.btnPesquisarDepartamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeDepart);
            this.groupBox1.Controls.Add(this.btnCadastrarDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Departamento";
            // 
            // btnCalcelarAlteracao
            // 
            this.btnCalcelarAlteracao.Location = new System.Drawing.Point(95, 60);
            this.btnCalcelarAlteracao.Name = "btnCalcelarAlteracao";
            this.btnCalcelarAlteracao.Size = new System.Drawing.Size(68, 23);
            this.btnCalcelarAlteracao.TabIndex = 5;
            this.btnCalcelarAlteracao.Text = "Cancelar";
            this.btnCalcelarAlteracao.UseVisualStyleBackColor = true;
            this.btnCalcelarAlteracao.Visible = false;
            this.btnCalcelarAlteracao.Click += new System.EventHandler(this.btnCalcelarAlteracao_Click);
            // 
            // btnPesquisarDepartamento
            // 
            this.btnPesquisarDepartamento.Location = new System.Drawing.Point(219, 30);
            this.btnPesquisarDepartamento.Name = "btnPesquisarDepartamento";
            this.btnPesquisarDepartamento.Size = new System.Drawing.Size(64, 23);
            this.btnPesquisarDepartamento.TabIndex = 7;
            this.btnPesquisarDepartamento.Text = "Pesquisar";
            this.btnPesquisarDepartamento.UseVisualStyleBackColor = true;
            this.btnPesquisarDepartamento.Click += new System.EventHandler(this.btnPesquisarDepartamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNomeDepart
            // 
            this.txtNomeDepart.Location = new System.Drawing.Point(50, 32);
            this.txtNomeDepart.Name = "txtNomeDepart";
            this.txtNomeDepart.Size = new System.Drawing.Size(163, 20);
            this.txtNomeDepart.TabIndex = 0;
            // 
            // btnCadastrarDepartamento
            // 
            this.btnCadastrarDepartamento.Location = new System.Drawing.Point(21, 60);
            this.btnCadastrarDepartamento.Name = "btnCadastrarDepartamento";
            this.btnCadastrarDepartamento.Size = new System.Drawing.Size(68, 23);
            this.btnCadastrarDepartamento.TabIndex = 1;
            this.btnCadastrarDepartamento.Text = "Cadastrar";
            this.btnCadastrarDepartamento.UseVisualStyleBackColor = true;
            this.btnCadastrarDepartamento.Click += new System.EventHandler(this.btnCadastrarDepartamento_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 164);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome Departamento";
            this.columnHeader2.Width = 227;
            // 
            // btnExcluirDepartamento
            // 
            this.btnExcluirDepartamento.Enabled = false;
            this.btnExcluirDepartamento.Location = new System.Drawing.Point(208, 173);
            this.btnExcluirDepartamento.Name = "btnExcluirDepartamento";
            this.btnExcluirDepartamento.Size = new System.Drawing.Size(68, 23);
            this.btnExcluirDepartamento.TabIndex = 3;
            this.btnExcluirDepartamento.Text = "Excluir";
            this.btnExcluirDepartamento.UseVisualStyleBackColor = true;
            this.btnExcluirDepartamento.Click += new System.EventHandler(this.btnExcluirDepartamento_Click);
            // 
            // btnAlterarDepartamento
            // 
            this.btnAlterarDepartamento.Enabled = false;
            this.btnAlterarDepartamento.Location = new System.Drawing.Point(134, 173);
            this.btnAlterarDepartamento.Name = "btnAlterarDepartamento";
            this.btnAlterarDepartamento.Size = new System.Drawing.Size(68, 23);
            this.btnAlterarDepartamento.TabIndex = 4;
            this.btnAlterarDepartamento.Text = "Alterar";
            this.btnAlterarDepartamento.UseVisualStyleBackColor = true;
            this.btnAlterarDepartamento.Click += new System.EventHandler(this.btnAlterarDepartamento_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnExcluirDepartamento);
            this.panel1.Controls.Add(this.btnAlterarDepartamento);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 203);
            this.panel1.TabIndex = 5;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDepart;
        private System.Windows.Forms.Button btnCadastrarDepartamento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnExcluirDepartamento;
        private System.Windows.Forms.Button btnAlterarDepartamento;
        private System.Windows.Forms.Button btnPesquisarDepartamento;
        private System.Windows.Forms.Button btnCalcelarAlteracao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
namespace Cadastro_aluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome = new Label();
            lbl_nascimento = new Label();
            lbl_curso = new Label();
            lbl_telefone = new Label();
            txtbox_nome = new TextBox();
            txtbox_nascimento = new TextBox();
            txtbox_curso = new TextBox();
            txtbox_telefone = new TextBox();
            btn_cadastrar = new Button();
            btn_listar = new Button();
            btn_editar = new Button();
            btn_excluir = new Button();
            btn_limpar = new Button();
            datagrid1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagrid1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(42, 28);
            lbl_nome.Margin = new Padding(2, 0, 2, 0);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_nascimento
            // 
            lbl_nascimento.AutoSize = true;
            lbl_nascimento.Location = new Point(42, 56);
            lbl_nascimento.Margin = new Padding(2, 0, 2, 0);
            lbl_nascimento.Name = "lbl_nascimento";
            lbl_nascimento.Size = new Size(74, 15);
            lbl_nascimento.TabIndex = 1;
            lbl_nascimento.Text = "Nascimento:";
            // 
            // lbl_curso
            // 
            lbl_curso.AutoSize = true;
            lbl_curso.Location = new Point(42, 84);
            lbl_curso.Margin = new Padding(2, 0, 2, 0);
            lbl_curso.Name = "lbl_curso";
            lbl_curso.Size = new Size(41, 15);
            lbl_curso.TabIndex = 2;
            lbl_curso.Text = "Curso:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(44, 110);
            lbl_telefone.Margin = new Padding(2, 0, 2, 0);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(55, 15);
            lbl_telefone.TabIndex = 3;
            lbl_telefone.Text = "Telefone:";
            // 
            // txtbox_nome
            // 
            txtbox_nome.Location = new Point(130, 28);
            txtbox_nome.Margin = new Padding(2);
            txtbox_nome.Name = "txtbox_nome";
            txtbox_nome.Size = new Size(205, 23);
            txtbox_nome.TabIndex = 4;
            txtbox_nome.TextChanged += txtbox_nome_TextChanged;
            // 
            // txtbox_nascimento
            // 
            txtbox_nascimento.Location = new Point(130, 56);
            txtbox_nascimento.Margin = new Padding(2);
            txtbox_nascimento.Name = "txtbox_nascimento";
            txtbox_nascimento.Size = new Size(205, 23);
            txtbox_nascimento.TabIndex = 5;
            // 
            // txtbox_curso
            // 
            txtbox_curso.Location = new Point(130, 84);
            txtbox_curso.Margin = new Padding(2);
            txtbox_curso.Name = "txtbox_curso";
            txtbox_curso.Size = new Size(205, 23);
            txtbox_curso.TabIndex = 6;
            // 
            // txtbox_telefone
            // 
            txtbox_telefone.Location = new Point(130, 110);
            txtbox_telefone.Margin = new Padding(2);
            txtbox_telefone.Name = "txtbox_telefone";
            txtbox_telefone.Size = new Size(205, 23);
            txtbox_telefone.TabIndex = 7;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(21, 164);
            btn_cadastrar.Margin = new Padding(2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(78, 23);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_listar
            // 
            btn_listar.Location = new Point(112, 164);
            btn_listar.Margin = new Padding(2);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(78, 23);
            btn_listar.TabIndex = 9;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += btn_listar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(204, 164);
            btn_editar.Margin = new Padding(2);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(78, 23);
            btn_editar.TabIndex = 10;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(300, 164);
            btn_excluir.Margin = new Padding(2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(78, 23);
            btn_excluir.TabIndex = 11;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(405, 164);
            btn_limpar.Margin = new Padding(2);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(78, 23);
            btn_limpar.TabIndex = 12;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // datagrid1
            // 
            datagrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid1.Location = new Point(22, 206);
            datagrid1.Margin = new Padding(2);
            datagrid1.Name = "datagrid1";
            datagrid1.RowHeadersWidth = 62;
            datagrid1.Size = new Size(461, 135);
            datagrid1.TabIndex = 13;
            datagrid1.CellContentClick += datagrid1_CellContentClick;
            datagrid1.DoubleClick += datagrid1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 364);
            Controls.Add(datagrid1);
            Controls.Add(btn_limpar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_listar);
            Controls.Add(btn_cadastrar);
            Controls.Add(txtbox_telefone);
            Controls.Add(txtbox_curso);
            Controls.Add(txtbox_nascimento);
            Controls.Add(txtbox_nome);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_curso);
            Controls.Add(lbl_nascimento);
            Controls.Add(lbl_nome);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)datagrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_nascimento;
        private Label lbl_curso;
        private Label lbl_telefone;
        private TextBox txtbox_nome;
        private TextBox txtbox_nascimento;
        private TextBox txtbox_curso;
        private TextBox txtbox_telefone;
        private Button btn_cadastrar;
        private Button btn_listar;
        private Button btn_editar;
        private Button btn_excluir;
        private Button btn_limpar;
        private DataGridView datagrid1;
    }
}

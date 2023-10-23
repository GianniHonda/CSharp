namespace CFB_Academia
{
    partial class F_GestaoAlunos
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
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mts_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.btn_imprimirCarteirinhas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_excluirAluno = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(1, 1);
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.Size = new System.Drawing.Size(279, 416);
            this.dgv_alunos.TabIndex = 0;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(286, 17);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(181, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // mts_telefone
            // 
            this.mts_telefone.Location = new System.Drawing.Point(287, 72);
            this.mts_telefone.Mask = "(00) 0000-0000";
            this.mts_telefone.Name = "mts_telefone";
            this.mts_telefone.Size = new System.Drawing.Size(100, 20);
            this.mts_telefone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(393, 71);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(74, 21);
            this.cb_status.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turmas";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(289, 137);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(178, 21);
            this.cb_turmas.TabIndex = 8;
            // 
            // btn_imprimirCarteirinhas
            // 
            this.btn_imprimirCarteirinhas.Location = new System.Drawing.Point(289, 187);
            this.btn_imprimirCarteirinhas.Name = "btn_imprimirCarteirinhas";
            this.btn_imprimirCarteirinhas.Size = new System.Drawing.Size(178, 23);
            this.btn_imprimirCarteirinhas.TabIndex = 9;
            this.btn_imprimirCarteirinhas.Text = "Imprimir Carteirinhas";
            this.btn_imprimirCarteirinhas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 107);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Click duplo para alterar a foto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Controls.Add(this.btn_excluirAluno);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 30);
            this.panel1.TabIndex = 12;
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(3, 3);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(108, 23);
            this.btn_salvarEdicoes.TabIndex = 0;
            this.btn_salvarEdicoes.Text = "Salvar Edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // btn_excluirAluno
            // 
            this.btn_excluirAluno.Location = new System.Drawing.Point(117, 3);
            this.btn_excluirAluno.Name = "btn_excluirAluno";
            this.btn_excluirAluno.Size = new System.Drawing.Size(108, 23);
            this.btn_excluirAluno.TabIndex = 1;
            this.btn_excluirAluno.Text = "Excluir Aluno";
            this.btn_excluirAluno.UseVisualStyleBackColor = true;
            this.btn_excluirAluno.Click += new System.EventHandler(this.btn_excluirAluno_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Location = new System.Drawing.Point(231, 3);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(108, 23);
            this.btn_financeiro.TabIndex = 2;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(345, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(122, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_imprimirCarteirinhas);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mts_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_alunos);
            this.Name = "F_GestaoAlunos";
            this.Text = "F_GestaoAlunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mts_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Button btn_imprimirCarteirinhas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_excluirAluno;
        private System.Windows.Forms.Button btn_salvarEdicoes;
    }
}
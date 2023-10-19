namespace CFB_Academia
{
    partial class F_GestaodeTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nomeTurma = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_excluirTurma = new System.Windows.Forms.Button();
            this.btn_imprimirTurma = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dscTurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(3, 3);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(313, 337);
            this.dgv_turmas.TabIndex = 0;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimirTurma);
            this.panel1.Controls.Add(this.btn_excluirTurma);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Controls.Add(this.btn_nomeTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 31);
            this.panel1.TabIndex = 1;
            // 
            // btn_nomeTurma
            // 
            this.btn_nomeTurma.Location = new System.Drawing.Point(3, 4);
            this.btn_nomeTurma.Name = "btn_nomeTurma";
            this.btn_nomeTurma.Size = new System.Drawing.Size(108, 23);
            this.btn_nomeTurma.TabIndex = 0;
            this.btn_nomeTurma.Text = "Nova Turma";
            this.btn_nomeTurma.UseVisualStyleBackColor = true;
            this.btn_nomeTurma.Click += new System.EventHandler(this.btn_nomeTurma_Click);
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(117, 4);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(108, 23);
            this.btn_salvarEdicoes.TabIndex = 1;
            this.btn_salvarEdicoes.Text = "Salvar Edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // btn_excluirTurma
            // 
            this.btn_excluirTurma.Location = new System.Drawing.Point(231, 4);
            this.btn_excluirTurma.Name = "btn_excluirTurma";
            this.btn_excluirTurma.Size = new System.Drawing.Size(108, 23);
            this.btn_excluirTurma.TabIndex = 2;
            this.btn_excluirTurma.Text = "Excluir Turma";
            this.btn_excluirTurma.UseVisualStyleBackColor = true;
            this.btn_excluirTurma.Click += new System.EventHandler(this.btn_excluirTurma_Click);
            // 
            // btn_imprimirTurma
            // 
            this.btn_imprimirTurma.Location = new System.Drawing.Point(345, 4);
            this.btn_imprimirTurma.Name = "btn_imprimirTurma";
            this.btn_imprimirTurma.Size = new System.Drawing.Size(108, 23);
            this.btn_imprimirTurma.TabIndex = 3;
            this.btn_imprimirTurma.Text = "Imprimir Turma";
            this.btn_imprimirTurma.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(459, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(81, 23);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professor";
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(322, 77);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(218, 21);
            this.cb_professor.TabIndex = 2;
            this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.cb_professor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(445, 140);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(95, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horário";
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(325, 195);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(215, 21);
            this.cb_horario.TabIndex = 5;
            this.cb_horario.SelectedIndexChanged += new System.EventHandler(this.cb_horario_SelectedIndexChanged);
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(325, 140);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(114, 20);
            this.n_maxAlunos.TabIndex = 3;
            this.n_maxAlunos.ValueChanged += new System.EventHandler(this.n_maxAlunos_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome Turma";
            // 
            // tb_dscTurma
            // 
            this.tb_dscTurma.Location = new System.Drawing.Point(322, 24);
            this.tb_dscTurma.Name = "tb_dscTurma";
            this.tb_dscTurma.Size = new System.Drawing.Size(218, 20);
            this.tb_dscTurma.TabIndex = 1;
            this.tb_dscTurma.TextChanged += new System.EventHandler(this.tb_dscTurma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vagas";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Location = new System.Drawing.Point(328, 249);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.Size = new System.Drawing.Size(100, 20);
            this.tb_vagas.TabIndex = 10;
            // 
            // F_GestaodeTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dscTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaodeTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaodeTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimirTurma;
        private System.Windows.Forms.Button btn_excluirTurma;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.Button btn_nomeTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dscTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vagas;
    }
}
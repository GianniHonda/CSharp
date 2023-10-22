namespace CFB_Academia
{
    partial class F_NovoAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.btn_selTurma = new System.Windows.Forms.Button();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.btn_selPlano = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(16, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(274, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(300, 29);
            this.mtb_telefone.Mask = "(00) 0000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(79, 20);
            this.mtb_telefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Turma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plano";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 29);
            this.panel1.TabIndex = 7;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(315, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(98, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(211, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(107, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(98, 23);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(3, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(98, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(16, 82);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(147, 21);
            this.cb_status.TabIndex = 8;
            // 
            // tb_turma
            // 
            this.tb_turma.Location = new System.Drawing.Point(170, 82);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(175, 20);
            this.tb_turma.TabIndex = 9;
            this.tb_turma.Tag = "4";
            // 
            // btn_selTurma
            // 
            this.btn_selTurma.Location = new System.Drawing.Point(343, 80);
            this.btn_selTurma.Name = "btn_selTurma";
            this.btn_selTurma.Size = new System.Drawing.Size(36, 23);
            this.btn_selTurma.TabIndex = 10;
            this.btn_selTurma.Text = "...";
            this.btn_selTurma.UseVisualStyleBackColor = true;
            this.btn_selTurma.Click += new System.EventHandler(this.btn_selTurma_Click);
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(16, 135);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(189, 20);
            this.tb_plano.TabIndex = 11;
            // 
            // btn_selPlano
            // 
            this.btn_selPlano.Location = new System.Drawing.Point(202, 133);
            this.btn_selPlano.Name = "btn_selPlano";
            this.btn_selPlano.Size = new System.Drawing.Size(35, 23);
            this.btn_selPlano.TabIndex = 12;
            this.btn_selPlano.Text = "...";
            this.btn_selPlano.UseVisualStyleBackColor = true;
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 197);
            this.Controls.Add(this.btn_selPlano);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.btn_selTurma);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NovoAluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_selTurma;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Button btn_selPlano;
        public System.Windows.Forms.TextBox tb_turma;
    }
}
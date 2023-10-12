namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Fit", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Volkswagen", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_removerSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "hrv";
            treeNode7.Tag = "http://www.youtube.com/cfbcursos";
            treeNode7.Text = "HRV";
            treeNode8.Name = "fit";
            treeNode8.Text = "Fit";
            treeNode9.Name = "fit";
            treeNode9.Text = "Fit";
            treeNode10.Name = "golf";
            treeNode10.Text = "Golf";
            treeNode11.Name = "polo";
            treeNode11.Text = "Polo";
            treeNode12.Name = "volkswagen";
            treeNode12.Text = "Volkswagen";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(144, 289);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(163, 13);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(141, 23);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Add";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(163, 43);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(141, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_removerSelecionado
            // 
            this.btn_removerSelecionado.Location = new System.Drawing.Point(311, 42);
            this.btn_removerSelecionado.Name = "btn_removerSelecionado";
            this.btn_removerSelecionado.Size = new System.Drawing.Size(141, 23);
            this.btn_removerSelecionado.TabIndex = 5;
            this.btn_removerSelecionado.Text = "Remover Selecionado";
            this.btn_removerSelecionado.UseVisualStyleBackColor = true;
            this.btn_removerSelecionado.Click += new System.EventHandler(this.btn_removerSelecionado_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.btn_removerSelecionado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_TreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_removerSelecionado;
    }
}
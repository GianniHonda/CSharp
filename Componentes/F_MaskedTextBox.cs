﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mtb_senha.PasswordChar== '*')
            {
                mtb_senha.PasswordChar = '\0';
            }
            else
            {
                mtb_senha.PasswordChar = '*';
            }
        }
    }
}

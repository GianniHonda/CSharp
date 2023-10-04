using System;
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
    public partial class F_Veiculos : Form
    {
        public F_Veiculos(String v)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;
        }
    }
}

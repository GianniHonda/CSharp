using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno formNovoAluno;
        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurmas = String.Format(@"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.N_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horário',
                    tbp.T_NOMEPROFESSOR as 'Professor',
                    ( SELECT 
                        count (N_IDALUNO)
                      FROM
                        tb_alunos as tba
                      WHERE
                        tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                    )as 'Qtde.Alunos'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIOS = tbh.N_IDHORARIO
            ");
            dgv_turmas.DataSource = Banco.dql(queryTurmas);
        }
    }
}

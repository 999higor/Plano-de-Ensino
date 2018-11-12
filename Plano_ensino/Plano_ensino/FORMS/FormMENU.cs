using Plano_ensino.FORMS;
using Plano_ensino.RELATORY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plano_ensino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCURSO().ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPROFESSOR().ShowDialog();
        }

        private void componenteCurricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCOMP_CURRICULAR().ShowDialog();
        }

        private void planoDeEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPLANO_ENSINO().ShowDialog();

        }

        private void professorPlanoDeEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPROFESSOR_PLANO().ShowDialog();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FormPDF().ShowDialog();
        }

        private void planoDeEnsinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormPDF().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCursos_Click(object sender, EventArgs e)
        {
            new FormCURSO().ShowDialog();
        }

        private void btComp_Click(object sender, EventArgs e)
        {
            new FormCOMP_CURRICULAR().ShowDialog();
        }

        private void btPlano_Click(object sender, EventArgs e)
        {
            new FormPLANO_ENSINO().ShowDialog();
        }

        private void btProf_Click(object sender, EventArgs e)
        {
            new FormPROFESSOR_PLANO().ShowDialog();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            new FormPDF().ShowDialog();
        }
    }
}

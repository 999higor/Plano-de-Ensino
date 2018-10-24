using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plano_ensino.FORMS
{
    public partial class FormPDF : Form
    {
        public FormPDF()
        {
            InitializeComponent();
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.PlanoEnsino' table. You can move, or remove it, as needed.
            this.planoEnsinoTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.PlanoEnsino);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.ComponenteCurricular' table. You can move, or remove it, as needed.
            this.componenteCurricularTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.ComponenteCurricular);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.Professor);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.Curso);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

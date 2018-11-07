using Plano_ensino.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plano_ensino.RELATORY
{
    public partial class FormPDF : Form
    {
        public FormPDF()
        {
            InitializeComponent();
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            this.loadComboBox();

            //this.reportViewer1.RefreshReport();
        }

        private void loadComboBox()
        {
            /*DataTable dtTabelas = Comp_CurricularDAL.atualiza_combo();

            //carrega as informacoes no combo
            comboCurso.DataSource = dtTabelas;
            comboCurso.DisplayMember = "nome";
            comboCurso.ValueMember = "IdCurso";

            DataTable dtTabelas_Comp = Plano_EnsinoDAL.atualiza_combo();

            //carrega as informacoes no combo
            comboComp.DataSource = dtTabelas_Comp;
            comboComp.DisplayMember = "nome";
            comboComp.ValueMember = "IdComponenteCurricular";

            DataTable dtTabelas_Prof = ProfessorDAL.atualiza_combo();

            //carrega as informacoes no combo
            comboProf.DataSource = dtTabelas_Prof;
            comboProf.DisplayMember = "nome";
            comboProf.ValueMember = "IdProfessor";  */

            DataTable dtTabelas_Plano = Plano_EnsinoDAL.atualiza_combo_Plano();

            //carrega as informacoes no combo
            comboPlano.DataSource = dtTabelas_Plano;
            comboPlano.DisplayMember = "nome";
            comboPlano.ValueMember = "IdPlanoEnsino";


        }


        private void button1_Click(object sender, EventArgs e)
        {

            /*try
            {
                this.professorTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.Professor, ((int)(System.Convert.ChangeType(comboProf.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.cursoTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.Curso, ((int)(System.Convert.ChangeType(comboCurso.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.componenteCurricularTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.ComponenteCurricular, ((int)(System.Convert.ChangeType(comboComp.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.planoEnsinoTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.PlanoEnsino, ((int)(System.Convert.ChangeType(comboPlano.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

            try
            {
                this.pdfTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.pdf, ((int)(System.Convert.ChangeType(comboPlano.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();

        }


        /*private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pdfTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.pdf, ((int)(System.Convert.ChangeType(valueToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();

        }*/
    }

}

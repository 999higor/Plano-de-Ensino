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
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.PlanoEnsino' table. You can move, or remove it, as needed.
            this.planoEnsinoTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.PlanoEnsino);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.ComponenteCurricular' table. You can move, or remove it, as needed.
            this.componenteCurricularTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.ComponenteCurricular);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.Curso);
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.Professor);

            this.loadComboBox();

            //this.reportViewer1.RefreshReport();
        }

        private void loadComboBox()
        {
            DataTable dtTabelas = Comp_CurricularDAL.atualiza_combo();

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
            comboProf.ValueMember = "IdProfessor";

            DataTable dtTabelas_Plano = Plano_EnsinoDAL.atualiza_combo_Plano();

            //carrega as informacoes no combo
            comboPlano.DataSource = dtTabelas_Plano;
            comboPlano.DisplayMember = "ano";
            comboPlano.ValueMember = "IdPlanoEnsino";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            }

            this.reportViewer1.RefreshReport();
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.professorTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.Professor, ((int)(System.Convert.ChangeType(comboProf.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cursoTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.Curso, ((int)(System.Convert.ChangeType(comboCurso.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.componenteCurricularTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.ComponenteCurricular, ((int)(System.Convert.ChangeType(comboComp.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.planoEnsinoTableAdapter.FillBy(this.bD_PlanoEnsinoDataSet.PlanoEnsino, ((int)(System.Convert.ChangeType(comboPlano.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

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

namespace Plano_ensino.FORMS
{
    public partial class FormCOMP_CURRICULAR : Form
    {
        public FormCOMP_CURRICULAR()
        {
            InitializeComponent();
        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Comp_CurricularDAL.Inserir(tbNOME.Text, Convert.ToInt16(tbSEMESTRE.Text),
                tbOBJETIVO.Text, tbMOD_OFERTA.Text, tbEMENTA.Text, tbREF_BASICA.Text, tbREF_COMPLEMENTAR.Text, Convert.ToInt16(tbHRA_DISTANCIA.Text),
                Convert.ToInt16(tbHRA_PRESENCIAL.Text), Convert.ToInt16(tbHRR_DISTANCIA.Text), 
                Convert.ToInt16(tb_HRR_PRESENCIAL.Text), Convert.ToInt16(cbCURSO.SelectedValue));

            if (resultado == 1)
            {
                MessageBox.Show("Registro Inserido com Sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao Inserir o Registro !");
            }
        }

        private void carrega_combo()
        {
            DataTable dtTabelas = Comp_CurricularDAL.atualiza_combo();

            //carrega as informacoes no combo
            cbCURSO.DataSource = dtTabelas;
            cbCURSO.DisplayMember = "nome";
            cbCURSO.ValueMember = "IdCurso";
        }

        private void FormCOMP_CURRICULAR_Load(object sender, EventArgs e)
        {
            this.carrega_combo();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

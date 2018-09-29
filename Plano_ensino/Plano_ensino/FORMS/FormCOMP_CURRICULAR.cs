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
            this.carrega_tabela();
        }

        private void carrega_tabela()
        {
            DataSet ds = Comp_CurricularDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
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
            this.carrega_tabela();
        }

        private void btNOVO_Click(object sender, EventArgs e)
        {
            tbID.ResetText();
            tbNOME.ResetText();
            tbOBJETIVO.ResetText();
            tbREF_BASICA.ResetText();
            tbREF_COMPLEMENTAR.ResetText();
            tbSEMESTRE.ResetText();
            tbMOD_OFERTA.ResetText();
            tbEMENTA.ResetText();
            tbHRA_DISTANCIA.ResetText();
            tbHRA_PRESENCIAL.ResetText();
            tbHRR_DISTANCIA.ResetText();
            tb_HRR_PRESENCIAL.ResetText();
        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Comp_CurricularDAL.Alterar(Convert.ToInt32(tbID.Text),tbNOME.Text, Convert.ToInt16(tbSEMESTRE.Text),
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
            this.carrega_tabela();
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Comp_CurricularDAL.Excluir(Convert.ToInt16(tbID.Text));

            if (resultado == 1)
            {
                MessageBox.Show("Registro Excluído com Sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao Excluir o Registro !");
            }
            this.carrega_tabela();
        }

        private void SelecionarTabela(object sender, MouseEventArgs e)
        {
            int selecionado = -1;

            if (tabela.SelectedRows.Count > 0)
            {
                selecionado = tabela.SelectedRows[0].Index;
            }
            else
            {
                if (tabela.SelectedCells.Count > 0)
                {
                    selecionado = tabela.SelectedCells[0].RowIndex;
                }
            }

            if (selecionado != -1)
            {
                DataRowView dr = (DataRowView)tabela.Rows[selecionado].DataBoundItem;
                tbID.Text = dr["ID"].ToString();
                tbNOME.Text = dr["Nome"].ToString();
                tbOBJETIVO.Text = dr["Objetivo"].ToString();
                tbSEMESTRE.Text = dr["Semestre"].ToString();
                tbMOD_OFERTA.Text = dr["Oferta"].ToString();
                tbEMENTA.Text = dr["Ementa"].ToString();
                tbREF_COMPLEMENTAR.Text = dr["Ref - Complementares"].ToString();
                tbREF_BASICA.Text = dr["Ref - Básicas"].ToString();
                tbHRA_DISTANCIA.Text = dr["HA - Distância"].ToString();
                tbHRA_PRESENCIAL.Text = dr["HA - Presencial"].ToString();
                tbHRR_DISTANCIA.Text = dr["HR - Distância"].ToString();
                tb_HRR_PRESENCIAL.Text = dr["HR - Presencial"].ToString();
                cbCURSO.SelectedValue = Convert.ToInt16(dr["Curso"].ToString());
            }
        }
    }
}

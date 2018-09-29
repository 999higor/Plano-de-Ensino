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
    public partial class FormPLANO_ENSINO : Form
    {
        public FormPLANO_ENSINO()
        {
            InitializeComponent();
        }

        private void FormPLANO_ENSINO_Load(object sender, EventArgs e)
        {
            this.carrega_tabela();
            this.carrega_combo();
        }

        private void carrega_tabela()
        {
            DataSet ds = Plano_EnsinoDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void carrega_combo()
        {
            DataTable dtTabelas = Plano_EnsinoDAL.atualiza_combo();

            //carrega as informacoes no combo
            cbCOMP_CURRICULAR.DataSource = dtTabelas;
            cbCOMP_CURRICULAR.DisplayMember = "nome";
            cbCOMP_CURRICULAR.ValueMember = "IdComponenteCurricular";
        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Plano_EnsinoDAL.Inserir(Convert.ToInt32(tbANO.Text), Convert.ToInt16(tbSEMESTRE.Text),
                tbCOLEGIADO.Text, tbINTEGRACAO.Text, tbAVALIACAO.Text, tbREF_APROFUNDAMENTO.Text, tbCONTEUDO_PROGRAMADO.Text, tbCRONOGRAMA.Text,
                tbRECUPERACAO.Text, tbMETODOLOGIA.Text, Convert.ToInt16(cbCOMP_CURRICULAR.SelectedValue));

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

        private void btNOVO_Click(object sender, EventArgs e)
        {
            tbID.ResetText();
            tbANO.ResetText();
            tbSEMESTRE.ResetText();
            tbCOLEGIADO.ResetText();
            tbINTEGRACAO.ResetText();
            tbAVALIACAO.ResetText();
            tbREF_APROFUNDAMENTO.ResetText();
            tbCONTEUDO_PROGRAMADO.ResetText();
            tbCRONOGRAMA.ResetText();
            tbRECUPERACAO.ResetText();
            tbMETODOLOGIA.ResetText();

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
                tbANO.Text = dr["Ano"].ToString();
                tbSEMESTRE.Text = dr["Semestre"].ToString();
                tbCOLEGIADO.Text = dr["Colegiado"].ToString();
                tbINTEGRACAO.Text = dr["Integração"].ToString();
                tbAVALIACAO.Text = dr["Avaliação"].ToString();
                tbREF_APROFUNDAMENTO.Text = dr["Ref - Aprofundamento"].ToString();
                tbCRONOGRAMA.Text = dr["Cronograma"].ToString();
                tbRECUPERACAO.Text = dr["Recuperação"].ToString();
                tbMETODOLOGIA.Text = dr["Metodologia"].ToString();
                
                cbCOMP_CURRICULAR.SelectedValue = Convert.ToInt16(dr["ID - CP"].ToString());
            }
        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Plano_EnsinoDAL.Alterar(Convert.ToInt32(tbID.Text),Convert.ToInt32(tbANO.Text), Convert.ToInt16(tbSEMESTRE.Text),
                tbCOLEGIADO.Text, tbINTEGRACAO.Text, tbAVALIACAO.Text, tbREF_APROFUNDAMENTO.Text, tbCONTEUDO_PROGRAMADO.Text, tbCRONOGRAMA.Text,
                tbRECUPERACAO.Text, tbMETODOLOGIA.Text, Convert.ToInt16(cbCOMP_CURRICULAR.SelectedValue));

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
            resultado = Plano_EnsinoDAL.Excluir(Convert.ToInt16(tbID.Text));

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
    }
}

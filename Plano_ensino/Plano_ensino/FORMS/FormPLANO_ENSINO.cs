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
            if (string.IsNullOrEmpty(tbANO.Text) || string.IsNullOrEmpty(tbSEMESTRE.Text) || string.IsNullOrEmpty(tbCOLEGIADO.Text)
                || string.IsNullOrEmpty(tbINTEGRACAO.Text) || string.IsNullOrEmpty(tbAVALIACAO.Text) || string.IsNullOrEmpty(tbCONTEUDO_PROGRAMADO.Text)
                || string.IsNullOrEmpty(tbCRONOGRAMA.Text) || string.IsNullOrEmpty(tbRECUPERACAO.Text) || string.IsNullOrEmpty(tbMETODOLOGIA.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Inserir !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int resultado = 0;
                resultado = Plano_EnsinoDAL.Inserir(Convert.ToInt32(tbANO.Text), Convert.ToInt16(tbSEMESTRE.Text),
                    tbCOLEGIADO.Text, tbINTEGRACAO.Text, tbAVALIACAO.Text, tbREF_APROFUNDAMENTO.Text, tbCONTEUDO_PROGRAMADO.Text, tbCRONOGRAMA.Text,
                    tbRECUPERACAO.Text, tbMETODOLOGIA.Text, Convert.ToInt16(cbCOMP_CURRICULAR.SelectedValue));

                if (resultado == 1)
                {
                    MessageBox.Show("Registro Inserido com Sucesso !", " Aviso de Inserção ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao Inserir o Registro !", " Aviso de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Aviso de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(tbID.Text) && string.IsNullOrEmpty(tbANO.Text) && string.IsNullOrEmpty(tbSEMESTRE.Text) && string.IsNullOrEmpty(tbCOLEGIADO.Text)
                && string.IsNullOrEmpty(tbINTEGRACAO.Text) && string.IsNullOrEmpty(tbAVALIACAO.Text) && string.IsNullOrEmpty(tbCONTEUDO_PROGRAMADO.Text)
                && string.IsNullOrEmpty(tbCRONOGRAMA.Text) && string.IsNullOrEmpty(tbRECUPERACAO.Text) && string.IsNullOrEmpty(tbMETODOLOGIA.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Alterar !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;
                    resultado = Plano_EnsinoDAL.Alterar(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbANO.Text), Convert.ToInt16(tbSEMESTRE.Text),
                        tbCOLEGIADO.Text, tbINTEGRACAO.Text, tbAVALIACAO.Text, tbREF_APROFUNDAMENTO.Text, tbCONTEUDO_PROGRAMADO.Text, tbCRONOGRAMA.Text,
                        tbRECUPERACAO.Text, tbMETODOLOGIA.Text, Convert.ToInt16(cbCOMP_CURRICULAR.SelectedValue));

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro Alterado com Sucesso !", "Aviso de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Alterar o Registro !", "Aviso de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.carrega_tabela();
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluír esse Registro ?", "Aviso de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(tbID.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Excluír !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;
                    resultado = Plano_EnsinoDAL.Excluir(Convert.ToInt16(tbID.Text));

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro Excluído com Sucesso !", "Aviso de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Excluir o Registro !", "Aviso de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.carrega_tabela();
        }

        private void atualizaPesquisa()
        {
            DataSet ds = Plano_EnsinoDAL.Pesquisar(tbPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void btPESQUISAR_Click(object sender, EventArgs e)
        {
            this.atualizaPesquisa();
        }
    }
}

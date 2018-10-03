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
    public partial class FormPROFESSOR : Form
    {
        public FormPROFESSOR()
        {
            InitializeComponent();
        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIDPROFESSOR.Text) || string.IsNullOrEmpty(tbNOME.Text))
            {
                MessageBox.Show(" Verifique campos em Branco !", "Falha ao Inserir !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int resultado = 0;
                resultado = ProfessorDAL.Inserir(tbNOME.Text, Convert.ToInt32(tbIDPROFESSOR.Text));

                if (resultado == 1)
                {
                    MessageBox.Show("Registro Inserido com Sucesso !", " Aviso de Inserção ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao Inserir o Registro !", " Aviso de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.atualizaTabela();
        }

        private void btNOVO_Click(object sender, EventArgs e)
        {
            tbIDPROFESSOR.ResetText();
            tbNOME.ResetText();
        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluír esse Registro ?", "Aviso de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(tbIDPROFESSOR.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Excluír !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = 0;
                    resultado = ProfessorDAL.Excluir(Convert.ToInt32(tbIDPROFESSOR.Text));

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
            this.atualizaTabela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Aviso de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(tbIDPROFESSOR.Text) && string.IsNullOrEmpty(tbNOME.Text))
                {
                    MessageBox.Show(" Verifique campos em Branco !", "Falha ao Alterar !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    int resultado = 0;
                    resultado = ProfessorDAL.Alterar(Convert.ToInt16(tbIDPROFESSOR.Text), tbNOME.Text);

                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro Alterado com Sucesso !" ,"Aviso de Alteração" ,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao Alterar o Registro !" ,"Aviso de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.atualizaTabela();
        }

        private void atualizaTabela()
        {
            DataSet ds = ProfessorDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }
        private void atualizaPesquisa()
        {
            DataSet ds = ProfessorDAL.Pesquisar(tbPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void FormPROFESSOR_Load(object sender, EventArgs e)
        {
            this.atualizaTabela();
        }

        private void btPESQUISAR_Click(object sender, EventArgs e)
        {
            this.atualizaPesquisa();
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
                tbIDPROFESSOR.Text = dr["CRM"].ToString();
                tbNOME.Text = dr["Nome"].ToString();
            }
        }
    }
}

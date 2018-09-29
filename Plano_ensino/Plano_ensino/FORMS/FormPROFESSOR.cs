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
            int resultado = 0;
            resultado = ProfessorDAL.Inserir(tbNOME.Text, Convert.ToInt32(tbIDPROFESSOR.Text));

            if (resultado == 1)
            {
                MessageBox.Show("Registro Inserido com Sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao Inserir o Registro !");
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
            int resultado = 0;
            resultado = ProfessorDAL.Excluir(Convert.ToInt32(tbIDPROFESSOR.Text));

            if (resultado == 1)
            {
                MessageBox.Show("Registro Excluído com Sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao Excluir o Registro !");
            }
            this.atualizaTabela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = ProfessorDAL.Alterar(Convert.ToInt16(tbIDPROFESSOR.Text), tbNOME.Text);

            if (resultado == 1)
            {
                MessageBox.Show("Registro Alterado com Sucesso !");
            }
            else
            {
                MessageBox.Show("Falha ao Alterar o Registro !");
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
            // TODO: This line of code loads data into the 'bD_PlanoEnsinoDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.bD_PlanoEnsinoDataSet.Professor);
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

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
    public partial class FormCURSO : Form
    {
        public FormCURSO()
        {
            InitializeComponent();
        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = CursoDAL.Inserir(tbNOME.Text, tbOBJETIVO.Text);

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
            tbIDCURSO.ResetText();
            tbNOME.ResetText();
            tbOBJETIVO.ResetText();
            this.atualizaTabela();
        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = CursoDAL.Alterar(Convert.ToInt16(tbIDCURSO.Text), tbNOME.Text, tbOBJETIVO.Text);

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

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = CursoDAL.Excluir(Convert.ToInt16(tbIDCURSO.Text));

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

        private void atualizaTabela()
        {
            DataSet ds = CursoDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }
        private void atualizaPesquisa()
        {
            DataSet ds = CursoDAL.Pesquisar(tbPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void FormCURSO_Load(object sender, EventArgs e)
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
                tbIDCURSO.Text = dr["ID"].ToString();
                tbNOME.Text = dr["Curso"].ToString();
                tbOBJETIVO.Text = dr["Objetivo"].ToString();
            }
        }
    }
}

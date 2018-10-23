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
    public partial class FormPROFESSOR_PLANO : Form
    {
        public FormPROFESSOR_PLANO()
        {
            InitializeComponent();
        }
        private void atualizaPesquisa()
        {
            DataSet ds = Prof_PlanoEnsinoDAL.Pesquisar(tbPESQUISA.Text);
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void comboProfessor()
        {
            DataTable dtTabelas = Prof_PlanoEnsinoDAL.comboProfessor();

            //carrega as informacoes no combo
            cbPROFESSOR.DataSource = dtTabelas;
            cbPROFESSOR.DisplayMember = "nome";
            cbPROFESSOR.ValueMember = "IdProfessor";
        }

        private void comboPlanoEnsino()
        {
            DataTable dtTabelas = Prof_PlanoEnsinoDAL.comboPlanoEnsino();

            //carrega as informacoes no combo
            cbPLANO_ENSINO.DataSource = dtTabelas;
            cbPLANO_ENSINO.DisplayMember = "ano";
            cbPLANO_ENSINO.ValueMember = "IdPlanoEnsino";
        }

        private void atualizaTabela()
        {
            DataSet ds = Prof_PlanoEnsinoDAL.atualizaTabela();
            tabela.DataSource = ds;
            tabela.DataMember = ds.Tables[0].TableName;
        }

        private void btSALVAR_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Prof_PlanoEnsinoDAL.Inserir(Convert.ToInt32(cbPROFESSOR.SelectedValue), Convert.ToInt32(cbPLANO_ENSINO.SelectedValue));
       
            if (resultado == 1)
            {
                MessageBox.Show("Registro Inserido com Sucesso !", " Aviso de Inserção ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Falha ao Inserir o Registro !", " Aviso de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.atualizaTabela();
        }

        private void btALTERAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Alterar esse Registro ?", "Aviso de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int resultado = 0;
                resultado = Prof_PlanoEnsinoDAL.Alterar(Convert.ToInt16(cbPROFESSOR.SelectedValue), Convert.ToInt32(cbPLANO_ENSINO.SelectedValue) );

                if (resultado == 1)
                {
                    MessageBox.Show("Registro Alterado com Sucesso !", "Aviso de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao Alterar o Registro !", "Aviso de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.atualizaTabela();

        }

        private void btEXCLUIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluír esse Registro ?", "Aviso de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int resultado = 0;
                resultado = Prof_PlanoEnsinoDAL.Excluir(Convert.ToInt16(cbPROFESSOR.SelectedValue), Convert.ToInt32(cbPLANO_ENSINO.SelectedValue));

                if (resultado == 1)
                {
                    MessageBox.Show("Registro Excluído com Sucesso !", "Aviso de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Falha ao Excluir o Registro !", "Aviso de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.atualizaTabela();
        }

        private void FormPROFESSOR_PLANO_Load(object sender, EventArgs e)
        {
            this.atualizaTabela();
            this.comboPlanoEnsino();
            this.comboProfessor();
        }
    }
}

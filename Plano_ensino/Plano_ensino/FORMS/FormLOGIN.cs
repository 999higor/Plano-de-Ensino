using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Plano_ensino.FORMS;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plano_ensino.DAL;

namespace Plano_ensino.FORMS
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show(" Preencha todos os campos !", "Falha ao fazer o Login !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                int resultado = 0;
                resultado = LoginDAL.Login(tbLogin.Text, tbSenha.Text);
                if (resultado == 1)
                {
                    MessageBox.Show("Login Realizado !", " Aviso de Login ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Login ou Senha Inválidos !", " Aviso de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

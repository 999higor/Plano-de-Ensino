﻿using Plano_ensino.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plano_ensino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCURSO().ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPROFESSOR().ShowDialog();
        }

        private void componenteCurricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCOMP_CURRICULAR().ShowDialog();
        }
    }
}
namespace Plano_ensino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteCurricularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeEnsinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeEnsinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btCursos = new System.Windows.Forms.Button();
            this.btComp = new System.Windows.Forms.Button();
            this.btPlano = new System.Windows.Forms.Button();
            this.btProf = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.componenteCurricularToolStripMenuItem,
            this.planoDeEnsinoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // componenteCurricularToolStripMenuItem
            // 
            this.componenteCurricularToolStripMenuItem.Name = "componenteCurricularToolStripMenuItem";
            this.componenteCurricularToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.componenteCurricularToolStripMenuItem.Text = "Componente Curricular";
            this.componenteCurricularToolStripMenuItem.Click += new System.EventHandler(this.componenteCurricularToolStripMenuItem_Click);
            // 
            // planoDeEnsinoToolStripMenuItem
            // 
            this.planoDeEnsinoToolStripMenuItem.Name = "planoDeEnsinoToolStripMenuItem";
            this.planoDeEnsinoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.planoDeEnsinoToolStripMenuItem.Text = "Plano de Ensino";
            this.planoDeEnsinoToolStripMenuItem.Click += new System.EventHandler(this.planoDeEnsinoToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planoDeEnsinoToolStripMenuItem1});
            this.pDFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.pDFToolStripMenuItem.Text = "Gerar Relatório";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // planoDeEnsinoToolStripMenuItem1
            // 
            this.planoDeEnsinoToolStripMenuItem1.Name = "planoDeEnsinoToolStripMenuItem1";
            this.planoDeEnsinoToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.planoDeEnsinoToolStripMenuItem1.Text = "Plano de Ensino";
            this.planoDeEnsinoToolStripMenuItem1.Click += new System.EventHandler(this.planoDeEnsinoToolStripMenuItem1_Click);
            // 
            // btCursos
            // 
            this.btCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCursos.Location = new System.Drawing.Point(11, 41);
            this.btCursos.Name = "btCursos";
            this.btCursos.Size = new System.Drawing.Size(122, 50);
            this.btCursos.TabIndex = 1;
            this.btCursos.Text = "Cursos";
            this.btCursos.UseVisualStyleBackColor = true;
            this.btCursos.Click += new System.EventHandler(this.btCursos_Click);
            // 
            // btComp
            // 
            this.btComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComp.Location = new System.Drawing.Point(152, 41);
            this.btComp.Name = "btComp";
            this.btComp.Size = new System.Drawing.Size(124, 50);
            this.btComp.TabIndex = 2;
            this.btComp.Text = "Componentes Curriculares";
            this.btComp.UseVisualStyleBackColor = true;
            this.btComp.Click += new System.EventHandler(this.btComp_Click);
            // 
            // btPlano
            // 
            this.btPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlano.Location = new System.Drawing.Point(293, 41);
            this.btPlano.Name = "btPlano";
            this.btPlano.Size = new System.Drawing.Size(122, 50);
            this.btPlano.TabIndex = 3;
            this.btPlano.Text = "Planos de Ensino";
            this.btPlano.UseVisualStyleBackColor = true;
            this.btPlano.Click += new System.EventHandler(this.btPlano_Click);
            // 
            // btProf
            // 
            this.btProf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProf.Location = new System.Drawing.Point(432, 41);
            this.btProf.Name = "btProf";
            this.btProf.Size = new System.Drawing.Size(113, 50);
            this.btProf.TabIndex = 4;
            this.btProf.Text = "Docentes";
            this.btProf.UseVisualStyleBackColor = false;
            this.btProf.Visible = false;
            this.btProf.Click += new System.EventHandler(this.btProf_Click);
            // 
            // btGerar
            // 
            this.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.Location = new System.Drawing.Point(610, 41);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(142, 50);
            this.btGerar.TabIndex = 5;
            this.btGerar.Text = "Gerar Plano de Ensino";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plano_ensino.Properties.Resources.ifrs111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.btProf);
            this.Controls.Add(this.btPlano);
            this.Controls.Add(this.btComp);
            this.Controls.Add(this.btCursos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componenteCurricularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeEnsinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeEnsinoToolStripMenuItem1;
        private System.Windows.Forms.Button btCursos;
        private System.Windows.Forms.Button btComp;
        private System.Windows.Forms.Button btPlano;
        private System.Windows.Forms.Button btProf;
        private System.Windows.Forms.Button btGerar;
    }
}


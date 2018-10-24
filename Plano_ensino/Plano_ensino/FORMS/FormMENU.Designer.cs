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
            this.professorPlanoDeEnsinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.componenteCurricularToolStripMenuItem,
            this.planoDeEnsinoToolStripMenuItem,
            this.professorPlanoDeEnsinoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // componenteCurricularToolStripMenuItem
            // 
            this.componenteCurricularToolStripMenuItem.Name = "componenteCurricularToolStripMenuItem";
            this.componenteCurricularToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.componenteCurricularToolStripMenuItem.Text = "Componente Curricular";
            this.componenteCurricularToolStripMenuItem.Click += new System.EventHandler(this.componenteCurricularToolStripMenuItem_Click);
            // 
            // planoDeEnsinoToolStripMenuItem
            // 
            this.planoDeEnsinoToolStripMenuItem.Name = "planoDeEnsinoToolStripMenuItem";
            this.planoDeEnsinoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.planoDeEnsinoToolStripMenuItem.Text = "Plano de Ensino";
            this.planoDeEnsinoToolStripMenuItem.Click += new System.EventHandler(this.planoDeEnsinoToolStripMenuItem_Click);
            // 
            // professorPlanoDeEnsinoToolStripMenuItem
            // 
            this.professorPlanoDeEnsinoToolStripMenuItem.Name = "professorPlanoDeEnsinoToolStripMenuItem";
            this.professorPlanoDeEnsinoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.professorPlanoDeEnsinoToolStripMenuItem.Text = "Professor Plano de Ensino";
            this.professorPlanoDeEnsinoToolStripMenuItem.Click += new System.EventHandler(this.professorPlanoDeEnsinoToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tela Inicial";
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
        private System.Windows.Forms.ToolStripMenuItem professorPlanoDeEnsinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
    }
}


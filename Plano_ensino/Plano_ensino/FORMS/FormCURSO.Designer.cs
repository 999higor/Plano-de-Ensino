namespace Plano_ensino.FORMS
{
    partial class FormCURSO
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
            this.tbIDCURSO = new System.Windows.Forms.TextBox();
            this.tbOBJETIVO = new System.Windows.Forms.TextBox();
            this.tbNOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSALVAR = new System.Windows.Forms.Button();
            this.btNOVO = new System.Windows.Forms.Button();
            this.btALTERAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.tbPESQUISA = new System.Windows.Forms.TextBox();
            this.btPESQUISAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDCURSO
            // 
            this.tbIDCURSO.Enabled = false;
            this.tbIDCURSO.Location = new System.Drawing.Point(55, 21);
            this.tbIDCURSO.Name = "tbIDCURSO";
            this.tbIDCURSO.Size = new System.Drawing.Size(100, 20);
            this.tbIDCURSO.TabIndex = 0;
            // 
            // tbOBJETIVO
            // 
            this.tbOBJETIVO.Location = new System.Drawing.Point(55, 100);
            this.tbOBJETIVO.Multiline = true;
            this.tbOBJETIVO.Name = "tbOBJETIVO";
            this.tbOBJETIVO.Size = new System.Drawing.Size(336, 199);
            this.tbOBJETIVO.TabIndex = 1;
            // 
            // tbNOME
            // 
            this.tbNOME.Location = new System.Drawing.Point(55, 59);
            this.tbNOME.Name = "tbNOME";
            this.tbNOME.Size = new System.Drawing.Size(100, 20);
            this.tbNOME.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Objetivo";
            // 
            // btSALVAR
            // 
            this.btSALVAR.Location = new System.Drawing.Point(55, 321);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(121, 23);
            this.btSALVAR.TabIndex = 6;
            this.btSALVAR.Text = "Salvar";
            this.btSALVAR.UseVisualStyleBackColor = true;
            this.btSALVAR.Click += new System.EventHandler(this.btSALVAR_Click);
            // 
            // btNOVO
            // 
            this.btNOVO.Location = new System.Drawing.Point(229, 321);
            this.btNOVO.Name = "btNOVO";
            this.btNOVO.Size = new System.Drawing.Size(120, 23);
            this.btNOVO.TabIndex = 7;
            this.btNOVO.Text = "Novo";
            this.btNOVO.UseVisualStyleBackColor = true;
            this.btNOVO.Click += new System.EventHandler(this.btNOVO_Click);
            // 
            // btALTERAR
            // 
            this.btALTERAR.Location = new System.Drawing.Point(229, 364);
            this.btALTERAR.Name = "btALTERAR";
            this.btALTERAR.Size = new System.Drawing.Size(120, 23);
            this.btALTERAR.TabIndex = 8;
            this.btALTERAR.Text = "Alterar";
            this.btALTERAR.UseVisualStyleBackColor = true;
            this.btALTERAR.Click += new System.EventHandler(this.btALTERAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Location = new System.Drawing.Point(55, 364);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(121, 23);
            this.btEXCLUIR.TabIndex = 9;
            this.btEXCLUIR.Text = "Excluir";
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(411, 67);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(425, 320);
            this.tabela.TabIndex = 10;
            this.tabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelecionarTabela);
            // 
            // tbPESQUISA
            // 
            this.tbPESQUISA.Location = new System.Drawing.Point(411, 21);
            this.tbPESQUISA.Name = "tbPESQUISA";
            this.tbPESQUISA.Size = new System.Drawing.Size(249, 20);
            this.tbPESQUISA.TabIndex = 11;
            // 
            // btPESQUISAR
            // 
            this.btPESQUISAR.Location = new System.Drawing.Point(682, 21);
            this.btPESQUISAR.Name = "btPESQUISAR";
            this.btPESQUISAR.Size = new System.Drawing.Size(154, 23);
            this.btPESQUISAR.TabIndex = 12;
            this.btPESQUISAR.Text = "Pesquisar";
            this.btPESQUISAR.UseVisualStyleBackColor = true;
            this.btPESQUISAR.Click += new System.EventHandler(this.btPESQUISAR_Click);
            // 
            // FormCURSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 397);
            this.Controls.Add(this.btPESQUISAR);
            this.Controls.Add(this.tbPESQUISA);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.btEXCLUIR);
            this.Controls.Add(this.btALTERAR);
            this.Controls.Add(this.btNOVO);
            this.Controls.Add(this.btSALVAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNOME);
            this.Controls.Add(this.tbOBJETIVO);
            this.Controls.Add(this.tbIDCURSO);
            this.Name = "FormCURSO";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FormCURSO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOBJETIVO;
        private System.Windows.Forms.TextBox tbNOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSALVAR;
        private System.Windows.Forms.Button btNOVO;
        private System.Windows.Forms.Button btALTERAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.TextBox tbPESQUISA;
        private System.Windows.Forms.Button btPESQUISAR;
        private System.Windows.Forms.TextBox tbIDCURSO;
    }
}
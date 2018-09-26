namespace Plano_ensino.FORMS
{
    partial class FormPROFESSOR
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
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btSALVAR = new System.Windows.Forms.Button();
            this.btNOVO = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.tbIDPROFESSOR = new System.Windows.Forms.TextBox();
            this.tbNOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPESQUISA = new System.Windows.Forms.TextBox();
            this.btPESQUISAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(240, 50);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(292, 306);
            this.tabela.TabIndex = 0;
            this.tabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelecionarTabela);
            // 
            // btSALVAR
            // 
            this.btSALVAR.Location = new System.Drawing.Point(52, 205);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(117, 23);
            this.btSALVAR.TabIndex = 1;
            this.btSALVAR.Text = "Salvar";
            this.btSALVAR.UseVisualStyleBackColor = true;
            this.btSALVAR.Click += new System.EventHandler(this.btSALVAR_Click);
            // 
            // btNOVO
            // 
            this.btNOVO.Location = new System.Drawing.Point(52, 249);
            this.btNOVO.Name = "btNOVO";
            this.btNOVO.Size = new System.Drawing.Size(117, 23);
            this.btNOVO.TabIndex = 2;
            this.btNOVO.Text = "Novo";
            this.btNOVO.UseVisualStyleBackColor = true;
            this.btNOVO.Click += new System.EventHandler(this.btNOVO_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(52, 292);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(117, 23);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Location = new System.Drawing.Point(52, 333);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(117, 23);
            this.btEXCLUIR.TabIndex = 4;
            this.btEXCLUIR.Text = "Excluir";
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // tbIDPROFESSOR
            // 
            this.tbIDPROFESSOR.Enabled = false;
            this.tbIDPROFESSOR.Location = new System.Drawing.Point(50, 12);
            this.tbIDPROFESSOR.Name = "tbIDPROFESSOR";
            this.tbIDPROFESSOR.Size = new System.Drawing.Size(100, 20);
            this.tbIDPROFESSOR.TabIndex = 5;
            // 
            // tbNOME
            // 
            this.tbNOME.Location = new System.Drawing.Point(50, 58);
            this.tbNOME.Name = "tbNOME";
            this.tbNOME.Size = new System.Drawing.Size(164, 20);
            this.tbNOME.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // tbPESQUISA
            // 
            this.tbPESQUISA.Location = new System.Drawing.Point(240, 12);
            this.tbPESQUISA.Name = "tbPESQUISA";
            this.tbPESQUISA.Size = new System.Drawing.Size(223, 20);
            this.tbPESQUISA.TabIndex = 9;
            // 
            // btPESQUISAR
            // 
            this.btPESQUISAR.Location = new System.Drawing.Point(485, 12);
            this.btPESQUISAR.Name = "btPESQUISAR";
            this.btPESQUISAR.Size = new System.Drawing.Size(95, 23);
            this.btPESQUISAR.TabIndex = 10;
            this.btPESQUISAR.Text = "Pesquisar";
            this.btPESQUISAR.UseVisualStyleBackColor = true;
            this.btPESQUISAR.Click += new System.EventHandler(this.btPESQUISAR_Click);
            // 
            // FormPROFESSOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 375);
            this.Controls.Add(this.btPESQUISAR);
            this.Controls.Add(this.tbPESQUISA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNOME);
            this.Controls.Add(this.tbIDPROFESSOR);
            this.Controls.Add(this.btEXCLUIR);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNOVO);
            this.Controls.Add(this.btSALVAR);
            this.Controls.Add(this.tabela);
            this.Name = "FormPROFESSOR";
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.FormPROFESSOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button btSALVAR;
        private System.Windows.Forms.Button btNOVO;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.TextBox tbIDPROFESSOR;
        private System.Windows.Forms.TextBox tbNOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPESQUISA;
        private System.Windows.Forms.Button btPESQUISAR;
    }
}
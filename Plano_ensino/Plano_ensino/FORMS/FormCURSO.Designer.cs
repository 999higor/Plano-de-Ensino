﻿namespace Plano_ensino.FORMS
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDCURSO
            // 
            this.tbIDCURSO.Enabled = false;
            this.tbIDCURSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDCURSO.Location = new System.Drawing.Point(12, 32);
            this.tbIDCURSO.Name = "tbIDCURSO";
            this.tbIDCURSO.Size = new System.Drawing.Size(421, 24);
            this.tbIDCURSO.TabIndex = 0;
            // 
            // tbOBJETIVO
            // 
            this.tbOBJETIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOBJETIVO.Location = new System.Drawing.Point(12, 132);
            this.tbOBJETIVO.Multiline = true;
            this.tbOBJETIVO.Name = "tbOBJETIVO";
            this.tbOBJETIVO.Size = new System.Drawing.Size(421, 199);
            this.tbOBJETIVO.TabIndex = 1;
            // 
            // tbNOME
            // 
            this.tbNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNOME.Location = new System.Drawing.Point(12, 82);
            this.tbNOME.Name = "tbNOME";
            this.tbNOME.Size = new System.Drawing.Size(421, 24);
            this.tbNOME.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Objetivo";
            // 
            // btSALVAR
            // 
            this.btSALVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSALVAR.Location = new System.Drawing.Point(28, 356);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(149, 40);
            this.btSALVAR.TabIndex = 6;
            this.btSALVAR.Text = "Inserir";
            this.btSALVAR.UseVisualStyleBackColor = true;
            this.btSALVAR.Click += new System.EventHandler(this.btSALVAR_Click);
            // 
            // btNOVO
            // 
            this.btNOVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNOVO.Location = new System.Drawing.Point(233, 356);
            this.btNOVO.Name = "btNOVO";
            this.btNOVO.Size = new System.Drawing.Size(148, 40);
            this.btNOVO.TabIndex = 7;
            this.btNOVO.Text = "Limpar";
            this.btNOVO.UseVisualStyleBackColor = true;
            this.btNOVO.Click += new System.EventHandler(this.btNOVO_Click);
            // 
            // btALTERAR
            // 
            this.btALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btALTERAR.Location = new System.Drawing.Point(233, 449);
            this.btALTERAR.Name = "btALTERAR";
            this.btALTERAR.Size = new System.Drawing.Size(148, 40);
            this.btALTERAR.TabIndex = 8;
            this.btALTERAR.Text = "Alterar";
            this.btALTERAR.UseVisualStyleBackColor = true;
            this.btALTERAR.Click += new System.EventHandler(this.btALTERAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEXCLUIR.Location = new System.Drawing.Point(28, 449);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(149, 40);
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
            this.tabela.Location = new System.Drawing.Point(457, 109);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(606, 383);
            this.tabela.TabIndex = 10;
            this.tabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelecionarTabela);
            // 
            // tbPESQUISA
            // 
            this.tbPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPESQUISA.Location = new System.Drawing.Point(458, 32);
            this.tbPESQUISA.Name = "tbPESQUISA";
            this.tbPESQUISA.Size = new System.Drawing.Size(412, 24);
            this.tbPESQUISA.TabIndex = 11;
            // 
            // btPESQUISAR
            // 
            this.btPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPESQUISAR.Location = new System.Drawing.Point(909, 10);
            this.btPESQUISAR.Name = "btPESQUISAR";
            this.btPESQUISAR.Size = new System.Drawing.Size(154, 44);
            this.btPESQUISAR.TabIndex = 12;
            this.btPESQUISAR.Text = "Pesquisar";
            this.btPESQUISAR.UseVisualStyleBackColor = true;
            this.btPESQUISAR.Click += new System.EventHandler(this.btPESQUISAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Curso";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(909, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCURSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
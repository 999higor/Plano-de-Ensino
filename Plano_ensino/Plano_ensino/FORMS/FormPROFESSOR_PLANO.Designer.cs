namespace Plano_ensino.FORMS
{
    partial class FormPROFESSOR_PLANO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPROFESSOR = new System.Windows.Forms.ComboBox();
            this.cbPLANO_ENSINO = new System.Windows.Forms.ComboBox();
            this.btSALVAR = new System.Windows.Forms.Button();
            this.btALTERAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btNOVO = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.tbPESQUISA = new System.Windows.Forms.TextBox();
            this.btPESQUISA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plano de Ensino";
            // 
            // cbPROFESSOR
            // 
            this.cbPROFESSOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPROFESSOR.FormattingEnabled = true;
            this.cbPROFESSOR.Location = new System.Drawing.Point(6, 32);
            this.cbPROFESSOR.Name = "cbPROFESSOR";
            this.cbPROFESSOR.Size = new System.Drawing.Size(329, 26);
            this.cbPROFESSOR.TabIndex = 2;
            // 
            // cbPLANO_ENSINO
            // 
            this.cbPLANO_ENSINO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPLANO_ENSINO.FormattingEnabled = true;
            this.cbPLANO_ENSINO.Location = new System.Drawing.Point(6, 84);
            this.cbPLANO_ENSINO.Name = "cbPLANO_ENSINO";
            this.cbPLANO_ENSINO.Size = new System.Drawing.Size(329, 26);
            this.cbPLANO_ENSINO.TabIndex = 3;
            // 
            // btSALVAR
            // 
            this.btSALVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSALVAR.Location = new System.Drawing.Point(111, 128);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(107, 39);
            this.btSALVAR.TabIndex = 4;
            this.btSALVAR.Text = "Salvar";
            this.btSALVAR.UseVisualStyleBackColor = true;
            this.btSALVAR.Click += new System.EventHandler(this.btSALVAR_Click);
            // 
            // btALTERAR
            // 
            this.btALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btALTERAR.Location = new System.Drawing.Point(111, 190);
            this.btALTERAR.Name = "btALTERAR";
            this.btALTERAR.Size = new System.Drawing.Size(107, 39);
            this.btALTERAR.TabIndex = 5;
            this.btALTERAR.Text = "Alterar";
            this.btALTERAR.UseVisualStyleBackColor = true;
            this.btALTERAR.Click += new System.EventHandler(this.btALTERAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEXCLUIR.Location = new System.Drawing.Point(111, 326);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(107, 39);
            this.btEXCLUIR.TabIndex = 6;
            this.btEXCLUIR.Text = "Excluír";
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            this.btEXCLUIR.Click += new System.EventHandler(this.btEXCLUIR_Click);
            // 
            // btNOVO
            // 
            this.btNOVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNOVO.Location = new System.Drawing.Point(111, 257);
            this.btNOVO.Name = "btNOVO";
            this.btNOVO.Size = new System.Drawing.Size(107, 39);
            this.btNOVO.TabIndex = 7;
            this.btNOVO.Text = "Novo";
            this.btNOVO.UseVisualStyleBackColor = true;
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(361, 84);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(415, 391);
            this.tabela.TabIndex = 8;
            // 
            // tbPESQUISA
            // 
            this.tbPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPESQUISA.Location = new System.Drawing.Point(374, 36);
            this.tbPESQUISA.Name = "tbPESQUISA";
            this.tbPESQUISA.Size = new System.Drawing.Size(257, 24);
            this.tbPESQUISA.TabIndex = 9;
            // 
            // btPESQUISA
            // 
            this.btPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPESQUISA.Location = new System.Drawing.Point(651, 30);
            this.btPESQUISA.Name = "btPESQUISA";
            this.btPESQUISA.Size = new System.Drawing.Size(125, 36);
            this.btPESQUISA.TabIndex = 10;
            this.btPESQUISA.Text = "Pesquisar";
            this.btPESQUISA.UseVisualStyleBackColor = true;
            // 
            // FormPROFESSOR_PLANO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btPESQUISA);
            this.Controls.Add(this.tbPESQUISA);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.btNOVO);
            this.Controls.Add(this.btEXCLUIR);
            this.Controls.Add(this.btALTERAR);
            this.Controls.Add(this.btSALVAR);
            this.Controls.Add(this.cbPLANO_ENSINO);
            this.Controls.Add(this.cbPROFESSOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPROFESSOR_PLANO";
            this.Text = "FormPROFESSOR_PLANO";
            this.Load += new System.EventHandler(this.FormPROFESSOR_PLANO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPROFESSOR;
        private System.Windows.Forms.ComboBox cbPLANO_ENSINO;
        private System.Windows.Forms.Button btSALVAR;
        private System.Windows.Forms.Button btALTERAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btNOVO;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.TextBox tbPESQUISA;
        private System.Windows.Forms.Button btPESQUISA;
    }
}
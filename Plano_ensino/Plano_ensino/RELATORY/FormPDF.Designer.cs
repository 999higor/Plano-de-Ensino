namespace Plano_ensino.RELATORY
{
    partial class FormPDF
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pdfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_PlanoEnsinoDataSet = new Plano_ensino.BD_PlanoEnsinoDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componenteCurricularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoEnsinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter();
            this.cursoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter();
            this.componenteCurricularTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter();
            this.planoEnsinoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter();
            this.pdfTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.pdfTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfBindingSource
            // 
            this.pdfBindingSource.DataMember = "pdf";
            this.pdfBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // bD_PlanoEnsinoDataSet
            // 
            this.bD_PlanoEnsinoDataSet.DataSetName = "BD_PlanoEnsinoDataSet";
            this.bD_PlanoEnsinoDataSet.EnforceConstraints = false;
            this.bD_PlanoEnsinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboPlano);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 128);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar Arquivo de Texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboPlano
            // 
            this.comboPlano.DisplayMember = "IdPlanoEnsino";
            this.comboPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlano.FormattingEnabled = true;
            this.comboPlano.Location = new System.Drawing.Point(12, 38);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(294, 28);
            this.comboPlano.TabIndex = 2;
            this.comboPlano.ValueMember = "IdPlanoEnsino";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 322);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dt_ALL";
            reportDataSource3.Value = this.pdfBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Plano_ensino.RELATORY.PDF_teste.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(961, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // componenteCurricularBindingSource
            // 
            this.componenteCurricularBindingSource.DataMember = "ComponenteCurricular";
            this.componenteCurricularBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // planoEnsinoBindingSource
            // 
            this.planoEnsinoBindingSource.DataMember = "PlanoEnsino";
            this.planoEnsinoBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // componenteCurricularTableAdapter
            // 
            this.componenteCurricularTableAdapter.ClearBeforeFill = true;
            // 
            // planoEnsinoTableAdapter
            // 
            this.planoEnsinoTableAdapter.ClearBeforeFill = true;
            // 
            // pdfTableAdapter
            // 
            this.pdfTableAdapter.ClearBeforeFill = true;
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPDF";
            this.Text = "FormPDF";
            this.Load += new System.EventHandler(this.FormPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_PlanoEnsinoDataSet bD_PlanoEnsinoDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource componenteCurricularBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter componenteCurricularTableAdapter;
        private System.Windows.Forms.BindingSource planoEnsinoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter planoEnsinoTableAdapter;
        private System.Windows.Forms.BindingSource pdfBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.pdfTableAdapter pdfTableAdapter;
    }
}
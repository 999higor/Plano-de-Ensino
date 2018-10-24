namespace Plano_ensino.FORMS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_PlanoEnsinoDataSet = new Plano_ensino.BD_PlanoEnsinoDataSet();
            this.bDPlanoEnsinoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter();
            this.componenteCurricularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componenteCurricularTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter();
            this.planoEnsinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoEnsinoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPlanoEnsinoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Curso";
            reportDataSource1.Value = this.cursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Plano_ensino.RELATORY.PDF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 513);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_PlanoEnsinoDataSet
            // 
            this.bD_PlanoEnsinoDataSet.DataSetName = "BD_PlanoEnsinoDataSet";
            this.bD_PlanoEnsinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDPlanoEnsinoDataSetBindingSource
            // 
            this.bDPlanoEnsinoDataSetBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            this.bDPlanoEnsinoDataSetBindingSource.Position = 0;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.bDPlanoEnsinoDataSetBindingSource;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.bDPlanoEnsinoDataSetBindingSource;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // componenteCurricularBindingSource
            // 
            this.componenteCurricularBindingSource.DataMember = "ComponenteCurricular";
            this.componenteCurricularBindingSource.DataSource = this.bDPlanoEnsinoDataSetBindingSource;
            // 
            // componenteCurricularTableAdapter
            // 
            this.componenteCurricularTableAdapter.ClearBeforeFill = true;
            // 
            // planoEnsinoBindingSource
            // 
            this.planoEnsinoBindingSource.DataMember = "PlanoEnsino";
            this.planoEnsinoBindingSource.DataSource = this.bDPlanoEnsinoDataSetBindingSource;
            // 
            // planoEnsinoTableAdapter
            // 
            this.planoEnsinoTableAdapter.ClearBeforeFill = true;
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPDF";
            this.Text = "FormPDF";
            this.Load += new System.EventHandler(this.FormPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPlanoEnsinoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDPlanoEnsinoDataSetBindingSource;
        private BD_PlanoEnsinoDataSet bD_PlanoEnsinoDataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.BindingSource componenteCurricularBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter componenteCurricularTableAdapter;
        private System.Windows.Forms.BindingSource planoEnsinoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter planoEnsinoTableAdapter;
    }
}
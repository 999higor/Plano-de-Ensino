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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.comboProf = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.valueToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.valueToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.valueToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.valueToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.valueToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.valueToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.valueToolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.valueToolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_PlanoEnsinoDataSet = new Plano_ensino.BD_PlanoEnsinoDataSet();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componenteCurricularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoEnsinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter();
            this.cursoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter();
            this.componenteCurricularTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter();
            this.planoEnsinoTableAdapter = new Plano_ensino.BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter();
            this.comboComp = new System.Windows.Forms.ComboBox();
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            this.fillByToolStrip2.SuspendLayout();
            this.fillByToolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboCurso);
            this.panel1.Controls.Add(this.comboComp);
            this.panel1.Controls.Add(this.fillByToolStrip3);
            this.panel1.Controls.Add(this.fillByToolStrip2);
            this.panel1.Controls.Add(this.fillByToolStrip1);
            this.panel1.Controls.Add(this.fillByToolStrip);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboPlano);
            this.panel1.Controls.Add(this.comboProf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 116);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboPlano
            // 
            this.comboPlano.DisplayMember = "IdPlanoEnsino";
            this.comboPlano.FormattingEnabled = true;
            this.comboPlano.Location = new System.Drawing.Point(238, 22);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(177, 21);
            this.comboPlano.TabIndex = 2;
            this.comboPlano.ValueMember = "IdPlanoEnsino";
            // 
            // comboProf
            // 
            this.comboProf.DisplayMember = "IdProfessor";
            this.comboProf.FormattingEnabled = true;
            this.comboProf.Location = new System.Drawing.Point(12, 22);
            this.comboProf.Name = "comboProf";
            this.comboProf.Size = new System.Drawing.Size(172, 21);
            this.comboProf.TabIndex = 0;
            this.comboProf.ValueMember = "IdProfessor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 334);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 44;
            reportDataSource1.Name = "DT_Prof";
            reportDataSource1.Value = this.professorBindingSource;
            reportDataSource2.Name = "DT_Curso";
            reportDataSource2.Value = this.cursoBindingSource;
            reportDataSource3.Name = "DT_Comp";
            reportDataSource3.Value = this.componenteCurricularBindingSource;
            reportDataSource4.Name = "DT_Plano";
            reportDataSource4.Value = this.planoEnsinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Plano_ensino.RELATORY.PDF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(88, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 199);
            this.reportViewer1.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueToolStripLabel,
            this.valueToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(528, 55);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(191, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // valueToolStripLabel
            // 
            this.valueToolStripLabel.Name = "valueToolStripLabel";
            this.valueToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.valueToolStripLabel.Text = "value:";
            // 
            // valueToolStripTextBox
            // 
            this.valueToolStripTextBox.Name = "valueToolStripTextBox";
            this.valueToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueToolStripLabel1,
            this.valueToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(740, 9);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(191, 25);
            this.fillByToolStrip1.TabIndex = 2;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // valueToolStripLabel1
            // 
            this.valueToolStripLabel1.Name = "valueToolStripLabel1";
            this.valueToolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.valueToolStripLabel1.Text = "value:";
            // 
            // valueToolStripTextBox1
            // 
            this.valueToolStripTextBox1.Name = "valueToolStripTextBox1";
            this.valueToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // fillByToolStrip2
            // 
            this.fillByToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueToolStripLabel2,
            this.valueToolStripTextBox2,
            this.fillByToolStripButton2});
            this.fillByToolStrip2.Location = new System.Drawing.Point(740, 55);
            this.fillByToolStrip2.Name = "fillByToolStrip2";
            this.fillByToolStrip2.Size = new System.Drawing.Size(191, 25);
            this.fillByToolStrip2.TabIndex = 2;
            this.fillByToolStrip2.Text = "fillByToolStrip2";
            // 
            // valueToolStripLabel2
            // 
            this.valueToolStripLabel2.Name = "valueToolStripLabel2";
            this.valueToolStripLabel2.Size = new System.Drawing.Size(38, 22);
            this.valueToolStripLabel2.Text = "value:";
            // 
            // valueToolStripTextBox2
            // 
            this.valueToolStripTextBox2.Name = "valueToolStripTextBox2";
            this.valueToolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton2
            // 
            this.fillByToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton2.Name = "fillByToolStripButton2";
            this.fillByToolStripButton2.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton2.Text = "FillBy";
            this.fillByToolStripButton2.Click += new System.EventHandler(this.fillByToolStripButton2_Click);
            // 
            // fillByToolStrip3
            // 
            this.fillByToolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valueToolStripLabel3,
            this.valueToolStripTextBox3,
            this.fillByToolStripButton3});
            this.fillByToolStrip3.Location = new System.Drawing.Point(740, 91);
            this.fillByToolStrip3.Name = "fillByToolStrip3";
            this.fillByToolStrip3.Size = new System.Drawing.Size(191, 25);
            this.fillByToolStrip3.TabIndex = 2;
            this.fillByToolStrip3.Text = "fillByToolStrip3";
            // 
            // valueToolStripLabel3
            // 
            this.valueToolStripLabel3.Name = "valueToolStripLabel3";
            this.valueToolStripLabel3.Size = new System.Drawing.Size(38, 22);
            this.valueToolStripLabel3.Text = "value:";
            // 
            // valueToolStripTextBox3
            // 
            this.valueToolStripTextBox3.Name = "valueToolStripTextBox3";
            this.valueToolStripTextBox3.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton3
            // 
            this.fillByToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton3.Name = "fillByToolStripButton3";
            this.fillByToolStripButton3.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton3.Text = "FillBy";
            this.fillByToolStripButton3.Click += new System.EventHandler(this.fillByToolStripButton3_Click);
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.bD_PlanoEnsinoDataSet;
            // 
            // bD_PlanoEnsinoDataSet
            // 
            this.bD_PlanoEnsinoDataSet.DataSetName = "BD_PlanoEnsinoDataSet";
            this.bD_PlanoEnsinoDataSet.EnforceConstraints = false;
            this.bD_PlanoEnsinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboComp
            // 
            this.comboComp.DisplayMember = "IdPlanoEnsino";
            this.comboComp.FormattingEnabled = true;
            this.comboComp.Location = new System.Drawing.Point(12, 73);
            this.comboComp.Name = "comboComp";
            this.comboComp.Size = new System.Drawing.Size(172, 21);
            this.comboComp.TabIndex = 5;
            this.comboComp.ValueMember = "IdPlanoEnsino";
            // 
            // comboCurso
            // 
            this.comboCurso.DisplayMember = "IdPlanoEnsino";
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(238, 73);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(177, 21);
            this.comboCurso.TabIndex = 6;
            this.comboCurso.ValueMember = "IdPlanoEnsino";
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPDF";
            this.Text = "FormPDF";
            this.Load += new System.EventHandler(this.FormPDF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.fillByToolStrip2.ResumeLayout(false);
            this.fillByToolStrip2.PerformLayout();
            this.fillByToolStrip3.ResumeLayout(false);
            this.fillByToolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PlanoEnsinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteCurricularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoEnsinoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.ComboBox comboProf;
        private System.Windows.Forms.Button button1;
        private BD_PlanoEnsinoDataSet bD_PlanoEnsinoDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource componenteCurricularBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.ComponenteCurricularTableAdapter componenteCurricularTableAdapter;
        private System.Windows.Forms.BindingSource planoEnsinoBindingSource;
        private BD_PlanoEnsinoDataSetTableAdapters.PlanoEnsinoTableAdapter planoEnsinoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel valueToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox valueToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel valueToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox valueToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripLabel valueToolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox valueToolStripTextBox2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton2;
        private System.Windows.Forms.ToolStrip fillByToolStrip3;
        private System.Windows.Forms.ToolStripLabel valueToolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox valueToolStripTextBox3;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton3;
        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.ComboBox comboComp;
    }
}
namespace ICS_Employee
{
    partial class ReportForm
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
            this.ICSDBDataSet = new ICS_Employee.ICSDBDataSet();
            this.vwReportAVGSalaryByPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwReportAVGSalaryByPositionTableAdapter = new ICS_Employee.ICSDBDataSetTableAdapters.vwReportAVGSalaryByPositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ICSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAVGSalaryByPositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwReportAVGSalaryByPositionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ICS_Employee.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 294);
            this.reportViewer1.TabIndex = 0;
            // 
            // ICSDBDataSet
            // 
            this.ICSDBDataSet.DataSetName = "ICSDBDataSet";
            this.ICSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwReportAVGSalaryByPositionBindingSource
            // 
            this.vwReportAVGSalaryByPositionBindingSource.DataMember = "vwReportAVGSalaryByPosition";
            this.vwReportAVGSalaryByPositionBindingSource.DataSource = this.ICSDBDataSet;
            // 
            // vwReportAVGSalaryByPositionTableAdapter
            // 
            this.vwReportAVGSalaryByPositionTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 306);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ICSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAVGSalaryByPositionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vwReportAVGSalaryByPositionBindingSource;
        private ICSDBDataSet ICSDBDataSet;
        private ICSDBDataSetTableAdapters.vwReportAVGSalaryByPositionTableAdapter vwReportAVGSalaryByPositionTableAdapter;
    }
}
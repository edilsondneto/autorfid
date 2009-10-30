namespace GravaMovDebito.Ticket
{
    partial class Ticket
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
            this.autorfidDataSet = new GravaMovDebito.autorfidDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movdebitosTableAdapter = new GravaMovDebito.autorfidDataSetTableAdapters.movdebitosTableAdapter();
            this.movdebitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autorfidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdebitosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autorfidDataSet
            // 
            this.autorfidDataSet.DataSetName = "autorfidDataSet";
            this.autorfidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "autorfidDataSet_movdebitos";
            reportDataSource1.Value = this.movdebitosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GravaMovDebito.Ticket.RepTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(470, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // movdebitosTableAdapter
            // 
            this.movdebitosTableAdapter.ClearBeforeFill = true;
            // 
            // movdebitosBindingSource
            // 
            this.movdebitosBindingSource.DataMember = "movdebitos";
            this.movdebitosBindingSource.DataSource = this.autorfidDataSet;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 365);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autorfidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdebitosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private autorfidDataSet autorfidDataSet;
        private GravaMovDebito.autorfidDataSetTableAdapters.movdebitosTableAdapter movdebitosTableAdapter;
        private System.Windows.Forms.BindingSource movdebitosBindingSource;
    }
}
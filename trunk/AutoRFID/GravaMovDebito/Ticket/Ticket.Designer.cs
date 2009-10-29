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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.autorfidDataSet = new GravaMovDebito.autorfidDataSet();
            this.autorfidDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movdebitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movdebitosTableAdapter = new GravaMovDebito.autorfidDataSetTableAdapters.movdebitosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autorfidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorfidDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdebitosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // autorfidDataSet
            // 
            this.autorfidDataSet.DataSetName = "autorfidDataSet";
            this.autorfidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorfidDataSetBindingSource
            // 
            this.autorfidDataSetBindingSource.DataSource = this.autorfidDataSet;
            this.autorfidDataSetBindingSource.Position = 0;
            // 
            // movdebitosBindingSource
            // 
            this.movdebitosBindingSource.DataMember = "movdebitos";
            this.movdebitosBindingSource.DataSource = this.autorfidDataSetBindingSource;
            // 
            // movdebitosTableAdapter
            // 
            this.movdebitosTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.autorfidDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdebitosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private autorfidDataSet autorfidDataSet;
        private System.Windows.Forms.BindingSource autorfidDataSetBindingSource;
        private System.Windows.Forms.BindingSource movdebitosBindingSource;
        private GravaMovDebito.autorfidDataSetTableAdapters.movdebitosTableAdapter movdebitosTableAdapter;
    }
}
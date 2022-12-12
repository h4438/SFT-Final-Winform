using Microsoft.Reporting.WinForms;
using RestoredModel.Model;
using RestoredModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsReportFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textLocation.Text = "C:\\Users\\PC\\Desktop";
            this.textFileName.Text = "report.doc";
        }

        public ReportDataSource createReportDataSrc<T>(string Name, List<T> data) 
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = data;
            return rds;
        }

        public void WriteReport(string exportPath, string fileName, int transactID)
        {
            DAO dao = new DAO();
            string path = exportPath + "\\" + fileName;
            // Get information
            List<AgentTransaction> agentTransactions = dao.FindAgentTransactionByOrderId(transactID);
            List<TransactionView> transactionViews = dao.CreateTransactionViews(agentTransactions);
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = "Report1.rdlc";
            // Data
            ReportDataSource rds1 = createReportDataSrc<TransactionView>("DataSet1", transactionViews);   
            localReport.DataSources.Add(rds1);
            // Write
            WriteFile(localReport, path);
        }

        public void WriteFile(LocalReport localReport, string path, string type = "WORD") 
        {
            Byte[] mybytes = localReport.Render("WORD");
            using (FileStream fs = File.Create(@path))
            {
                fs.Write(mybytes, 0, mybytes.Length);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string location = this.textLocation.Text.Trim();
            string file = this.textFileName.Text.Trim();
            int orderId = int.Parse(this.textOrderId.Text.Trim());
            WriteReport(location, file, orderId);
            MessageBox.Show("Done report!");
        }
    }
}

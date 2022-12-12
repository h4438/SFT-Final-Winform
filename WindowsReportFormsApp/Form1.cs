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
            WriteReport("C:\\Users\\PC\\Desktop", "order.doc", 1);
        }

        public ReportDataSource createReportDataSrc<T>(string Name, List<T> data) 
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = data;
            return rds;
        }

        public List<T> CreateSingleList<T>( T data) 
        {
            List<T> datas = new List<T> { data };
            return datas;
        }

        public void WriteReport(string exportPath, string fileName, int transactID)
        {
            DAO dao = new DAO();
            string path = exportPath + "\\" + fileName;
            // Get information
            List<AgentTransaction> agentTransactions = dao.FindAgentTransactionById(transactID);
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
    }
}

﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasco_Inventory_Management_Systems.ReportForm
{
    public partial class StockReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {

        }
        DataSet dst = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\CodeBase\Stock\Pasco Inventory Management Systems\Pasco Inventory Management Systems\Reports\Stock.rpt");
            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock] Where Cast (TransDate as Date) between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", con);
            sda.Fill(dst, "Stock");
            cryrpt.SetDataSource(dst);
            cryrpt.SetParameterValue("@FromDate", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            cryrpt.SetParameterValue("@ToDate", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = cryrpt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportOptions exportOptions;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf Files|*.pdf";
            sfd.Filter = "Excel|*.xls";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                diskFileDestinationOptions.DiskFileName = sfd.FileName;
            }
            exportOptions = cryrpt.ExportOptions;
            {
                exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                exportOptions.ExportFormatType = ExportFormatType.Excel;
                exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                exportOptions.ExportFormatOptions = new PdfRtfWordFormatOptions();
                exportOptions.ExportFormatOptions = new ExcelFormatOptions();
            }
            cryrpt.Export();
        }
    }
}

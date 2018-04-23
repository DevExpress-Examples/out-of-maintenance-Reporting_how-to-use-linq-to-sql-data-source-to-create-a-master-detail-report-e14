using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace LinqToSqlMasterDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NwindDataContext dc = new NwindDataContext();
            XtraReport1 report = new XtraReport1();
            BindingSource bs = (BindingSource)report.DataSource;
            bs.DataSource = dc.Orders;
            report.ShowPreviewDialog();
        }
    }
}

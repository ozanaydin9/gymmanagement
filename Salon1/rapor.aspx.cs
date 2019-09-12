using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Web;
using System.Data.Common;




namespace Salon1
{
    public partial class rapor : System.Web.UI.Page
    {
        //ReportDocument rprt = new ReportDocument();

        protected void Page_Load(object sender, EventArgs e)
        {
            //rprt.Load(Server.MapPath("~/CrystalReport2.rpt"));

            //MySqlConnection con = new MySqlConnection("server=localhost; user id=root;  password=ozan; database=salon; pooling=false");
            //MySqlCommand cmd = new MySqlCommand("select * from trainer", con);
            //MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "trainer1");
            //rprt.SetDataSource(ds);
            //CrystalReportViewer1.ReportSource = rprt;  
          

        }
    }
}
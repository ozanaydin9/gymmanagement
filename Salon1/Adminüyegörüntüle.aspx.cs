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

using System.Xml.Linq;

namespace Salon1
{
    public partial class Adminüyegörüntüle : System.Web.UI.Page
    {

        MySqlConnection conn;


        protected void Page_Load(object sender, EventArgs e)
        {
            String baglanticumlesi;

            baglanticumlesi = "server=localhost; user id=root;  password=ozan; database=salon; pooling=false";


            conn = new MySqlConnection(baglanticumlesi);
            if (!IsPostBack)
            {

                gvbind();
            }
        }
        protected void gvbind()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from user", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();


            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("delete FROM user where user_id='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];
            TextBox textName = (TextBox)row.Cells[0].Controls[0];
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];
            TextBox textc = (TextBox)row.Cells[2].Controls[0];
            TextBox texts = (TextBox)row.Cells[3].Controls[0];
            TextBox texta = (TextBox)row.Cells[4].Controls[0];
            TextBox texts5 = (TextBox)row.Cells[5].Controls[0];
            TextBox texts6 = (TextBox)row.Cells[6].Controls[0];
            TextBox texts7 = (TextBox)row.Cells[7].Controls[0];
            TextBox texts8 = (TextBox)row.Cells[8].Controls[0];
            TextBox texts9 = (TextBox)row.Cells[9].Controls[0];
            TextBox texts10 = (TextBox)row.Cells[10].Controls[0];
           

            //TextBox textadd = (TextBox)row.FindControl("txtadd");
            //TextBox textc = (TextBox)row.FindControl("txtc");
            GridView1.EditIndex = -1;
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);
            //MySqlCommand cmd = new MySqlCommand("update user set user_id='" + textName.Text + "',user_name='" + textadd.Text + "',user_age='" + textc.Text +  "',user_adress='" + texts.Text + ",user_tel='" + texta.Text + "',user_email='" + texts5.Text + "',user_pass='" + texts6.Text + "',trainer_id='" + texts7.Text + "',program_id='" + texts8.Text + "',package_id='" + texts9.Text + "',payment_id='" + texts10.Text + "'where user_id='" + u + "'", conn);
           //MySqlCommand cmd = new MySqlCommand("update user set user_id='" + textName.Text + "',user_name='" + textadd.Text + "',user_age='" + textc.Text + "',where user_id='""', conn);
            //MySqlCommand cmd = new MySqlCommand("update user set user_id='" + textName.Text + "',user_name='" + textadd.Text + "',user_age='" + textc.Text + "',user_adress='" + texts.Text + "',user_tel='" + texta.Text + "'where user_id='" + userid + "'", conn);
            MySqlCommand cmd = new MySqlCommand("update user set user_id='" + textName.Text + "',user_name='" + textadd.Text + "',user_age='" + textc.Text + "',user_adress='" + texts.Text + "',user_tel='" + texta.Text + "',user_email='" + texts5.Text + "',user_pass='" + texts6.Text + "',trainer_id='" + texts7.Text + "',program_id='" + texts8.Text + "',package_id='" + texts9.Text + "',payment_id='" + texts10.Text + "'where user_id='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
            //GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }

       
    }
}
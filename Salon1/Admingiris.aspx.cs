using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Salon1
{
    public partial class Admingiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
            
        public static MySqlConnection msc = new MySqlConnection("server=localhost; user id=root;  password=ozan; database=salon; pooling=false");
  
         public static MySqlCommand sorgu;
         public static MySqlDataReader dr;
         protected void Button1_Click(object sender, EventArgs e)
         {
             sorgu = new MySqlCommand("select gym_email,gym_pass from Gym where gym_email=@User and gym_pass=@Pass", msc);
                 sorgu.Parameters.Add("@User", MySqlDbType.VarChar).Value = TextBox1.Text;
                 sorgu.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = TextBox2.Text;
 
                  msc.Open();
                  dr = sorgu.ExecuteReader();
                     if (dr.Read())
                     {
                         Response.Redirect("~/AdminDefault.aspx");
                      }
                       else
                    {

                        Label1.Text = "Kullanıcı adı veya şifre hatalı";
                 
                    }
             dr.Close(); msc.Close();
         }

        

       
    }
}
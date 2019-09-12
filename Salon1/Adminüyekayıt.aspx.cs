using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace Salon1

{



    public partial class Adminüyekayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListiDoldur();
            }

        }



        public void DropDownListiDoldur()
        {
            string sorgu = "SELECT trainer_name from Trainer";
            DropDownList1.DataTextField = "trainer_name";
            DropDownList1.DataValueField = "trainer_name";
            DropDownList1.DataSource = DataSeteDoldur(sorgu);
            DropDownList1.DataBind();
        }
        public static DataSet DataSeteDoldur(string sorgu)
        {
            MySqlConnection baglanti = new MySqlConnection();
            String baglanticumlesi1 = "server=localhost; user id=root;  password=ozan; database=salon; pooling=false";
            MySqlCommand komut = new MySqlCommand();
            
            DataSet ds = new DataSet();
            baglanti.ConnectionString = baglanticumlesi1;
            try
            {
                
                baglanti.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                adapter.Fill(ds);
            }
            finally
            {
            baglanti.Close();
                }
            return ds;
                }


        protected void Button1_Click(object sender, EventArgs e)
        {
            



            MySqlConnection baglanti = new MySqlConnection();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand komut2 = new MySqlCommand();
            MySqlCommand komut3 = new MySqlCommand();
            MySqlCommand komut4 = new MySqlCommand();
            MySqlCommand komut5 = new MySqlCommand();
            MySqlCommand komut6 = new MySqlCommand();
            String baglanticumlesi, sorgu;
            String sorgu2;
            String sorgu3;
            //int dd=int.Parse(DropDownList1.SelectedValue);
            baglanticumlesi = "server=localhost; user id=root;  password=ozan; database=salon; pooling=false";
            baglanti.ConnectionString = baglanticumlesi;
            baglanti.Open();

            string a = DropDownList1.SelectedValue;
            String sorguid = "SELECT trainer_id FROM trainer where trainer_name='"+ a +"'";
          

            komut4.Connection = baglanti;
            komut4.CommandText = sorguid;
            komut4.CommandType = CommandType.Text;
            int trainerid = Convert.ToInt32((komut4.ExecuteScalar()));


            sorgu2 = "insert into membershippackage (package_id, package_startdate, package_finishdate, package_price) values (NULL,'" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')";
            sorgu3 = "insert into payment (payment_id, payment_date, payment_price) values (NULL,'" + TextBox10.Text + "','" + TextBox11.Text + "')";

            komut2.Connection = baglanti;
            komut2.CommandText = sorgu2;
            komut3.Connection = baglanti;
            komut3.CommandText = sorgu3;

            komut2.CommandType = CommandType.Text;
            komut3.CommandType = CommandType.Text;
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();

            String package = "SELECT max(package_id) from membershippackage";

            komut5.Connection = baglanti;
            komut5.CommandText = package;
            komut5.CommandType = CommandType.Text;
            int packageid = Convert.ToInt32((komut5.ExecuteScalar()));

            String payment = "SELECT max(payment_id) from payment";

            komut6.Connection = baglanti;
            komut6.CommandText = payment;
            komut6.CommandType = CommandType.Text;
            int paymentid = Convert.ToInt32((komut6.ExecuteScalar()));


            sorgu = "insert into User (user_id, user_name, user_age, user_adress, user_tel, user_email, user_pass,trainer_id,package_id,payment_id) values (NULL,'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "', '" + trainerid + "', '" + packageid + "', '" + paymentid + "')";
            
           
           
            komut.Connection = baglanti;
            
        
            komut.CommandText = sorgu;
           
        
            
            
            komut.CommandType = CommandType.Text;
            


          
            
            try
            {
              
                komut.ExecuteNonQuery();
               
                this.Label1.Text = "Kayıt Eklendi";
                this.Label1.Visible = true;
            }
            catch (Exception ex)
            {
                this.Label1.Visible = true;
                this.Label1.Text = "Hata Oluştu..: (" + ex.Message + ")";
            }
           
            baglanti.Close();
            baglanti = null;



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
    }

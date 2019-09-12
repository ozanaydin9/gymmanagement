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
    public partial class Adminantekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            MySqlCommand komut = new MySqlCommand();

            String baglanticumlesi, sorgu;

            baglanticumlesi = "server=localhost; user id=root;  password=ozan; database=salon; pooling=false";
            sorgu = "insert into trainer(trainer_id, trainer_name, trainer_age, trainer_tel, trainer_email, trainer_level) values (NULL,'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";

            baglanti.ConnectionString = baglanticumlesi;
            baglanti.Open();
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
    }
}
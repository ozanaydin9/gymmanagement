﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace Salon1
{
    public partial class Adminekipmanekle : System.Web.UI.Page
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
            sorgu = "insert into Equipment(equipment_id, equipment_name, equipment_price, equipment_stock) values (NULL,'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            
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
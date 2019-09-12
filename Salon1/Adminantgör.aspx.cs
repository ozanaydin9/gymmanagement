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
    public partial class Adminantgör : System.Web.UI.Page
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        protected void Page_Load(object sender, EventArgs e)
        {
            baglantifonk();//sayfa yüklendiğinde gridview dolsun
            if (!Page.IsPostBack)
            {

                GridView1.ShowFooter = true;//yeni ekle satırı görünsün,ileride dolacak
                gridviewdoldur();
            }

        }

        protected void baglantifonk()//programı sadeleştirmek için MySQL bağlantı kodlarını fonksiyon olarak yazdık.
        {


            String baglanticumlesi;

            baglanticumlesi = "server=localhost; user id=root;  password=ozan; database=salon; pooling=false";


            baglanti = new MySqlConnection(baglanticumlesi);
            baglanti.Open();
        }

        protected void gridviewdoldur()//programı sadeleştirmek için gridview doldurma kodlarını fonksiyon olarak yazdık.
        {
            String sorgu = "SELECT * from trainer";
            // String sorgu = "SELECT user_id, user_name, user_age, user_adress, user_tel, user_email, user_pass, program_id, package_id from user and select trainer_name from trainer";
            MySqlDataReader dtReader;
            komut = new MySqlCommand(sorgu, baglanti);
            dtReader = komut.ExecuteReader();

            GridView1.DataSource = dtReader;
            GridView1.DataBind();


            dtReader.Close();
            dtReader = null;

        }
        protected void Page_UnLoad()
        {
            baglanti.Close();//Sayfa kapatıldığında MySQL bağlantısını sonlandır
            baglanti = null;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salon1
{
    public partial class Uyegiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserDefault.aspx", true);
        }
    }
}
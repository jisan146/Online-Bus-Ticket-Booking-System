using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO.Ports;
using System.Threading;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TextBox1.Text = Request.QueryString["a"];
        
            TextBox3.Text = Request.QueryString["b"];
            if (Session["reset"] != null) { Button1.Enabled = true; } else {  }
            if (Session["e"] != null) { Button1.Enabled = true; } else { Response.Redirect("home.aspx"); }
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["e"].ToString() == TextBox3.Text)
            {
                if (TextBox2.Text.Length > 5)
                {
                    SqlConnection con1z = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda1z = new SqlDataAdapter("update login_table set reset_code='',log_password='" + TextBox2.Text + "' where login_id='" + TextBox1.Text + "' and reset_code='" + TextBox3.Text + "'", con1z);
                    DataTable dt1z = new DataTable();
                    sda1z.Fill(dt1z);
                }
                Response.Redirect("home.aspx");
            }
            else { msgbox("reset code not match"); }
        }
    }
}
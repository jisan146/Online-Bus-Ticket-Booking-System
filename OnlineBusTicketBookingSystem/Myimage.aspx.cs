using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Myimage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {

                Class1 ssjk = new Class1();
                ssjk.login_id = Session["ID"].ToString();
                if (ssjk.QueryInlogin13()) { Session["f"] = ssjk.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                SqlConnection conjk = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sdajk = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", conjk);
                DataTable dtjk = new DataTable();
                sdajk.Fill(dtjk);
            }
          
            Image1.ImageUrl = Session["image"].ToString();
            string Path = Server.MapPath(Image1.ImageUrl);
            System.Drawing.Bitmap img = new System.Drawing.Bitmap(Path);

            int height = img.Height;
            int width = img.Width;
            TextBox1.Text = height.ToString();
            TextBox2.Text = width.ToString();
            int a, b;
            a = int.Parse(TextBox1.Text);
            b = int.Parse(TextBox2.Text);
            if (a < b) { Panel1.CssClass = "style1"; } else { Panel1.CssClass = "style2"; }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
        }
    }
}
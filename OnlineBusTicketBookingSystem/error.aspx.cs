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
    public partial class add : System.Web.UI.Page
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
            else { Response.Redirect("home.aspx"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?"+"Driver");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?" + "Helper");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?" + "Counter_Stuff");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mybus.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("counter.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }

                SqlConnection convbb = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sdavbb = new SqlDataAdapter("update login_table set e_h='1',l='1' where login_id='" + Session["ID"].ToString() + "'", convbb);
                DataTable dtvbb = new DataTable();
                sdavbb.Fill(dtvbb);
            }
        }
    }
}
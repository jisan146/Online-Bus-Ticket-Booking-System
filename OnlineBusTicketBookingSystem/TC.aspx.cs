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
    public partial class WebForm1 : System.Web.UI.Page
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
            if (Session["ID"] != null)
            { Button1.Visible = true; }
            else { Response.Redirect("home.aspx"); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Class1 ss = new Class1();
                ss.login_id = Session["ID"].ToString();
                if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
                if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
            }
            if (TextBox2.Text.StartsWith("p")||TextBox2.Text.StartsWith("P"))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from ticket,pessenger_id where ticket.pessenger_id=pessenger_id.pessenger_id and sl='" + TextBox1.Text + "' and ticket.pessenger_id='" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (TextBox2.Text.StartsWith("c")||TextBox2.Text.StartsWith("C")||TextBox2.Text.StartsWith("H")||TextBox2.Text.StartsWith("h")||TextBox2.Text.StartsWith("d")||TextBox2.Text.StartsWith("D"))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from ticket,stuff_ where ticket.pessenger_id=stuff_.stuff_id and sl='" + TextBox1.Text + "'and ticket.pessenger_id='" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (TextBox2.Text.StartsWith("w")||TextBox2.Text.StartsWith("W"))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from ticket,b_owner where ticket.pessenger_id=b_owner.owner_id and sl='" + TextBox1.Text + "'and ticket.pessenger_id='" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (TextBox2.Text.StartsWith("g")||TextBox2.Text.StartsWith("G"))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from ticket,gov where ticket.pessenger_id=gov.stuff_id and sl='" + TextBox1.Text + "'and ticket.pessenger_id='" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (TextBox2.Text.StartsWith("a") || TextBox2.Text.StartsWith("A"))
            {
                SqlConnection con1 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda1 = new SqlDataAdapter("select *from ticket,administrator where ticket.pessenger_id=administrator.admin_id and sl='" + TextBox1.Text + "'and ticket.pessenger_id='" + TextBox2.Text + "'", con1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
           
           
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
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
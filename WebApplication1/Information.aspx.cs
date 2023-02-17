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
    public partial class Information : System.Web.UI.Page
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
            string ss = "";
            if (Session["ID"] != null)
            {
                TextBox14.Text = Session["ID"].ToString();
                ss = Session["t"].ToString();


            }
            else { Response.Redirect("home.aspx"); }
            if (ss == "Gov.Stuff")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Stuff_id,l_approved.Bus_License_no,Approved,A_Date as Approved_Date,Fitness,Tex_year,TEX,Bus_information.Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity from L_approved ,bus_information where L_approved.Bus_License_no=bus_information.Bus_License_no ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               Repeater3.DataSource = dt;
               Repeater3.DataBind();
                Button1.Enabled = true;
                Button2.Enabled = true;
                Button3.Enabled = true;
                Button4.Enabled = true;
                Button5.Enabled = true;
            }
          
        }
        private void msgbox(string msg) { ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "CallMyFunction", "alert('" + msg + "')", true); }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Class1 d = new Class1();
            d.Bus_License_no = TextBox1.Text;
            d.Bus_no = TextBox2.Text;
            d.Bus_Name = TextBox3.Text;
            d.Bus_type = TextBox4.Text;
            d.Total_Sit = TextBox5.Text;
            d.Total_Stand_Capacity = TextBox6.Text;
            if (d.DataSaveInbus_infoormation()) { }
            Class1 a = new Class1();
            a.Stuff_id = TextBox14.Text;
            a.Bus_License_no = TextBox1.Text;
            a.Approved = "Register Only";
            a.A_Date = "Register Only";
            a.Fitness = "Register Only";
            a.Tex_year = "Register Only";
            a.Tex = "Register Only";
            if(a.DataSaveInl_a()){}
            Class1 dd = new Class1();
            dd.Owner_id = TextBox7.Text;
            dd.Bus_License_no = TextBox1.Text;
            if (dd.DataSaveInhave())
            {
                Class1 dd1 = new Class1();
                dd1.Road_no = TextBox34.Text;
                dd1.Bus_License_no = TextBox1.Text;
                if (dd1.DataSaveInrate()) { }
                msgbox("sucessfull");

                Response.Redirect("Information.aspx");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
            } else { msgbox("fail"); }

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* GridViewRow row = GridView2.SelectedRow;
           TextBox1.Text = row.Cells[1].Text;
           TextBox2.Text = row.Cells[3].Text;
           TextBox3.Text = row.Cells[4].Text;
           TextBox4.Text = row.Cells[5].Text;
           TextBox5.Text = row.Cells[6].Text;
           TextBox6.Text = row.Cells[7].Text;
           TextBox7.Text = row.Cells[9].Text;*/
        }

        protected void GridView2_SelectedIndexChanged1(object sender, EventArgs e)
        {
           /* GridViewRow row = GridView2.SelectedRow;
            TextBox1.Text = row.Cells[2].Text;
            TextBox2.Text = row.Cells[9].Text;
            TextBox3.Text = row.Cells[10].Text;
            TextBox4.Text = row.Cells[11].Text;
            TextBox5.Text = row.Cells[12].Text;
            TextBox6.Text = row.Cells[13].Text;
            //TextBox7.Text = row.Cells[14].Text;
            TextBox8.Text = row.Cells[2].Text;
            TextBox9.Text = row.Cells[3].Text;
            TextBox10.Text = row.Cells[4].Text;
            TextBox11.Text = row.Cells[5].Text;
            TextBox12.Text = row.Cells[6].Text;
            TextBox13.Text = row.Cells[7].Text;
            Class1 d = new Class1();
            d.Bus_License_no = TextBox1.Text;
            if (d.QueryInhave()) { TextBox7.Text = d.Owner_id; }*/
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select Stuff_id,l_approved.Bus_License_no,Approved,A_Date as Approved_Date,Fitness,Tex_year,TEX,Bus_information.Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity from L_approved ,bus_information where L_approved.Bus_License_no=bus_information.Bus_License_no and L_approved.Bus_License_no='" + TextBox1.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater3.DataSource = dt;
            Repeater3.DataBind();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Class1 dd1 = new Class1();
            dd1.Road_no = TextBox34.Text;
            dd1.Bus_License_no = TextBox1.Text;
            if (dd1.DataSaveInrate()) { }
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update rate set rate='"+TextBox34.Text+"' where bus_id='"+TextBox1.Text+"'  update bus_information set Bus_no='" + TextBox2.Text + "', Bus_Name='" + TextBox3.Text + "',Bus_type='" + TextBox4.Text + "',Total_Sit='" + TextBox5.Text + "',Total_Stand_Capacity='" + TextBox6.Text + "' where Bus_License_no='" + TextBox1.Text + "' update have set Owner_id='" + TextBox7.Text + "' where Bus_License_no='" + TextBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            Response.Redirect("Information.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("user.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            Response.Redirect("Information.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            if (TextBox11.Text != "" || TextBox12.Text != "" || TextBox13.Text != "") 
            {
                if (TextBox11.Text =="y" || TextBox11.Text=="n")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda = new SqlDataAdapter("update L_approved set Stuff_id='" + TextBox14.Text + "',Approved='Approved',A_Date='" + DateTime.Now.ToString("hh:mm tt dd MMM yyyy") + "',Fitness='" + TextBox11.Text + "',Tex_year='" + TextBox12.Text + "',Tex='" + TextBox13.Text + "' where Bus_License_no='" + TextBox1.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Response.Redirect("Information.aspx");
                }
                else { msgbox("Fitness field only contain y or n"); }
            }
            else{msgbox("Compleate all field");}
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
              
            SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("update L_approved set Approved='Cancel' where Tex_year!='"+ DateTime.Now.ToString("yyyy") +"' or Fitness='n'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Response.Redirect("Information.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bus_stop.aspx");
        }

        protected void Repeater3_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda = new SqlDataAdapter("select Stuff_id,l_approved.Bus_License_no,Approved,A_Date as Approved_Date,Fitness,Tex_year,TEX,Bus_information.Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity from L_approved ,bus_information where L_approved.Bus_License_no=bus_information.Bus_License_no and L_approved.Bus_License_no='" + TextBox1.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater3.DataSource = dt;
                Repeater3.DataBind();
            }
           
            int rowid = (e.Item.ItemIndex);
            TextBox t1 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox25") as TextBox;
            TextBox t2 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox26") as TextBox;
            TextBox t3 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox27") as TextBox;
            TextBox t4 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox28") as TextBox;
            TextBox t5 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox29") as TextBox;
            TextBox t6 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox30") as TextBox;
            TextBox t7 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox31") as TextBox;
            TextBox t9 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox32") as TextBox;
            TextBox t10 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox33") as TextBox;
            TextBox t11 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox15") as TextBox;
            TextBox t12 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox16") as TextBox;
            TextBox t13 = (TextBox)Repeater3.Items[rowid].FindControl("TextBox17") as TextBox;
           

          
            TextBox1.Text = t2.Text;
            TextBox2.Text = t9.Text;
            TextBox3.Text = t10.Text;
            TextBox4.Text =t11.Text;
            TextBox5.Text = t12.Text;
            TextBox6.Text = t13.Text;
            //TextBox7.Text = row.Cells[14].Text;
            TextBox8.Text = t2.Text;
            TextBox9.Text = t3.Text;
            TextBox10.Text = t4.Text;
            TextBox11.Text = t5.Text;
            TextBox12.Text = t6.Text;
            TextBox13.Text = t7.Text;
            Class1 d = new Class1();
            d.Bus_License_no = TextBox1.Text;
            if (d.QueryInhave()) { TextBox7.Text = d.Owner_id; }
            Class1 d1 = new Class1();
            d1.Bus_License_no = TextBox1.Text;
            if (d1.QueryInrate()) { TextBox34.Text = d1.s_no; }
          /*  TextBox1.Text = row.Cells[2].Text;
            TextBox2.Text = row.Cells[9].Text;
            TextBox3.Text = row.Cells[10].Text;
            TextBox4.Text = row.Cells[11].Text;
            TextBox5.Text = row.Cells[12].Text;
            TextBox6.Text = row.Cells[13].Text;
            //TextBox7.Text = row.Cells[14].Text;
            TextBox8.Text = row.Cells[2].Text;
            TextBox9.Text = row.Cells[3].Text;
            TextBox10.Text = row.Cells[4].Text;
            TextBox11.Text = row.Cells[5].Text;
            TextBox12.Text = row.Cells[6].Text;
            TextBox13.Text = row.Cells[7].Text;*/
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Class1 ss = new Class1();
            ss.login_id = Session["ID"].ToString();
            if (ss.QueryInlogin13()) { Session["f"] = ss.log_type; }
            if (Session["f"].ToString() == "c" || Session["f"].ToString() == "C") { Session.RemoveAll(); Response.Redirect("home.aspx"); }
               
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
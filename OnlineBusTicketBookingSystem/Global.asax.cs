using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        System.Timers.Timer timScheduledTask1 = new System.Timers.Timer();
        System.Timers.Timer timScheduledTask2 = new System.Timers.Timer();
        System.Timers.Timer timScheduledTask3 = new System.Timers.Timer();
        System.Timers.Timer timScheduledTask4 = new System.Timers.Timer();
        protected void Application_Start(object sender, EventArgs e)
        {
            /*// Dynamically create new timer
            System.Timers.Timer timScheduledTask = new System.Timers.Timer();
            // Timer interval is set in miliseconds,
            // In this case, we'll run a task every minute
            timScheduledTask.Interval = 60 * 1000;
            timScheduledTask.Enabled = true;
            // Add handler for Elapsed event
            timScheduledTask.Elapsed +=
            new System.Timers.ElapsedEventHandler(timScheduledTask_Elapsed);
            timScheduledTask.Stop();
            timScheduledTask.Start();*/


            timScheduledTask1.Interval = 4000;
            timScheduledTask1.Enabled = true;
            timScheduledTask1.Elapsed +=
            new System.Timers.ElapsedEventHandler(timScheduledTask_Elapsed1);
          //  timScheduledTask1.Stop();
          //  timScheduledTask1.Start();


            timScheduledTask2.Interval = 6000;
            timScheduledTask2.Enabled = true;
            timScheduledTask2.Elapsed +=
            new System.Timers.ElapsedEventHandler(timScheduledTask_Elapsed2);
          //  timScheduledTask2.Stop();
          //  timScheduledTask2.Start();


            timScheduledTask3.Interval = 1000;
            timScheduledTask3.Enabled = true;
            timScheduledTask3.Elapsed +=
            new System.Timers.ElapsedEventHandler(timScheduledTask_Elapsed3);
          //  timScheduledTask3.Stop();
          //  timScheduledTask3.Start();


            timScheduledTask4.Interval = 5000;
            timScheduledTask4.Enabled = true;
            timScheduledTask4.Elapsed +=
            new System.Timers.ElapsedEventHandler(timScheduledTask_Elapsed4);
           // timScheduledTask4.Stop();
           // timScheduledTask4.Start();




        }
        void timScheduledTask_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {

            try
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update login_table set e_h='0' where l='1'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);

                timScheduledTask1.Stop();
                timScheduledTask2.Start();
            }
            catch
            {



            }
        }
        void timScheduledTask_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {

            try
            {
                SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                SqlDataAdapter sda11 = new SqlDataAdapter("update login_table set l='0' where e_h='0'", con11);
                DataTable dt11 = new DataTable();
                sda11.Fill(dt11);

                timScheduledTask2.Stop();
                timScheduledTask1.Start();
            }
            catch
            {
            }

        }
        void timScheduledTask_Elapsed3(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                float a, b; string s;
                a = float.Parse(DateTime.Now.ToString("hh.mm"));
                b = float.Parse(DateTime.Now.ToString("hh.mm"));
                s = DateTime.Now.ToString("tt");
                if (a >= 12.05 && b <= 12.30 && s == "AM")
                {

                    SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
                    SqlDataAdapter sda11 = new SqlDataAdapter("update time_schedule set Pass=''  delete from b_status update gps set latitude='',longitude=''   ", con11);
                    DataTable dt11 = new DataTable();
                    sda11.Fill(dt11);
                }
            }
            catch
            {

            }

        }
        void timScheduledTask_Elapsed4(object sender, System.Timers.ElapsedEventArgs e)
        {
            SqlConnection con11 = new SqlConnection(Properties.Settings.Default._ConnectionString);
            SqlDataAdapter sda11 = new SqlDataAdapter("update L_approved set g='off'  ", con11);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);

        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
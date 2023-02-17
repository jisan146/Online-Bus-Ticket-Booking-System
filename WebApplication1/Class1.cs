using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class Class1
    {
        private SqlConnection con;
        public Class1()
        {
            con = new SqlConnection(Properties.Settings.Default._ConnectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        
        private string _admin_id;
        private string _Pessenger_id;
        private string _Name;
        private string _picture;
        private string _Contact_number;
        private string _Emargency_contact_No;
        private string _Email_id;
        private string _Current_address;
        private string _Permanent_address;
        private string _Country;
        private string _DOB;
        private string _login_id;
        private string _log_password;
        private string _log_type;
        private string _s_no;
        private string _Stuff_id;
        private string _Owner_id;
        private string _Stuff_Type;
        private string _Register_date;
        private string _Bus_License_no;
        private string _Bus_no;
        private string _Bus_Name;
        private string _Bus_type;
        private string _Total_Sit;
        private string _Total_Stand_Capacity;
        private string _Approved;
        private string _A_Date;
        private string _Fitness;
        private string _Tex_year;
        private string _Tex;
        private string _Bus_Stop_point;
        private string _Location;
        private string _Road_no;
        private string _Road_name;
        private string _Date;
        private string _KM;
        private string _stop_time;
        private string _Current_location;
        private string _Time_delay;
        private string _pass;
        private string _Taka;

        private string _SL;
        private string _Travel_date;
        private string _Start_location;
        private string _End_location;
        private string _Sit_no;
        private string _ss_n;
        private string _es_n;
        private string _date;
        private string _paid;
        private string _ID;
        private string _Transfer_To;
        private string _vcode;

        public string vcode
        {
            get
            {
                return _vcode;
            }

            set
            {
                _vcode = value;
            }
        }
        public string ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }
        public string Transfer_To
        {
            get
            {
                return _Transfer_To;
            }

            set
            {
                _Transfer_To = value;
            }
        }
        public string es_n
        {
            get
            {
                return _es_n;
            }

            set
            {
                _es_n = value;
            }
        }
        public string ss_n
        {
            get
            {
                return _ss_n;
            }

            set
            {
                _ss_n = value;
            }
        }
        public string SL
        {
            get
            {
                return _SL;
            }

            set
            {
                _SL = value;
            }
        }
        public string Travel_date
        {
            get
            {
                return _Travel_date;
            }

            set
            {
                _Travel_date = value;
            }
        }
        public string Start_location
        {
            get
            {
                return _Start_location;
            }

            set
            {
                _Start_location = value;
            }
        }
        public string End_location
        {
            get
            {
                return _End_location;
            }

            set
            {
                _End_location = value;
            }
        }
        public string Sit_no
        {
            get
            {
                return _Sit_no;
            }

            set
            {
                _Sit_no = value;
            }
        }
        public string Taka
        {
            get
            {
                return _Taka;
            }

            set
            {
                _Taka= value;
            }
        }
        public string pass
        {
            get
            {
                return _pass;
            }

            set
            {
                _pass = value;
            }
        }
        public string Time_delay
        {
            get
            {
                return _Time_delay;
            }

            set
            {
                _Time_delay = value;
            }
        }
        public string Current_location
        {
            get
            {
                return _Current_location;
            }

            set
            {
                _Current_location = value;
            }
        }
        public string stop_time
        {
            get
            {
                return _stop_time;
            }

            set
            {
                _stop_time = value;
            }
        }
        public string KM
        {
            get
            {
                return _KM;
            }

            set
            {
                _KM = value;
            }
        }
        public string Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }
        public string Bus_Stop_point
        {
            get
            {
                return _Bus_Stop_point;
            }

            set
            {
                _Bus_Stop_point = value;
            }
        }
        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }
        public string Road_no
        {
            get
            {
                return _Road_no;
            }

            set
            {
                _Road_no = value;
            }
        }
        public string Road_name
        {
            get
            {
                return _Road_name;
            }

            set
            {
                _Road_name = value;
            }
        }

        public string Approved
        {
            get
            {
                return _Approved;
            }

            set
            {
                _Approved = value;
            }
        }
        public string A_Date
        {
            get
            {
                return _A_Date;
            }

            set
            {
                _A_Date = value;
            }
        }
        public string Fitness
        {
            get
            {
                return _Fitness;
            }

            set
            {
                _Fitness = value;
            }
        }
        public string Tex_year
        {
            get
            {
                return _Tex_year;
            }

            set
            {
                _Tex_year = value;
            }
        }
        public string Tex
        {
            get
            {
                return _Tex;
            }

            set
            {
                _Tex = value;
            }
        }
        public string Total_Sit
        {
            get
            {
                return _Total_Sit;
            }

            set
            {
                _Total_Sit = value;
            }
        }
        public string Total_Stand_Capacity
        {
            get
            {
                return _Total_Stand_Capacity;
            }

            set
            {
                _Total_Stand_Capacity = value;
            }
        }
        public string Bus_type
        {
            get
            {
                return _Bus_type;
            }

            set
            {
                _Bus_type = value;
            }
        }
        public string Bus_Name
        {
            get
            {
                return _Bus_Name;
            }

            set
            {
                _Bus_Name = value;
            }
        }
        public string Bus_no
        {
            get
            {
                return _Bus_no;
            }

            set
            {
                _Bus_no = value;
            }
        }
        public string Bus_License_no
        {
            get
            {
                return _Bus_License_no;
            }

            set
            {
                _Bus_License_no = value;
            }
        }
        public string Register_date
        {
            get
            {
                return _Register_date;
            }

            set
            {
                _Register_date = value;
            }
        }

        public string Stuff_Type
        {
            get
            {
                return _Stuff_Type;
            }

            set
            {
                _Stuff_Type = value;
            }
        }
        public string Owner_id
        {
            get
            {
                return _Owner_id;
            }

            set
            {
                _Owner_id = value;
            }
        }
        public string Stuff_id
        {
            get
            {
                return _Stuff_id;
            }

            set
            {
                _Stuff_id = value;
            }
        }
        public string admin_id
        {
            get
            {
                return _admin_id;
            }

            set
            {
                _admin_id = value;
            }
        }
        public string s_no
        {
            get
            {
                return _s_no;
            }

            set
            {
                _s_no = value;
            }
        }
        public string log_type
        {
            get
            {
                return _log_type;
            }

            set
            {
                _log_type = value;
            }
        }
        public string log_password
        {
            get
            {
                return _log_password;
            }

            set
            {
                _log_password = value;
            }
        }
        public string login_id
        {
            get
            {
                return _login_id;
            }

            set
            {
                _login_id = value;
            }
        }
        public string DOB
        {
            get
            {
                return _DOB;
            }

            set
            {
                _DOB = value;
            }
        }
        public string Country
        {
            get
            {
                return _Country;
            }

            set
            {
                _Country = value;
            }
        }
        public string Permanent_address
        {
            get
            {
                return _Permanent_address;
            }

            set
            {
                _Permanent_address = value;
            }
        }
        public string Current_address
        {
            get
            {
                return _Current_address;
            }

            set
            {
                _Current_address = value;
            }
        }
        public string Email_id
        {
            get
            {
                return _Email_id;
            }

            set
            {
                _Email_id = value;
            }
        }
        public string Emargency_contact_No
        {
            get
            {
                return _Emargency_contact_No;
            }

            set
            {
                _Emargency_contact_No = value;
            }
        }
        public string Contact_number
        {
            get
            {
                return _Contact_number;
            }

            set
            {
                _Contact_number = value;
            }
        }
        public string picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }
        public string Pessenger_id
        {
            get
            {
                return _Pessenger_id;
            }

            set
            {
                _Pessenger_id = value;
            }
        }

        public bool DataSaveInowner()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into b_owner (Owner_id,Name,picture,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,Country,DOB)values(@Owner_id,@Name,@picture,@Contact_number,@Emargency_contact_No,@Email_id,@Current_address,@Permanent_address,@Country,@DOB)";
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);
            cmd.Parameters.AddWithValue("@Name", _Name);
            cmd.Parameters.AddWithValue("@picture", _picture);
            cmd.Parameters.AddWithValue("@Contact_number", _Contact_number);
            cmd.Parameters.AddWithValue("@Emargency_contact_No", _Emargency_contact_No);
            cmd.Parameters.AddWithValue("@Email_id", _Email_id);
            cmd.Parameters.AddWithValue("@Current_address", _Current_address);
            cmd.Parameters.AddWithValue("@Permanent_address", _Permanent_address);
            cmd.Parameters.AddWithValue("@Country", _Country);
            cmd.Parameters.AddWithValue("@DOB", _DOB);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInbs()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into stop_office (Bus_Stop_point,Road_no,Road_name,Location,login_id,Approved)values(@Bus_Stop_point,@Road_no,@Road_name,@Location,@login_id,@Approved)";
            cmd.Parameters.AddWithValue("@Bus_Stop_point", _Bus_Stop_point);
            cmd.Parameters.AddWithValue("@Road_no",_Road_no );
            cmd.Parameters.AddWithValue("@Road_name",_Road_name );
            cmd.Parameters.AddWithValue("@Location",_Location );
            cmd.Parameters.AddWithValue("@login_id", _login_id);
            cmd.Parameters.AddWithValue("@Approved", _Approved);
           


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInrate()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into rate (Bus_ID,rate)values(@Bus_License_no,@Road_no)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Road_no", _Road_no);
          


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveIngps()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into GPS(id,Latitude,Longitude,Description)values(@Bus_License_no,@Start_location,@End_location,@DOB)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Start_location", _Start_location);
            cmd.Parameters.AddWithValue("@End_location", _End_location);
            cmd.Parameters.AddWithValue("@DOB", _DOB);




            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInhis()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into history (ID,Transfer_To,Taka,Date)values(@ID,@Transfer_To,@Taka,@Date)";
            cmd.Parameters.AddWithValue("@ID ", _ID);
            cmd.Parameters.AddWithValue("@Transfer_To", _Transfer_To);
            cmd.Parameters.AddWithValue("@Taka", _Taka);
            cmd.Parameters.AddWithValue("@Date", _Date);
           


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInbala()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into balance (Owner_id,Taka)values(@Owner_id,@Taka)";
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);
            
            cmd.Parameters.AddWithValue("@Taka", _Taka);
          



            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInselect()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into select_ (Bus_Stop_point,Date,Stuff_id)values(@Bus_Stop_point,@Date,@Stuff_id)";
            cmd.Parameters.AddWithValue("@Bus_Stop_point", _Bus_Stop_point);
            cmd.Parameters.AddWithValue("@Date", _Date);
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            
           


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInst()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into time_schedule (Bus_License_no,Bus_Stop_point,stop_time,Stuff_id,KM,pass)values(@Bus_License_no,@Bus_Stop_point,@stop_time,@Stuff_id,@KM,@pass)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Bus_Stop_point", _Bus_Stop_point);
            cmd.Parameters.AddWithValue("@stop_time", _stop_time);
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@KM", _KM);
            cmd.Parameters.AddWithValue("@pass", _pass);




            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInbhas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into b_has (Bus_Stop_point,Bus_License_no,Stuff_id,s_no,KM)values(@Bus_Stop_point,@Bus_License_no,@Stuff_id,@s_no,@KM)";
            cmd.Parameters.AddWithValue("@Bus_Stop_point", _Bus_Stop_point);
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@s_no", _s_no);
            cmd.Parameters.AddWithValue("@KM", _KM);



            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInstuff()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into stuff_ (Stuff_id,Name,picture,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,Country,DOB,Stuff_Type)values(@Stuff_id,@Name,@picture,@Contact_number,@Emargency_contact_No,@Email_id,@Current_address,@Permanent_address,@Country,@DOB,@Stuff_Type)";
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@Name", _Name);
            cmd.Parameters.AddWithValue("@picture", _picture);
            cmd.Parameters.AddWithValue("@Contact_number", _Contact_number);
            cmd.Parameters.AddWithValue("@Emargency_contact_No", _Emargency_contact_No);
            cmd.Parameters.AddWithValue("@Email_id", _Email_id);
            cmd.Parameters.AddWithValue("@Current_address", _Current_address);
            cmd.Parameters.AddWithValue("@Permanent_address", _Permanent_address);
            cmd.Parameters.AddWithValue("@Country", _Country);
            cmd.Parameters.AddWithValue("@DOB", _DOB);
            cmd.Parameters.AddWithValue("@Stuff_Type", _Stuff_Type);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInGov()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into gov (Stuff_id,Name,picture,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,Country,DOB)values(@Stuff_id,@Name,@picture,@Contact_number,@Emargency_contact_No,@Email_id,@Current_address,@Permanent_address,@Country,@DOB)";
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@Name", _Name);
            cmd.Parameters.AddWithValue("@picture", _picture);
            cmd.Parameters.AddWithValue("@Contact_number", _Contact_number);
            cmd.Parameters.AddWithValue("@Emargency_contact_No", _Emargency_contact_No);
            cmd.Parameters.AddWithValue("@Email_id", _Email_id);
            cmd.Parameters.AddWithValue("@Current_address", _Current_address);
            cmd.Parameters.AddWithValue("@Permanent_address", _Permanent_address);
            cmd.Parameters.AddWithValue("@Country", _Country);
            cmd.Parameters.AddWithValue("@DOB", _DOB);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
       

        public bool DataSaveInadmin()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into administrator(admin_id,Name,picture,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,Country,DOB)values(@admin_id,@Name,@picture,@Contact_number,@Emargency_contact_No,@Email_id,@Current_address,@Permanent_address,@Country,@DOB)";
            cmd.Parameters.AddWithValue("@admin_id", _admin_id);
            cmd.Parameters.AddWithValue("@Name", _Name);
            cmd.Parameters.AddWithValue("@picture", _picture);
            cmd.Parameters.AddWithValue("@Contact_number", _Contact_number);
            cmd.Parameters.AddWithValue("@Emargency_contact_No", _Emargency_contact_No);
            cmd.Parameters.AddWithValue("@Email_id", _Email_id);
            cmd.Parameters.AddWithValue("@Current_address", _Current_address);
            cmd.Parameters.AddWithValue("@Permanent_address", _Permanent_address);
            cmd.Parameters.AddWithValue("@Country", _Country);
            cmd.Parameters.AddWithValue("@DOB", _DOB);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInpassenger()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into pessenger_id(Pessenger_id,Name,picture,Contact_number,Emargency_contact_No,Email_id,Current_address,Permanent_address,Country,DOB)values(@Pessenger_id,@Name,@picture,@Contact_number,@Emargency_contact_No,@Email_id,@Current_address,@Permanent_address,@Country,@DOB)";
            cmd.Parameters.AddWithValue("@Pessenger_id", _Pessenger_id);
            cmd.Parameters.AddWithValue("@Name", _Name);
            cmd.Parameters.AddWithValue("@picture", _picture);
            cmd.Parameters.AddWithValue("@Contact_number", _Contact_number);
            cmd.Parameters.AddWithValue("@Emargency_contact_No", _Emargency_contact_No);
            cmd.Parameters.AddWithValue("@Email_id", _Email_id);
            cmd.Parameters.AddWithValue("@Current_address", _Current_address);
            cmd.Parameters.AddWithValue("@Permanent_address", _Permanent_address);
            cmd.Parameters.AddWithValue("@Country", _Country);
            cmd.Parameters.AddWithValue("@DOB", _DOB);
          

            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInlogin_table()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into login_table(login_id,log_password,log_type)values(@login_id,@log_password,@log_type)";
            cmd.Parameters.AddWithValue("@login_id", _login_id);
            cmd.Parameters.AddWithValue("@log_password", _log_password);
             cmd.Parameters.AddWithValue("@log_type",_log_type );
           


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInbus_infoormation()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into bus_information(Bus_License_no,Bus_no,Bus_Name,Bus_type,Total_Sit,Total_Stand_Capacity)values(@Bus_License_no,@Bus_no,@Bus_Name,@Bus_type,@Total_Sit,@Total_Stand_Capacity)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Bus_no", _Bus_no);
            cmd.Parameters.AddWithValue("@Bus_Name", _Bus_Name);
            cmd.Parameters.AddWithValue("@Bus_type", _Bus_type);
            cmd.Parameters.AddWithValue("@Total_Sit", _Total_Sit);
            cmd.Parameters.AddWithValue("@Total_Stand_Capacity", _Total_Stand_Capacity);
            


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInl_a()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into L_approved (Stuff_id,Bus_License_no,Approved,A_Date,Fitness,Tex_year,Tex)values(@Stuff_id,@Bus_License_no,@Approved,@A_Date,@Fitness,@Tex_year,@Tex)";
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
                 cmd.Parameters.AddWithValue("@Approved", _Approved);
                 cmd.Parameters.AddWithValue("@A_Date", _A_Date);
                 cmd.Parameters.AddWithValue("@Fitness", _Fitness);
                 cmd.Parameters.AddWithValue("@Tex_year", _Tex_year);
                 cmd.Parameters.AddWithValue("@Tex", _Tex);
            



            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInhave()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into have(Bus_License_no,Owner_id)values(@Bus_License_no,@Owner_id)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);
          



            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInb_status()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into b_status(Bus_License_no,Current_location,Time_delay)values(@Bus_License_no,@Current_location,@Time_delay)";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@Current_location", _Current_location);
            cmd.Parameters.AddWithValue("@Time_delay", _Time_delay);




            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveInappoint()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into appoint(Owner_id,Stuff_id,Register_date)values(@Owner_id,@Stuff_id,@Register_date)";
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@Register_date", _Register_date);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DataSaveIncon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into control_(Stuff_id,Bus_License_no,s_no)values(@Stuff_id,@Bus_License_no,@s_no)";
           
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("@s_no",_s_no);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool QueryIncount()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count (Bus_License_no) as a from b_has where Bus_License_no=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["a"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInsum()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select sum(Taka) as Total from ticket where pessenger_id=@Pessenger_id and Travel_date=@Travel_date";
            cmd.Parameters.AddWithValue("@Pessenger_id", _Pessenger_id );
            cmd.Parameters.AddWithValue("@Travel_date", _Travel_date);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["Total"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInsumm()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from appoint where Stuff_id=@Pessenger_id";
            cmd.Parameters.AddWithValue("@Pessenger_id", _Pessenger_id);
           


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["Owner_id"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInx()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "(select b_status.Bus_License_no,Location as left_location,time_delay as Delay from b_status,stop_office,ticket where ticket.Bus_License_no=b_status.Bus_License_no  and stop_office.Bus_Stop_point=b_status.Current_location and pessenger_id=@Pessenger_id and  SL=@SL and Sit_no!='exp')intersect(select b_status.Bus_License_no,Location as left_location,time_delay as Delay from b_status,stop_office,ticket where ticket.Bus_License_no=b_status.Bus_License_no  and stop_office.Bus_Stop_point=b_status.Current_location and pessenger_id=@Pessenger_id and  SL=@SL and Sit_no!='exp')";
            cmd.Parameters.AddWithValue("@Pessenger_id", _Pessenger_id);
            cmd.Parameters.AddWithValue("@SL", _SL);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["Left_Location"].ToString();
                _Sit_no = reader["Delay"].ToString();
                _SL= reader["Bus_License_no"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryIncount1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select COUNT(Bus_Stop_point)as a from  time_schedule where  Bus_License_no=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["a"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInrate()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from rate where Bus_ID=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["rate"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInrate_()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from control_ where stuff_id=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["Bus_License_no"].ToString();
                _Road_no = reader["s_no"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool pos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "(select stop_office.Bus_Stop_point,l1,l2,l3,l4 from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Stuff_id=@login_id)intersect(select stop_office.Bus_Stop_point,l1,l2,l3,l4 from time_schedule,stop_office where time_schedule.Bus_Stop_point=stop_office.Bus_Stop_point and Stuff_id=@login_id)";
            cmd.Parameters.AddWithValue("@login_id", _login_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
              
                _s_no = reader["l1"].ToString();
                _Road_name = reader["l2"].ToString();
                _Road_no = reader["l3"].ToString();
                _Location = reader["l4"].ToString();
                    
            

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool g()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from gps where id=@login_id";
            cmd.Parameters.AddWithValue("@login_id", _login_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _s_no = reader["latitude"].ToString();
                _Road_name = reader["longitude"].ToString();
              _admin_id= reader["description"].ToString();
              


                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool DataSaveInticket()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into ticket(Bus_License_no,Pessenger_id,Travel_date,Start_location,End_location,Sit_no,KM ,Taka,ss_n,es_n,stop_time )values(@Bus_License_no,@Pessenger_id,@Travel_date,@Start_location,@End_location,@Sit_no,@KM ,@Taka,@ss_n,@es_n,@stop_time )";

            
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);
            cmd.Parameters.AddWithValue("Pessenger_id", _Pessenger_id);
            cmd.Parameters.AddWithValue("Travel_date", _Travel_date);
            cmd.Parameters.AddWithValue("Start_location", _Start_location);
            cmd.Parameters.AddWithValue("End_location", _End_location);
            cmd.Parameters.AddWithValue("Sit_no", _Sit_no);
            cmd.Parameters.AddWithValue("KM ", _KM);
            cmd.Parameters.AddWithValue("Taka ", _Taka);
            cmd.Parameters.AddWithValue("ss_n", _ss_n);
            cmd.Parameters.AddWithValue("es_n", _es_n);
            cmd.Parameters.AddWithValue("stop_time", _stop_time);


            try
            {
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool QueryInlogin()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(s_no) as s_no  from login_table -- where login_id=@login_id";
           // cmd.Parameters.AddWithValue("@login_id", _login_id);
            

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["s_no"].ToString();
               
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInlike()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Pessenger_like,Pessenger_Unlike from bus_information where Bus_License_no=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
               _Bus_no = reader["Pessenger_like"].ToString();
                _Bus_type = reader["Pessenger_Unlike"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInbala()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(sum(Taka),0)as Taka from balance where  Owner_id=@Owner_id and (select isnull(sum(taka),0)from balance where  Owner_id=@Owner_id)>0 ";
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Taka = reader["Taka"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInhist()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select SUM(Taka)as Total from history where ID=@ID and Date=@Date";
            cmd.Parameters.AddWithValue("@ID", _ID);
            cmd.Parameters.AddWithValue("@Date", _Date);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Taka = reader["Total"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInhist1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select SUM(Taka)as Total from history where Transfer_To=@Transfer_To and Date=@Date";
            cmd.Parameters.AddWithValue("@Transfer_To", _Transfer_To);
            cmd.Parameters.AddWithValue("@Date", _Date);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Taka = reader["Total"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryIntk()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Taka from Pessenger_id where Pessenger_id=@Pessenger_id";
            cmd.Parameters.AddWithValue("@Pessenger_id", _Pessenger_id);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Taka = reader["Taka"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInbi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from bus_information where Bus_License_no=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Total_Sit = reader["Total_Sit"].ToString();//Total_Stand_Capacity
                _Total_Stand_Capacity = reader["Total_Stand_Capacity"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInbhas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from b_has where Bus_Stop_point=@Bus_Stop_point and Bus_License_no=@Bus_License_no";
            cmd.Parameters.AddWithValue("@Bus_Stop_point", _Bus_Stop_point);

            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);

            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _Stuff_id = reader["Stuff_id"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInem()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count(r) s from email where r=@login_id and st='not read'";
            cmd.Parameters.AddWithValue("@login_id", _login_id);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["s"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInstop()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select MAX(s_no) as s_no from stop_office";
            // cmd.Parameters.AddWithValue("@login_id", _login_id);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                _s_no = reader["s_no"].ToString();

                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInlogin1()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login_table where login_id=@login_id and log_password=@log_password ";
             cmd.Parameters.AddWithValue("@login_id", _login_id);
             cmd.Parameters.AddWithValue("@log_password", _log_password);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _log_type = reader["log_type"].ToString();
                _vcode = reader["v_code"].ToString();
                _Bus_no = reader["l"].ToString();
                _Bus_Name = reader["t"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInlogin13()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login_table where login_id=@login_id  ";
            cmd.Parameters.AddWithValue("@login_id", _login_id);
           


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _log_type = reader["log_type"].ToString();
                _vcode = reader["v_code"].ToString();
                _Bus_no = reader["l"].ToString();
                _Bus_Name = reader["t"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInlogin2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login_table where login_id=@login_id  ";
            cmd.Parameters.AddWithValue("@login_id", _login_id);
           // cmd.Parameters.AddWithValue("@log_password", _log_password);


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _log_type = reader["log_type"].ToString();
                _vcode = reader["v_code"].ToString();
                _log_password = reader["log_password"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInlogin01()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login_table where login_id=@login_id  ";
            cmd.Parameters.AddWithValue("@login_id", _login_id);
         


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _log_type = reader["log_type"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInhave()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from have  where Bus_License_no=@Bus_License_no  ";
            cmd.Parameters.AddWithValue("@Bus_License_no", _Bus_License_no);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _Owner_id = reader["Owner_id"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
       

        public bool QueryInstuff()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from stuff_ where Stuff_id=@Stuff_id";
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _Stuff_id = reader["Stuff_id"].ToString();
                _Name = reader["Name"].ToString();
                _picture = reader["picture"].ToString();
                _Contact_number = reader["Contact_number"].ToString();
                _Emargency_contact_No = reader["Emargency_contact_No"].ToString();
                _Email_id = reader["Email_id"].ToString();
                _Current_address = reader["Current_address"].ToString();
                _Permanent_address = reader["Permanent_address"].ToString();
                _Country = reader["Country"].ToString();
                _DOB = reader["DOB"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryIngov()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from gov where Stuff_id=@Stuff_id";
            cmd.Parameters.AddWithValue("@Stuff_id", _Stuff_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _Stuff_id = reader["Stuff_id"].ToString();
                _Name = reader["Name"].ToString();
                _picture = reader["picture"].ToString();
                _Contact_number = reader["Contact_number"].ToString();
                _Emargency_contact_No = reader["Emargency_contact_No"].ToString();
                _Email_id = reader["Email_id"].ToString();
                _Current_address = reader["Current_address"].ToString();
                _Permanent_address = reader["Permanent_address"].ToString();
                _Country = reader["Country"].ToString();
                _DOB = reader["DOB"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInowner()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from b_owner where Owner_id=@Owner_id";
            cmd.Parameters.AddWithValue("@Owner_id", _Owner_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _Owner_id = reader["Owner_id"].ToString();
                _Name = reader["Name"].ToString();
                _picture = reader["picture"].ToString();
                _Contact_number = reader["Contact_number"].ToString();
                _Emargency_contact_No = reader["Emargency_contact_No"].ToString();
                _Email_id = reader["Email_id"].ToString();
                _Current_address = reader["Current_address"].ToString();
                _Permanent_address = reader["Permanent_address"].ToString();
                _Country = reader["Country"].ToString();
                _DOB = reader["DOB"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }

        public bool QueryInadmin()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from administrator where admin_id=@admin_id";
            cmd.Parameters.AddWithValue("@admin_id", _admin_id);



            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _admin_id = reader["admin_id"].ToString();
                _Name = reader["Name"].ToString();
                _picture = reader["picture"].ToString();
                _Contact_number = reader["Contact_number"].ToString();
                _Emargency_contact_No = reader["Emargency_contact_No"].ToString();
                _Email_id = reader["Email_id"].ToString();
                _Current_address = reader["Current_address"].ToString();
                _Permanent_address = reader["Permanent_address"].ToString();
                _Country = reader["Country"].ToString();
                _DOB = reader["DOB"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }
        public bool QueryInpessenger()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from pessenger_id where pessenger_id=@pessenger_id";
            cmd.Parameters.AddWithValue("@pessenger_id", _Pessenger_id);
           


            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();

                _Pessenger_id = reader["Pessenger_id"].ToString();
                _Name = reader["Name"].ToString();
                _picture = reader["picture"].ToString();
                _Contact_number = reader["Contact_number"].ToString();
                _Emargency_contact_No = reader["Emargency_contact_No"].ToString();
                _Email_id = reader["Email_id"].ToString();
                _Current_address = reader["Current_address"].ToString();
                _Permanent_address = reader["Permanent_address"].ToString();
                _Country = reader["Country"].ToString();
                _DOB = reader["DOB"].ToString();
                return true;
            }
            catch (Exception)
            {
                reader.Close();
                return false;
            }
        }

    }
}
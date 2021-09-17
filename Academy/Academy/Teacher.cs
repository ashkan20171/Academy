using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Academy
{
    class Teacher
    {
        public static string TeacherName;
        public static string FatherName;
        public static string Sex;
        public static string Tell;
        public static string Mobile;
        public static string IdCard1;
        public static string IdCard2;
        public static string Address;
        public static string Discription;
        public static string Study;
        public static string Date;
        public static byte[] Picture;
        static SqlConnection con = new SqlConnection();
        static SqlCommand com = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();
        static DataTable dt;

        private static void Connect()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch
            {
            }
        }

        private static void Disconnect()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch
            {
            }
        }

        private static void MakeConnection()
        {
            try
            {
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Academy.mdf;Integrated Security=True";
                com.Connection = con;
            }
            catch
            {
            }
        }

        public static bool _AddTeacher()
        {
            try
            {
                com.CommandText = "Select * From \"Teacher\" Where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                MakeConnection();
                da.SelectCommand = com;
                Connect();
                dt = new DataTable();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "مربی با این کد ملی وجود دارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"Teacher\" Values(@TeacherName,@FatherName,@Sex,@Study,@IdCard1,@IdCard2,@Tell,@Mobile,@Address,@Picture,@Date,@Discription)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@TeacherName",TeacherName);
                    com.Parameters.AddWithValue("@FatherName", FatherName);
                    com.Parameters.AddWithValue("@Sex", Sex);
                    com.Parameters.AddWithValue("@IdCard1", IdCard1);
                    com.Parameters.AddWithValue("@IdCard2", IdCard2);
                    com.Parameters.AddWithValue("@Tell", Tell);
                    com.Parameters.AddWithValue("@Mobile", Mobile);
                    com.Parameters.AddWithValue("@Address", Address);
                    com.Parameters.AddWithValue("@Discription", Discription);
                    com.Parameters.AddWithValue("@Picture", Picture);
                    com.Parameters.AddWithValue("@Study", Study);
                    com.Parameters.AddWithValue("@Date", Date);
                    Connect();
                    com.ExecuteNonQuery();
                    Disconnect();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable _AllStudy()
        {
            try
            {
                com.CommandText = "Select Study From \"Study\"";
                MakeConnection();
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public static DataTable _AllTeacher()
        {
            try
            {
                com.CommandText = "Select TeacherName,IdCard1,IdCard2,Picture From \"Teacher\"";
                MakeConnection();
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public static bool _DeleteTeacher(string _TeacherName)
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\" Where TeacherName=@TeacherName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@TeacherName", _TeacherName);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    DialogResult dr;
                    dr = FarsiMessageBox.MessageBox.Show("سوال", "درسی با این مربی ارائه شده است.\nآیا میخواهید مربی حذف شود؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                    if (dr == DialogResult.Yes)
                    {
                        com.CommandText = "Delete From \"Teacher\" Where TeacherName=@TeacherName";
                        Connect();
                        com.ExecuteNonQuery();
                        Disconnect();
                        return true;
                    }
                    else
                        return false;

                }
                else
                {
                    com.CommandText = "Delete From \"Teacher\" Where TeacherName=@TeacherName";
                    Connect();
                    com.ExecuteNonQuery();
                    Disconnect();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool _Search(string _IdCard1)
        {
            try
            {
                com.CommandText = "Select * From \"Teacher\" Where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("IdCard1", _IdCard1);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    TeacherName = dt.Rows[0]["TeacherName"].ToString();
                    FatherName = dt.Rows[0]["FatherName"].ToString();
                    Sex = dt.Rows[0]["Sex"].ToString();
                    IdCard1 = dt.Rows[0]["IdCard1"].ToString();
                    IdCard2 = dt.Rows[0]["IdCard2"].ToString();
                    Tell = dt.Rows[0]["Tell"].ToString();
                    Mobile = dt.Rows[0]["Mobile"].ToString();
                    Address = dt.Rows[0]["Address"].ToString();
                    Discription = dt.Rows[0]["Discription"].ToString();
                    Study = dt.Rows[0]["Study"].ToString();
                    Date = dt.Rows[0]["DateEmploy"].ToString();
                    Picture = (byte[])dt.Rows[0]["Picture"];
                    return true;
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "مربی ای با این شماره ملی وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool _UpdateTeacher(string _IdCard1)
        {
            try
            {
                com.CommandText = "Update \"Teacher\" Set TeacherName=@TeacherName , FatherName=@FatherName , Sex=@Sex ,IdCard1=@IdCard1 , IdCard2=@IdCard2 , Address=@Address , Tell=@Tell , Mobile=@Mobile, Discription=@Discription , Picture=@Picture, DateEmploy=@Date, Study=@Study Where IdCard1=@_IdCard1  ";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@TeacherName", TeacherName);
                com.Parameters.AddWithValue("@FatherName", FatherName);
                com.Parameters.AddWithValue("@Sex", Sex);
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                com.Parameters.AddWithValue("@IdCard2", IdCard2);
                com.Parameters.AddWithValue("@Tell", Tell);
                com.Parameters.AddWithValue("@Mobile", Mobile);
                com.Parameters.AddWithValue("@Address", Address);
                com.Parameters.AddWithValue("@Discription", Discription);
                com.Parameters.AddWithValue("@Picture", Picture);
                com.Parameters.AddWithValue("@_IdCard1", _IdCard1);
                com.Parameters.AddWithValue("@Study", Study);
                com.Parameters.AddWithValue("@Date", Date);
                MakeConnection();
                Connect();
                com.ExecuteNonQuery();
                Disconnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static String MiladiToShamsi(DateTime dt)
        {
            StringBuilder sb = new StringBuilder();
            PersianCalendar pc = new PersianCalendar();
            sb.Append(pc.GetYear(dt).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(dt).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(dt).ToString("00"));
            return sb.ToString();

        }
        public static String ShamsiToMiladi(string dt)
        {
            string[] _Date = dt.Split('/');
            int _Year = Convert.ToInt32(_Date[0]);
            int _Month = Convert.ToInt32(_Date[1]);
            int _Day = Convert.ToInt32(_Date[2]);
            PersianCalendar pc = new PersianCalendar();
            string Today = pc.ToDateTime(_Year, _Month, _Day, 0, 0, 0, 0).ToString().Substring(0, 9);
            return Today;
        }

        public static DataTable _All()
        {
            try
            {
                com.CommandText = "Select * From \"Teacher\"";
                MakeConnection();
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public static DataTable _SearchTeacher(string _IdCard1,string _TeacherName,string _Sex,string _Study)
        {
            try
            {
                com.CommandText = "Select * From \"Teacher\" Where IdCard1=@IdCard1 or TeacherName=@TecherName or Sex=@Sex or Study=@Study";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", _IdCard1);
                com.Parameters.AddWithValue("@TecherName", _TeacherName);
                com.Parameters.AddWithValue("@Sex", _Sex);
                com.Parameters.AddWithValue("@Study", _Study);
                MakeConnection();
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

    }
}

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
    class Selected
    {
        public static string Id;
        public static string Date;
        public static string LeesonId;
        public static string IdCard1;
        public static string Salary;
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

        public static bool _AddSelected()
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" Where IdCard1=@IdCard1 and LessonId=@LessonId and Date=@Date";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                com.Parameters.AddWithValue("@LessonId", LeesonId);
                com.Parameters.AddWithValue("@Date", Date);
                MakeConnection();
                da.SelectCommand = com;
                Connect();
                dt = new DataTable();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "این هنرجو در این تاریخ چنین درسی را اخذ کرده است.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"Selected\" Values(@IdCard1,@LessonId,@Date)";
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

        public static bool _AddPecunary()
        {
            try
            {

                MakeConnection();
                com.CommandText = "Select Max(Id) From \"Selected\"";
                Connect();
                dt = new DataTable();
                da.SelectCommand = com;
                da.Fill(dt);
                Disconnect();
                com.CommandText = "Insert Into \"Pecunary\" Values(@Id,@Salary,0,@Salary,0,@Discription)";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", dt.Rows[0][0].ToString());
                com.Parameters.AddWithValue("@Salary", Salary);
                com.Parameters.AddWithValue("@Discription", "");
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

        public static bool _SearchLessonId(string _LessonId)
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\" Where LessonId=@LessonId";
                MakeConnection();
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@LessonId", _LessonId);
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count == 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "درسی با این شناسه وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);;
                    return false;
                }
                else
                {
                    Salary = dt.Rows[0]["Salary"].ToString();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        public static bool _SearchIdCard1(string _IdCard1)
        {
            try
            {
                com.CommandText = "Select * From \"Student\" Where IdCard1=@IdCard1";
                MakeConnection();
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", _IdCard1);
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count == 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "هنرجو ای با این کد ملی وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error); ;
                    return false;
                }
                else
                {
                    return true;
                }

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
            string Today = pc.ToDateTime(_Year, _Month, _Day, 0, 0, 0, 0).ToString().Substring(0, 10);
            return Today;
        }

       // public static bool _DeletePecunary(string _Id)
        //{
        //    try
        //    {
        //        com.CommandText = "Delete From \"Pecunary\" Where Id=@Id";
        //        com.Parameters.Clear();
        //        com.Parameters.AddWithValue("@Id", _Id);
        //        MakeConnection();
        //        Connect();
        //        com.ExecuteNonQuery();
        //        Disconnect();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public static bool _DeleteSelected(string _Id)
        {
            try
            {
                com.CommandText = "Delete From \"Selected\" Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", _Id);
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

        public static DataTable _AllSelected()
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" ";
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

        public static bool _SearchSelected(string _Id)
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", _Id);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count == 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "درس اخذ شده با این سناسه وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    LeesonId = dt.Rows[0]["LessonId"].ToString();
                    IdCard1 = dt.Rows[0]["IdCard1"].ToString();
                    Date = dt.Rows[0]["Date"].ToString();
                    Id = _Id;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool _UpdateSelected()
        {
            try
            {
                com.CommandText = "Update \"Selected\" set IdCard1=@IdCard1 , LessonId=@LessonId , Date=@Date Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                com.Parameters.AddWithValue("@LessonId", LeesonId);
                com.Parameters.AddWithValue("@Date", Date);
                com.Parameters.AddWithValue("@Id", Id);
                MakeConnection();
                Connect();
                com.ExecuteNonQuery();
                Disconnect();
                //com.CommandText = "Update \"Pecunary\" set Salary=@Salary Where Id=@Id";
                //Connect();
                //com.ExecuteNonQuery();
                //Disconnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable _SearchSe(string _st)
        {
            try
            {
                com.CommandText = "Select IdCard1 as [IDCARD1], count(IdCard1) as [COUNT]  From \"Selected\" group by [IdCard1] order by [COUNT] "+_st;
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


        public static string _SearchStName(string _IdCard1)
        {
            try
            {
                com.CommandText = "Select StudentName  From \"Student\" where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", _IdCard1);
                MakeConnection();
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt.Rows[0]["StudentName"].ToString();

            }
            catch
            {
                return "";
            }
        }

    }
}

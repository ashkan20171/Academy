using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
namespace Academy
{
    class Pecunary
    {
        public static int Paid, Debtor, Creditor, Mony;
        public static string BankName, BanchName, Serial, PaidType, Discription, Date,Id;
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

        public static DataTable _AllSelected(string _IdCard1)
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" Where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", _IdCard1);
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

        public static string _SearchLessonName(string _LessonId)
        {
            try
            {
                com.CommandText = "Select LessonName From \"Lesson\" Where LessonId=@LessonId";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@LessonId", _LessonId);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt.Rows[0]["LessonName"].ToString();
                
            }
            catch
            {
                return "" ;
            }
        }

        public static DataTable _SearchPecunary(string _Id)
        {
            try
            {
                com.CommandText = "Select * From \"Pecunary\" Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", _Id);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
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

        public static DataTable _SearchAllPecunary(string _Id)
        {
            try
            {
                com.CommandText = "Select * From \"AllPecunary\" Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", _Id);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
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

        public static bool _AddPecunary()
        {
            try
            {
                com.CommandText = "Insert Into \"AllPecunary\" Values(@Id,@Mony,@PaidType,@Date,@BankName,@BanchName,@Serial)";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", Id);
                com.Parameters.AddWithValue("@PaidType", PaidType);
                com.Parameters.AddWithValue("@Mony", Mony);
                com.Parameters.AddWithValue("@Date", Date);
                com.Parameters.AddWithValue("@BankName", BankName);
                com.Parameters.AddWithValue("@BanchName", BanchName);
                com.Parameters.AddWithValue("@Serial", Serial);
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

        public static bool _UpdatePecuniary(string _Id)
        {
            try
            {
                com.CommandText = "Update \"Pecunary\" Set Id=@Id,Debtor=@Debtor,Creditor=@Creditor,Paid=@Paid,Discription=@Discription Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", Id);
                com.Parameters.AddWithValue("@Debtor", Debtor);
                com.Parameters.AddWithValue("@Creditor", Creditor);
                com.Parameters.AddWithValue("@Paid", Paid);
                com.Parameters.AddWithValue("@Discription", Discription);
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

        public static bool _Delete(string _Id)
        {
            try
            {
                com.CommandText = "Delete From \"AllPecunary\" Where IdPec=@Id";
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

        public static DataTable _Search(string From, string To)
        {
            try
            {
                com.CommandText = "Select * From \"AllPecunary\" Where Date between '"+From+"' and '"+To+"'";
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
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

        public static DataTable _SearchPec(string _Type)
        {
            try
            {
                if(_Type=="Debtor")
                    com.CommandText = "Select * From \"Pecunary\" Where Debtor>0";
                else
                    com.CommandText = "Select * From \"Pecunary\" Where Creditor>0";
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
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

        public static string _SearchIdCard1(string _Id)
        {
            try
            {
                com.CommandText = "Select IdCard1 From \"Selected\" Where Id=@Id";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Id", _Id);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt.Rows[0]["IdCard1"].ToString();

            }
            catch
            {
                return "";
            }
        }

        public static byte[] _SearchPicture(string _IdCard1)
        {
            try
            {
                com.CommandText = "Select Picture From \"Student\" Where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", _IdCard1);
                da.SelectCommand = com;
                dt = new DataTable();
                MakeConnection();
                Connect();
                da.Fill(dt);
                Disconnect();
                return (byte[]) dt.Rows[0]["Picture"];

            }
            catch
            {
                return (byte[])dt.Rows[0]["Picture"];
            }
        }


      //  public static void d()
        //{
        //    MakeConnection();
        //    com.CommandText = "Delete from \"AllPecunary\"";
        //    Connect();
        //    com.ExecuteNonQuery();
        //    com.CommandText = "Delete from \"Pecunary\"";
        //    com.ExecuteNonQuery();
        //    com.CommandText = "Delete from \"Student\"";
        //    com.ExecuteNonQuery();
        //    com.CommandText = "Delete from \"Selected\"";
        //    com.ExecuteNonQuery();
        //    Disconnect();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Academy
{
    class Login
    {
        public static string UserName, Password,Answer,Question;
        static  SqlConnection con = new SqlConnection();
        static SqlCommand com = new SqlCommand();
        static  SqlDataAdapter da = new SqlDataAdapter();
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

        public static bool Search()
        {
            try
            {
                MakeConnection();
                dt = new DataTable();
                com.CommandText = "Select * From \"User\" Where UserName=@UserName and Password=@Password";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@UserName", UserName);
                com.Parameters.AddWithValue("@Password", Password);
                Connect();
                da.SelectCommand = com;
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count == 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "نام کاربری یا رومز ورود اشتباه است.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    Perrmision.AddGroup = Convert.ToBoolean(dt.Rows[0]["AddGroup"].ToString());
                    Perrmision.DeleteGroup = Convert.ToBoolean(dt.Rows[0]["DeleteGroup"].ToString());
                    Perrmision.AddStudent = Convert.ToBoolean(dt.Rows[0]["AddStudent"].ToString());
                    Perrmision.DeleteStudent = Convert.ToBoolean(dt.Rows[0]["DeleteStudent"].ToString());
                    Perrmision.UpdateStudent = Convert.ToBoolean(dt.Rows[0]["UpdateStudent"].ToString());
                    Perrmision.AddTeacher = Convert.ToBoolean(dt.Rows[0]["AddTeacher"].ToString());
                    Perrmision.DeleteTeacher = Convert.ToBoolean(dt.Rows[0]["DeleteTeacher"].ToString());
                    Perrmision.UpdateTeacher = Convert.ToBoolean(dt.Rows[0]["UpdateTeacher"].ToString());
                    Perrmision.AddSelected = Convert.ToBoolean(dt.Rows[0]["AddSelected"].ToString());
                    Perrmision.DeleteSelected = Convert.ToBoolean(dt.Rows[0]["DeleteSelected"].ToString());
                    Perrmision.UpdateSelected = Convert.ToBoolean(dt.Rows[0]["UpdateSelected"].ToString());
                    Perrmision.AddUser = Convert.ToBoolean(dt.Rows[0]["AddUser"].ToString());
                    Perrmision.DeleteUser = Convert.ToBoolean(dt.Rows[0]["DeleteUser"].ToString());
                    Perrmision.Show = Convert.ToBoolean(dt.Rows[0]["Show"].ToString());
                    Perrmision.AddLesson = Convert.ToBoolean(dt.Rows[0]["AddLesson"].ToString());
                    Perrmision.DeleteLesson = Convert.ToBoolean(dt.Rows[0]["DeleteLesson"].ToString());
                    Perrmision.UpdateLesson = Convert.ToBoolean(dt.Rows[0]["UpdateLesson"].ToString());
                    Perrmision.Name = dt.Rows[0]["Name"].ToString();
                    Perrmision.UserName = dt.Rows[0]["UserName"].ToString();
                    Perrmision.Picture = (byte[])dt.Rows[0]["Picture"];
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RecoveryPassword()
        {
            try
            {
                MakeConnection();
                dt = new DataTable();
                com.CommandText = "Select * From \"User\" Where UserName=@UserName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@UserName", UserName);
                Connect();
                da.SelectCommand = com;
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count == 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "چنین کاربری وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    Answer = dt.Rows[0]["Answer"].ToString();
                    Password = dt.Rows[0]["Password"].ToString();
                    com.CommandText = "Select Question From \"Question\" Where Id=@Id";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Id", dt.Rows[0]["Id"].ToString());
                    da.SelectCommand = com;
                    dt = new DataTable();
                    Connect();
                    da.Fill(dt);
                    Disconnect();
                    Question = dt.Rows[0]["Question"].ToString();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

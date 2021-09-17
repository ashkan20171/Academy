using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Academy
{
    class User
    {
        static SqlConnection con = new SqlConnection();
        static SqlCommand com = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();
        static DataTable dt;
        public static byte[] Picture;
        public static string UserName;
        public static string Name;
        public static string Password;
        public static string Answer;
        public static string Id;
        public static bool AddGroup;
        public static bool DeleteGroup;
        public static bool AddStudent;
        public static bool DeleteStudent;
        public static bool UpdateStudent;
        public static bool AddTeacher;
        public static bool DeleteTeacher;
        public static bool UpdateTeacher;
        public static bool AddUser;
        public static bool DeleteUser;
        public static bool AddSelected;
        public static bool DeleteSelected;
        public static bool UpdateSelected;
        public static bool Show;
        public static bool AddLesson;
        public static bool DeleteLesson;
        public static bool UpdateLesson;
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

        public static bool _AddUser()
        {
            try
            {
                com.CommandText = "Select UserName From \"User\" Where UserName=@UserName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@UserName", UserName);
                da.SelectCommand = com;
                dt = new DataTable();
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "کاربری با این نام کاربری وجود دارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"User\" Values(@Name,@UserName,@Password,@Picture,@Id,@Answer,@AddGroup,@DeleteGroup,@AddStudent,@DeleteStudent,@UpdateStudent,@AddTeacher,@DeleteTeacher,@UpdateTeacher,@AddLesson,@DeleteLesson,@UpdateLesson,@AddUser,@DeleteUser,@Show,@AddSelected,@DeleteSelected,@UpdateSelected)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Name", Name);
                    com.Parameters.AddWithValue("@UserName", UserName);
                    com.Parameters.AddWithValue("@Password", Password);
                    com.Parameters.AddWithValue("@Picture", Picture);
                    com.Parameters.AddWithValue("@ID", Id);
                    com.Parameters.AddWithValue("@Answer", Answer);
                    com.Parameters.AddWithValue("@AddGroup", AddGroup);
                    com.Parameters.AddWithValue("@DeleteGroup", DeleteGroup);
                    com.Parameters.AddWithValue("@AddStudent", AddStudent);
                    com.Parameters.AddWithValue("@DeleteStudent", DeleteStudent);
                    com.Parameters.AddWithValue("@UpdateStudent", UpdateStudent);
                    com.Parameters.AddWithValue("@AddTeacher", AddTeacher);
                    com.Parameters.AddWithValue("@DeleteTeacher", DeleteTeacher);
                    com.Parameters.AddWithValue("@UpdateTeacher", UpdateTeacher);
                    com.Parameters.AddWithValue("@AddUser", AddUser);
                    com.Parameters.AddWithValue("@DeleteUser", DeleteUser);
                    com.Parameters.AddWithValue("@AddLesson", AddLesson);
                    com.Parameters.AddWithValue("@DeleteLesson", DeleteLesson);
                    com.Parameters.AddWithValue("@UpdateLesson", UpdateLesson);
                    com.Parameters.AddWithValue("@Show", Show);
                    com.Parameters.AddWithValue("@AddSelected", AddSelected);
                    com.Parameters.AddWithValue("@DeleteSelected", DeleteSelected);
                    com.Parameters.AddWithValue("@UpdateSelected", UpdateSelected);
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

        public static DataTable _Question()
        {
            try
            {
                MakeConnection();
                com.CommandText = "Select * From \"Question\"";
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

        [Obsolete]
        public static bool _DeleteUser(string _UserName)
        {
            try
            {
                if (_UserName == Perrmision.UserName)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "کاربر در حاب استفاده از نرم افزار است.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    MakeConnection();
                    com.CommandText = "Delete From \"User\" Where UserName=@UserName";
                    com.Parameters.Clear();
                    SqlParameter sqlParameter = com.Parameters.Add("@UserName", _UserName);
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

        public static DataTable _AllUser()
        {
            try
            {
                com.CommandText = "Select UserName,Name,Picture From \"User\"";
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

        public static DataTable _SearchUser(string _UserName)
        {
            try
            {
                com.CommandText = "Select * From \"User\" Where UserName=@UserName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@UserName", _UserName);
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

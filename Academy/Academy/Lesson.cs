using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Academy
{
    class Lesson
    {
        public static string LessonId;
        public static string LessonName;
        public static string TeacherName;
        public static string Sex;
        public static string GroupName;
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

        public static bool _AddLesson()
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\" Where LessonId=@LessonId";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@LessonId", LessonId);
                MakeConnection();
                da.SelectCommand = com;
                Connect();
                dt = new DataTable();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "درسی با این شناسه وجود دارد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"Lesson\" Values(@LessonId,@LessonName,@GroupName,@TeacherName,@Salary,@Sex)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@LessonId", LessonId);
                    com.Parameters.AddWithValue("@LessonName", LessonName);
                    com.Parameters.AddWithValue("@Sex", Sex);
                    com.Parameters.AddWithValue("@Salary", Salary);
                    com.Parameters.AddWithValue("@GroupName", GroupName);
                    com.Parameters.AddWithValue("@TeacherName", TeacherName);
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

        public static DataTable _AllLessonId()
        {
            try
            {
                com.CommandText = "Select LessonId From \"Lesson\"";
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

        public static bool _DeleteLesson(string _LessonId)
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" Where LessonId=@LessonId";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@LessonId", _LessonId);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    DialogResult dr;
                    dr = FarsiMessageBox.MessageBox.Show("سوال", "هنرجو ای این درس را اخذ کرده\nآیا میخواهید درس حذف شود؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                    if (dr == DialogResult.Yes)
                    {
                        com.CommandText = "Delete From \"Lesson\" Where LessonId=@LessonId";
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
                    com.CommandText = "Delete From \"Lesson\" Where LessonId=@LessonId";
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

        public static bool _UpdateLesson(string _LessonId)
        {
            try
            {
                com.CommandText = "Update \"Lesson\" Set TeacherName=@TeacherName , Sex=@Sex ,GroupName=@GroupName, LessonId=@LessonId, LessonName=@LessonName, Salary=@Salary Where LessonId=@_LessonId  ";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@TeacherName", TeacherName);
                com.Parameters.AddWithValue("@LessonName", LessonName);
                com.Parameters.AddWithValue("@Sex", Sex);
                com.Parameters.AddWithValue("@LessonId", LessonId);
                com.Parameters.AddWithValue("@GroupName", GroupName);
                com.Parameters.AddWithValue("@Salary", Salary);
                com.Parameters.AddWithValue("@_LessonId", _LessonId);
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

        public static bool _SearchLessonId(string _LessonId )
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
                    FarsiMessageBox.MessageBox.Show("خطا", "درسی با این شناسه وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    LessonId = dt.Rows[0]["LessonId"].ToString();
                    LessonName = dt.Rows[0]["LessonName"].ToString();
                    TeacherName = dt.Rows[0]["TeacherName"].ToString();
                    GroupName = dt.Rows[0]["GroupName"].ToString();
                    Sex = dt.Rows[0]["Sex"].ToString();
                    Salary = dt.Rows[0]["Salary"].ToString();
                    return true;
                }
                
            }
            catch
            {
                return false;
            }
        }

        public static DataTable _All()
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\"";
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

        public static DataTable _SearchLesson(string _LessonName,string _GroupName,string _Sex,string _LessonId,string _TeacherName)
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\" where LessonName=@LessonName or GroupName=@GroupName or Sex=@Sex or LessonId=@LessonId or TeacherName=@TeacherName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@LessonName", _LessonName);
                com.Parameters.AddWithValue("@GroupName", _GroupName);
                com.Parameters.AddWithValue("@Sex", _Sex);
                com.Parameters.AddWithValue("@LessonId", _LessonId);
                com.Parameters.AddWithValue("@TeacherName", _TeacherName);
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

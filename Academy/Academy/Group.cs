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
    class Group
    {
        public static string GroupName;
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

        public static bool _AddGroup()
        {
            try
            {
                com.CommandText = "Select * From \"Group\" Where GroupName=@GroupName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@GroupName", GroupName);
                MakeConnection();
                da.SelectCommand = com;
                Connect();
                dt = new DataTable();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "گروه درسی با این نام وجود دارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"Group\" Values(@GroupName)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@GroupName", GroupName);
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

        public static DataTable _All()
        {
            try
            {
                com.CommandText = "Select GroupName From \"Group\"";
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

        public static bool _DeleteGroup(string _GroupName)
        {
            try
            {
                com.CommandText = "Select * From \"Lesson\" Where GroupName=@GroupName";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@GroupName", _GroupName);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    DialogResult dr;
                    dr = FarsiMessageBox.MessageBox.Show("سوال", "درسی با این گروه درسی ارائه شده.\nآیا می خواهید گروه درسی حذف شود؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                    if (dr == DialogResult.Yes)
                    {
                        com.CommandText = "Delete From \"Group\" Where GrouprName=@GroupName";
                        Connect();
                        com.ExecuteNonQuery();
                        //com.CommandText = "Delete From \"Lesson\" Where GrouprName=@GroupName";
                        //com.ExecuteNonQuery();
                        Disconnect();
                        return true;
                    }
                    else
                        return false;

                }
                else
                {
                    com.CommandText = "Delete From \"Group\" Where GroupName=@GroupName";
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
    }
}


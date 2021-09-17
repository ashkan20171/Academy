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
    class Student
    {
        public static string StudentName;
        public static string FatherName;
        public static string Sex;
        public static string Tell;
        public static string Mobile;
        public static string IdCard1;
        public static string IdCard2;
        public static string Address;
        public static string Discription;
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

        public static bool _AddStudent()
        {
            try
            {
                com.CommandText = "Select * From \"Student\" Where IdCard1=@IdCard1";
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
                    FarsiMessageBox.MessageBox.Show("خطا", "هنرجویی با این کد ملی وجود دارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
                else
                {
                    com.CommandText = "Insert Into \"Student\" Values(@StudentName,@FatherName,@Sex,@IdCard1,@IdCard2,@Tell,@Mobile,@Address,@Picture,@Discription)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@StudentName", StudentName);
                    com.Parameters.AddWithValue("@FatherName", FatherName);
                    com.Parameters.AddWithValue("@Sex", Sex);
                    com.Parameters.AddWithValue("@IdCard1", IdCard1);
                    com.Parameters.AddWithValue("@IdCard2", IdCard2);
                    com.Parameters.AddWithValue("@Tell", Tell);
                    com.Parameters.AddWithValue("@Mobile", Mobile);
                    com.Parameters.AddWithValue("@Address", Address);
                    com.Parameters.AddWithValue("@Discription", Discription);
                    com.Parameters.AddWithValue("@Picture", Picture);
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

        public static DataTable _AllStudent()
        {
            try
            {
                com.CommandText = "Select StudentName,FatherName,IdCard1,IdCard2,Picture From \"Student\"";
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

        public static bool _DeleteStudent()
        {
            try
            {
                com.CommandText = "Select * From \"Selected\" Where IdCard1=@IdCard1";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                if (dt.Rows.Count != 0)
                {
                    DialogResult dr;
                    dr = FarsiMessageBox.MessageBox.Show("سوال", "این هنرجو درسی را اخذ کرده.\nآیا مطمئن هستید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                    if (dr == DialogResult.Yes)
                    {
                        com.CommandText = "Delete From \"Student\" Where IdCard1=@IdCard1";
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
                    com.CommandText = "Delete From \"Student\" Where IdCard1=@IdCard1";
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
                com.CommandText = "Select * From \"Student\" Where IdCard1=@IdCard1";
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
                    StudentName = dt.Rows[0]["StudentName"].ToString();
                    FatherName = dt.Rows[0]["FatherName"].ToString();
                    Sex = dt.Rows[0]["Sex"].ToString();
                    IdCard1 = dt.Rows[0]["IdCard1"].ToString();
                    IdCard2 = dt.Rows[0]["IdCard2"].ToString();
                    Tell = dt.Rows[0]["Tell"].ToString();
                    Mobile = dt.Rows[0]["Mobile"].ToString();
                    Address = dt.Rows[0]["Address"].ToString();
                    Discription = dt.Rows[0]["Discription"].ToString();
                    Picture =(byte[]) dt.Rows[0]["Picture"];
                    return true;
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "هنرجو ای با این شماره ملی وجود ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool _UpdateStudent(string _IdCard1)
        {
            try
            {
                com.CommandText = "Update \"Student\" Set StudentName=@StudentName , FatherName=@FatherName , Sex=@Sex ,IdCard1=@IdCard1 , IdCard2=@IdCard2 , Address=@Address , Tell=@Tell , Mobile=@Mobile, Discription=@Discription , Picture=@Picture Where IdCard1=@_IdCard1  ";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@StudentName", StudentName);
                com.Parameters.AddWithValue("@FatherName", FatherName);
                com.Parameters.AddWithValue("@Sex", Sex);
                com.Parameters.AddWithValue("@IdCard1", IdCard1);
                com.Parameters.AddWithValue("@IdCard2", IdCard2);
                com.Parameters.AddWithValue("@Tell", Tell);
                com.Parameters.AddWithValue("@Mobile", Mobile);
                com.Parameters.AddWithValue("@Address", Address);
                com.Parameters.AddWithValue("@Discription", Discription);
                com.Parameters.AddWithValue("@Picture", Picture);
                com.Parameters.AddWithValue("@_IdCard1",_IdCard1);
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

        public static DataTable _All()
        {
            try
            {
                com.CommandText = "Select * From \"Student\"";
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

        public static DataTable _SearchStudent(string _Name, string _IdCard1,string _Sex)
        {
            try
            {
                com.CommandText = "Select * From \"Student\" Where IdCard1=@IdCard1 or StudentName Like'%" + _Name + "%' or Sex=@Sex";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("IdCard1", _IdCard1);
                com.Parameters.AddWithValue("Sex", _Sex);
                MakeConnection();
                dt = new DataTable();
                da.SelectCommand = com;
                Connect();
                da.Fill(dt);
                Disconnect();
                return dt;
            }
            catch
            {
                return dt ;
            }
        }

    }
}
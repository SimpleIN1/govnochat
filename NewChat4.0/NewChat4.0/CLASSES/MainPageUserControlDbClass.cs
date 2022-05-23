using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewChat4._0
{
    class MainPageUserControlDbClass
    {
        private string _connection;
        public static bool CheckError = false;
        public static bool CheckStatusDeletedUser = false;
        public MainPageUserControlDbClass(string connection)
        {
            this._connection = connection;
        }

        public bool InsertUser(string name_reg, string password_reg)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                try
                {
                    conn.Open();
                    string insert = "insert into chat.users(login,password,status,status_deleted) values (@login,@password,0,0)";
                    SqlCommand sqlCommand = new SqlCommand(insert, conn);

                    sqlCommand.Parameters.AddWithValue("login", name_reg);
                    CryptClass passCrypt = new CryptClass(password_reg);
                    string passwordCrypt = passCrypt.getEncryptingData();
                    sqlCommand.Parameters.AddWithValue("password", passwordCrypt);

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception error)
                    {
                        CheckError = true;
                        return false;
                    }
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool LogInUser(string name, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                try
                {
                    conn.Open();
                    string sql_query = "select id,status_deleted from chat.users where login=@login and password=@password;";
                    SqlCommand sqlCommand = new SqlCommand(sql_query, conn);

                    sqlCommand.Parameters.AddWithValue("login", name);
                    CryptClass passCrypt = new CryptClass(password);
                    string passwordCrypt = passCrypt.getEncryptingData();
                    sqlCommand.Parameters.AddWithValue("password", passwordCrypt);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows && sqlDataReader.Read())
                    {
                        if (Convert.ToBoolean(sqlDataReader["status_deleted"]))
                            CheckStatusDeletedUser = true;
                        else
                        {
                            UpdateStatusUser(name, true);
                            CheckStatusDeletedUser = false;
                        }

                        return true;
                    }
                    else
                    {
                        CheckError = true;
                        return false;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void UpdateStatusDeletedUser(string name)
        {
            using (SqlConnection conn = new SqlConnection(MainPageUserControl.connection))
            {
                conn.Open();
                string update = "update chat.users set status_deleted=0 where login=@login";

                SqlCommand sqlCommand = new SqlCommand(update, conn);
                sqlCommand.Parameters.AddWithValue("login", name);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateStatusUser(string name, bool status)
        {
            using (SqlConnection conn = new SqlConnection(MainPageUserControl.connection))
            {
                conn.Open();
                string update = "update chat.users set status=@status where login=@login";

                SqlCommand sqlCommand = new SqlCommand(update, conn);
                sqlCommand.Parameters.AddWithValue("status", status);
                sqlCommand.Parameters.AddWithValue("login", name);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

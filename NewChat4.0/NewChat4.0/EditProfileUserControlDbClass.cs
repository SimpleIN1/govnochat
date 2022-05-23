using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace NewChat4._0
{
    class EditProfileUserControlDbClass
    {
        private string _connection;
        public EditProfileUserControlDbClass(string connection)
        {
            this._connection = connection;
        }

        public byte[] ShowImageUser(string name)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string delete = "select image from chat.users where login=@y_name";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("y_name", name);
                try
                {
                    return (byte[])sqlCommand.ExecuteScalar();
                }
                catch (Exception error)
                {
                    return null;
                }
            }
        }

        public bool DeleteUser(string name)//add funtion the recovery page of user!
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                //string delete = "delete from chat.users where login=@y_name";
                string delete = "update chat.users set status_deleted=1 where login=@y_name";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("y_name", name);
                try
                {
                    sqlCommand.ExecuteReader();
                    return true;
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool UpdateProfileUser(ref string NameUser, string NewNameUser, byte[] ImgArr)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = " update chat.users set login=@NewNameUser, image=";
                if (ImgArr == null)
                    insert += "null";
                else
                    insert += "@img";
                insert += " where login=@NameUser";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);
                sqlCommand.Parameters.AddWithValue("NewNameUser", NewNameUser);
                if (ImgArr != null)
                    sqlCommand.Parameters.AddWithValue("img", ImgArr);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    NameUser = NewNameUser;
                    return true;
                }
                catch (Exception error)
                {
                    //
                    //MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}

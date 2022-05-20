using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewChat4._0
{
    class ChatFormUserControlDbClass
    {
        private string _connection;
        public ChatFormUserControlDbClass(string connection)
        {
            this._connection = connection;
        }

        public bool SearchUsersAll(List<string> UserList, string LoginUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login,status from chat.users where login like @userlogin";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("userlogin", "%" + LoginUser + "%");

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToBoolean(reader["status"]))
                            UserList.Add(reader["login"].ToString() + " Online");
                        else
                            UserList.Add(reader["login"].ToString());
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool ShowProfileUser(UsersClass u)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string SelectImage = "select * from chat.users where login=@NameUser";
                SqlCommand sqlCommand = new SqlCommand(SelectImage, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", u.login);

                try
                {
                    SqlDataReader read = sqlCommand.ExecuteReader();
                    read.Read();
                    if (read["image"] != DBNull.Value)
                        u.image = (byte[])read["image"];
                    else
                        u.image = null;
                    u.status = (bool)read["status"];
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool AddFriendUser(string NameUser, string NameFriend)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string InsertUser = "insert into chat.friends(id_user_who_add,id_user_friend_added, date) values " +
                    " ((select id from chat.users where login=@NameUser),(select id from chat.users where login=@NameFriend),current_timestamp)," +
                    " ((select id from chat.users where login=@NameFriend),(select id from chat.users where login=@NameUser),current_timestamp)";
                SqlCommand sqlCommand = new SqlCommand(InsertUser, conn);
                sqlCommand.Parameters.AddWithValue("NameUser",NameUser);
                sqlCommand.Parameters.AddWithValue("NameFriend",NameFriend);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

    }
}

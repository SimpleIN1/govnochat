using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                string select = "select login,status,status_deleted from chat.users where login like @userlogin";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("userlogin", "%" + LoginUser + "%");

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToBoolean(reader["status_deleted"]))
                            UserList.Add(reader["login"].ToString() + " deleted");
                        else if (Convert.ToBoolean(reader["status"]))
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

        public bool CheckStatusDeleteUser(string SelectedUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string InsertUser = "select status_deleted from chat.users where login=@SelectedUser";
                SqlCommand sqlCommand = new SqlCommand(InsertUser, conn);
                sqlCommand.Parameters.AddWithValue("SelectedUser", SelectedUser);

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    return (reader.HasRows?true:false);
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public static string GenerateData(List<string> UsersList, string UserName="", string parametrlf = "'", string parametrrg = "'")
        {
            string data = parametrlf + UserName + parametrrg;

            foreach (object element in UsersList)
            {
                data += "," + parametrlf + element + parametrrg;
            }

            return data;
        }

        public bool ShowListFriends(List<string> ListUserFriends, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {

                conn.Open();
                string Select = "select login from chat.users where id in "+
                                     "(select id_user_friend_added from chat.friends where id_user_friend_added not in "+
                                     "(select id from chat.users where login in ("+GenerateData(ListUserFriends,NameUser)+")) "+
                                     "and id_user_who_add = (select id from chat.users where login=@NameUser))";
                SqlCommand sqlCommand = new SqlCommand(Select, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);
                 
                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ListUserFriends.Add(reader["login"].ToString());
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool ShowListFriendsDelete(List<string> ListUserFriends, List<string> ListUserFriendsDelete, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string Select = "select login from chat.users where login in ("+ GenerateData(ListUserFriends) + ") except " +
                                "select login from chat.users where id in "+ 
                                "(select id_user_friend_added from chat.friends where  id_user_who_add = (select id from chat.users where login = @NameUser))";
                SqlCommand sqlCommand = new SqlCommand(Select, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);
 
                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ListUserFriendsDelete.Add(reader["login"].ToString());
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool CheckIsFriend(string NameUser, string NameFriend)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string Select = "select * from chat.friends where " +
                                "id_user_who_add = (select id from chat.users where login=@NameUser)" +
                                " and id_user_friend_added = (select id from chat.users where login=@NameFriend)";
                SqlCommand sqlCommand = new SqlCommand(Select, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);
                sqlCommand.Parameters.AddWithValue("NameFriend", NameFriend);
                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }
        public bool DeleteFriend(string NameUser, string NameFriend)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string Select = "delete from chat.friends where "+
                                "(id_user_who_add = (select id from chat.users where login = @NameUser) and "+
                                "id_user_friend_added = (select id from chat.users where login = @NameFriend)) or "+
                                "(id_user_friend_added = (select id from chat.users where login = @NameUser) and "+
                                "id_user_who_add = (select id from chat.users where login = @NameFriend))";
                SqlCommand sqlCommand = new SqlCommand(Select, conn);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);
                sqlCommand.Parameters.AddWithValue("NameFriend", NameFriend);
                try
                {
                    sqlCommand.ExecuteReader(); 
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public void ShowChats(Dictionary<int, string> chatsKeyValuePairs, string name)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select id, chat_name from chat.chats where id in " +
                                    "(select id_chat from chat.users_chats where id_user = " +
                                        "(select id from chat.users where login = @login))";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("login", name);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!chatsKeyValuePairs.ContainsKey(Convert.ToInt32(sqlDataReader.GetValue(0))))
                        chatsKeyValuePairs.Add(Convert.ToInt32(sqlDataReader.GetValue(0)), sqlDataReader.GetValue(1).ToString());
                }
            }
        }

        public bool ShowMessages(int IdChat, List<string> messages, ref int CountWritten)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select u.login,m.message,m.image,DATEPART(MI,m.date) as mi,DATEPART(HH,m.date) as hh from chat.messages as m " +//convert(time(0), m.date),DATEPART(MI,m.date), DATEPART(HH,m.date)
                                " inner join chat.users as u on u.id = m.id_user " +
                                " where m.id_chat=@idc order by date asc;";//"select * from chat.messages where id_chat=@idc order by date asc";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idc", IdChat);

                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    int CountI = 0;
                    while (sqlDataReader.Read())
                    {
                        if (++CountI > CountWritten && CountI > messages.Count)
                            messages.Add(sqlDataReader["hh"] + ":" + sqlDataReader["mi"] + " " + sqlDataReader["login"] + " -> " + sqlDataReader["message"]);
                    }
                    CountWritten += (CountI - CountWritten);
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public byte[] ShowImageChat(int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string SelectImage = "select image from chat.chats where id = @id_chat";
                SqlCommand sqlCommand = new SqlCommand(SelectImage, conn);
                sqlCommand.Parameters.AddWithValue("id_chat", IdChat);

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


        public bool InsertMessage(string nameUser, int IdChat, string message)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = "insert into chat.messages (id_user,id_chat,message, date) values ((select id from chat.users where login=@nameu),@idc,@mes,current_timestamp)";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.Parameters.AddWithValue("nameu", nameUser);
                sqlCommand.Parameters.AddWithValue("idc", IdChat);
                sqlCommand.Parameters.AddWithValue("mes", message);

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

        public bool ShowIdchat(List<string> UserList,ref int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                //string select = "select id from chat.chats where id not in "+
                //                "(select id_chat from chat.users_chats where id_user in "+
                //                "(select id from chat.users where login not in ("+GenerateData(UserList)+")))";

                string select = "select id_chat, count(id_user) from chat.users_chats where id_user in" +
                                "(select id from chat.users where login in (" + GenerateData(UserList) + ")) and id_chat not in" +
                                "(select id_chat from chat.users_chats where id_user in" +
                                "(select id from chat.users where login not in ("+GenerateData(UserList)+"))) group by id_chat having count(*) = 2";

                SqlCommand sqlCommand = new SqlCommand(select, conn);
                //MessageBox.Show(select);
                try
                {
                    IdChat = (int)sqlCommand.ExecuteScalar();
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

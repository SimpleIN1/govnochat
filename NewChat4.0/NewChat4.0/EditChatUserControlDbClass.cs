using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewChat4._0
{
    class EditChatUserControlDbClass
    {
        private string _connection;
        public EditChatUserControlDbClass(string connection)
        {
            this._connection = connection;
        }


        public bool AddUserChat(List<string> UsersList, string NameUser, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                //MessageBox.Show(string.Join(",", UsersList.Select(x => x.ToString()).ToArray()));//
                string InsertUser = "insert into chat.users_chats(id_user, id_chat,id_person_who_invited) values ";
                int CountSep = 0;
                foreach (object item in UsersList)
                {
                    InsertUser += "((select id from chat.users where login ='" + item.ToString() + "'),@idchat,(select id from chat.users where login = @uname))";
                    if (++CountSep < UsersList.Count)
                        InsertUser += ",";
                }

                SqlCommand sqlCommand = new SqlCommand(InsertUser, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                sqlCommand.Parameters.AddWithValue("uname", NameUser);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool CheckAdminChat(string UserName, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string show = "select id_admin from chat.chats where id_admin=(select id from chat.users where login=@username) and id=@idchat";

                SqlCommand sqlCommand = new SqlCommand(show, conn);
                sqlCommand.Parameters.AddWithValue("username", UserName);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                try
                {
                    SqlDataReader read = sqlCommand.ExecuteReader();
                    //return read.Read();//this is part of code dont work//successfully
                    return (read.HasRows ? true : false);
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool ShowDeleteUserChat(string NameUser, int IdChat, string YourName)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string delete = "select * from chat.users_chats where id_chat=@idchat and id_user = (select id from chat.users where login=@NameUser)" +
                                "and(id_chat = (select id from chat.chats where id=@idchat and id_admin = (select id from chat.users where login = @y_name))" +
                                "or id_person_who_invited = (select id from chat.users where login = @y_name) or id_user = (select id from chat.users where login = @y_name))";//or id_user=(select id from chat.users where login=("+NameUser+"))
                                                                                                                                                                               //"delete from chat.users_chats where id_chat=@idchat and id_user in (select id from chat.users where login in (" + NameUser + ")) and (id_person_who_invited=(select id from chat.users where login=@y_name) or id_chat=(select id from chat.chats where id_admin=(select id from chat.users where login=@y_name)))";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                sqlCommand.Parameters.AddWithValue("y_name", YourName);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);

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
                    MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool DeleteUserChat(string NameUser, int IdChat, string YourName)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string delete = "delete from chat.users_chats where id_chat=@idchat and id_user = (select id from chat.users where login=@NameUser)" +
                                "and(id_chat = (select id from chat.chats where id=@idchat and id_admin = (select id from chat.users where login = @y_name))" +
                                "or id_person_who_invited = (select id from chat.users where login = @y_name) or id_user = (select id from chat.users where login = @y_name))";//or id_user=(select id from chat.users where login=("+NameUser+"))
                                                                                                                                                                               //"delete from chat.users_chats where id_chat=@idchat and id_user in (select id from chat.users where login in (" + NameUser + ")) and (id_person_who_invited=(select id from chat.users where login=@y_name) or id_chat=(select id from chat.chats where id_admin=(select id from chat.users where login=@y_name)))";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                sqlCommand.Parameters.AddWithValue("y_name", YourName);
                sqlCommand.Parameters.AddWithValue("NameUser", NameUser);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool UpdateChatImageName(byte[] ImgArr, string ChatName, int IdChat, ref string errorStr)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = " update chat.chats set chat_name=@chatname, image=";
                if (ImgArr == null)
                    insert += "null";
                else
                    insert += "@img";
                insert += " where id=@idchat";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.Parameters.AddWithValue("chatname", ChatName);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                if (ImgArr != null)
                    sqlCommand.Parameters.AddWithValue("img", ImgArr);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception error)
                {
                    errorStr = error.ToString();
                    return false;
                }
            }
        }

        public static bool ShowAllUsersDelete(List<string> UsersChat, List<string> DeleteUsersChat)//rewrite this function
        {
            using (SqlConnection conn = new SqlConnection(MainPageUserControl.connection))
            {
                conn.Open();
                string select = "select * from ( values " + ChatFormUserControlDbClass.GenerateData(UsersChat, "('", "')") + ") tlogins(login) except" +
                                "select login from chat.users";
                SqlCommand sqlCommand = new SqlCommand(select, conn);

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        DeleteUsersChat.Add(reader["login"].ToString());
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool ShowUsers(List<string> UsersList, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users " +
                                "where id not in (select id from chat.users where login in (" + ChatFormUserControlDbClass.GenerateData(UsersList, NameUser) + ")) " +
                                "order by id;";

                SqlCommand sqlCommand = new SqlCommand(select, conn);
                //MessageBox.Show(select);
                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        UsersList.Add(sqlDataReader["login"].ToString());
                    }

                    return true;
                }
                catch (Exception error)
                {
                    //MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public bool ShowUsersDeleteChat(List<string> UsersChat, List<string> DeleteUsersChat, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where login in (" + ChatFormUserControlDbClass.GenerateData(UsersChat, "") + ") except " +
                                "select login from chat.users where id in " +
                                "(select id_user from chat.users_chats where id_chat = @IdChat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("IdChat", IdChat);

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    //MessageBox.Show(string.Join(",", UsersChat.Select(x => x.ToString()).ToArray()));
                    //MessageBox.Show(string.Join(",", DeleteUsersChat.Select(x => x.ToString()).ToArray()));

                    while (reader.Read())
                    {
                        DeleteUsersChat.Add(reader["login"].ToString());
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public static bool ShowUsersChat1(List<string> UsersChatList, int IdChat, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(MainPageUserControl.connection))
            {
                conn.Open();
                string select = "select login from chat.users where id in " +
                                    "(select id_user from chat.users_chats where id_user not in" +
                                        "(select id from chat.users where login in (" + ChatFormUserControlDbClass.GenerateData(UsersChatList, NameUser) + ")) " +
                                    "and id_chat=@IdChat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("IdChat", IdChat);

                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        UsersChatList.Add(reader["login"].ToString());
                        //MessageBox.Show(string.Join(",", UsersChatList.Select(x => x.ToString()).ToArray()));
                    }
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool GetNameAdminChat(int IdChat, ref string NameAdminChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id = (select id_admin from chat.chats where id=@idchat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                try
                {
                    NameAdminChat = sqlCommand.ExecuteScalar().ToString();
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
    }
}

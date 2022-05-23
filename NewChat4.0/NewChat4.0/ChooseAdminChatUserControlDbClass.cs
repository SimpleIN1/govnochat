using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace NewChat4._0
{
    class ChooseAdminChatUserControlDbClass
    {
        private string _connection;
        public ChooseAdminChatUserControlDbClass(string connection)
        {
            this._connection = connection;
        }

        public bool CheckUserChat(string NameNewAdmin, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();

                try
                {
                    SqlCommand CheckSqlCommand = new SqlCommand("select id_user from chat.users_chats where id_user=(select id from chat.users where login=@loginuser) and id_chat=@idchat", conn);
                    CheckSqlCommand.Parameters.AddWithValue("loginuser", NameNewAdmin);
                    CheckSqlCommand.Parameters.AddWithValue("idchat", IdChat);
                    SqlDataReader reader = CheckSqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool UpdateAdminChat(string NameNewAdmin, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();

                string select = "update chat.chats set id_admin = (select id from chat.users where login=@userlogin) where id=@IdChat";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("IdChat", IdChat);
                sqlCommand.Parameters.AddWithValue("userlogin", NameNewAdmin);

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

    }
}


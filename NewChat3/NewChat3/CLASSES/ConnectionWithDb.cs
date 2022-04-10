using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace NewChat3
{
    class ConnectionWithDb
    {
        private string _connection;
        public static bool checkError = false;

        public ConnectionWithDb(string connection)
        {
            this._connection = @connection;
        }

        public bool InsertUser(string name_reg, string password_reg)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                try
                {
                    conn.Open();
                    string insert = "insert into chat.users(login,password,status) values (@login,@password,0)";
                    SqlCommand sqlCommand = new SqlCommand(insert, conn);

                    sqlCommand.Parameters.AddWithValue("login", name_reg);
                    Crypt passCrypt = new Crypt(password_reg);
                    string passwordCrypt = passCrypt.getEncryptingData();
                    sqlCommand.Parameters.AddWithValue("password", passwordCrypt);

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception error)
                    {
                        checkError = true;
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
                    string sql_query = "select * from chat.users where login=@login and password=@password;";
                    SqlCommand sqlCommand = new SqlCommand(sql_query, conn);

                    sqlCommand.Parameters.AddWithValue("login", name);
                    Crypt passCrypt = new Crypt(password);
                    string passwordCrypt = passCrypt.getEncryptingData();
                    sqlCommand.Parameters.AddWithValue("password", passwordCrypt);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        this.UpdateStatusUser(name, true);
                        return true;
                    }
                    else
                    {
                        checkError = true;
                        return false;
                    }
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public void UpdateStatusUser(string name, bool status)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
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
                    sqlDataReader.Read();
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

        public byte[] ShowImage(int IdChat)
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

        private string GenerateData(List<string> UsersList, string UserName)
        {
            string data = "('" + UserName + "'";

            foreach (object element in UsersList)
            {
                data += ",'" + element + "'";
            }
            data += ")";

            return data;
        }

        public bool CreateChat(string UserName, List<string>UsersList, string ChatName, byte[] ImageArr,ref string errorStr)
        {
            string DataLogins = GenerateData(UsersList, UserName);/*"("+UsersList.Join(',') + ")" //*/

            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select;
                if (UsersList.Count + 1 == 2)
                {
                    select = "select id_chat, count(id_user) from chat.users_chats where id_user in" +
                                    "(select id from chat.users where login in " + DataLogins + ") and id_chat not in" +
                                    "(select id_chat from chat.users_chats where id_user in" +
                                    "(select id from chat.users where login not in " + DataLogins + ")) group by id_chat having count(*) = " + (UsersList.Count + 1).ToString();
                }
                else
                {
                    select = "select id from chat.chats where id = -1";
                }

                SqlCommand sqlCommandRead = new SqlCommand(select, conn);

                try
                {
                    SqlDataReader sqlDataReader = sqlCommandRead.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        errorStr = "Chats is exists";
                        return false;
                    }
                    else
                    {
                        sqlDataReader.Close();
                        string insert = "declare @idc int;" +
                                        "insert into chat.chats(chat_name,date,id_admin,image) values(@name,current_timestamp,(select id from chat.users where login=@login0),";

                        if (ImageArr == null)
                            insert += "null";
                        else
                            insert += "@imagep";

                        insert += ");set @idc = SCOPE_IDENTITY();" +
                        "insert into chat.users_chats(id_user, id_chat,id_person_who_invited)values((select id from chat.users where login = @login0),@idc,(select id from chat.users where login = @login0))";
                        int i = 0;
                        while (i++ < UsersList.Count)
                        {
                            insert += ",((select id from chat.users where login = @login" + i.ToString() + "),@idc,(select id from chat.users where login = @login0))";
                        }

                        SqlCommand sqlCommand = new SqlCommand(insert, conn);
                        sqlCommand.Parameters.AddWithValue("name", ChatName);
                        sqlCommand.Parameters.AddWithValue("login0", UserName);

                        if (ImageArr != null)
                            sqlCommand.Parameters.AddWithValue("imagep", ImageArr);

                        i = 0;
                        foreach (object element in UsersList)
                        {
                            i++;
                            sqlCommand.Parameters.AddWithValue("login" + i.ToString(), element);
                        }

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception error)
                        {
                            errorStr = "OSHIBKA";
                            return false;
                        }

                    }
                }
                catch (Exception error)
                {
                    errorStr = "Something with connection";
                    return false;
                }
            }

        }

        public bool ShowUsers(List<string> list, string name,ref int CountUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select id,login from chat.users order by id";
                SqlCommand sqlCommand = new SqlCommand(select,conn);
                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    int CountI = 0;
                    while (sqlDataReader.Read())
                    {
                        if (++CountI > CountUser && CountI > list.Count && sqlDataReader["login"].ToString() != name)
                        {
                            list.Add(sqlDataReader["login"].ToString());
                        }
                    }
                    CountUser += (CountI - CountUser);

                    return true;
                }
                catch(Exception error)
                {
                    return false;
                }
            }
        }

        public bool DeleteUser(string NameUser, int IdChat, string YourName)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string delete = "delete from chat.users_chats where id_chat=@idchat and id_user in (select id from chat.users where login in (" + NameUser + ")) and (id_person_who_invited=(select id from chat.users where login=@y_name) or id_chat=(select id from chat.chats where id_admin=(select id from chat.users where login=(select id from chat.users where login=@y_name))))";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                sqlCommand.Parameters.AddWithValue("y_name", YourName);
                try
                {
                    sqlCommand.ExecuteReader();
                    return true;
                }
                catch (Exception error)
                {
                    return false;
                }
            }
        }

        public bool UpdateChatImageName(byte[] ImgArr, string ChatName, int IdChat,ref string errorStr)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = " update chat.chats set chat_name=@chatname, image=";
                if (ImgArr == null)
                    insert += "null";
                else
                    insert += "@img";
                insert +=" where id=@idchat";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.Parameters.AddWithValue("chatname", ChatName);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
                if(ImgArr!=null)
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

        public bool AddUserChat(List<string> UsersList, string NameUser, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();

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
                    return false;
                }
            }
        }

        public bool ShowUsersChat(List<string> UsersChatList, int id_chat, ref int CountUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id in(select id_user from chat.users_chats where id_chat=@idchat) order by id";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idchat", id_chat);
                try
                {
                    SqlDataReader read = sqlCommand.ExecuteReader();

                    int CountI = 0;
                    while (read.Read())
                    {
                        if (++CountI > CountUser && CountI > UsersChatList.Count)
                            UsersChatList.Add(read["login"].ToString());
                       
                    }
                    CountUser += (CountI - CountUser); 
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

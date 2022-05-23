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
                    string insert = "insert into chat.users(login,password,status,status_deleted) values (@login,@password,0,0)";
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
                    string sql_query = "select id from chat.users where login=@login and password=@password;";
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

        private string GenerateData(List<string> UsersList, string UserName, string parametrlf="'", string parametrrg="'")
        {
            string data = parametrlf + UserName + parametrrg;

            foreach (object element in UsersList)
            {
                data += ","+parametrlf + element + parametrrg;
            }

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
                                    "(select id from chat.users where login in (" + DataLogins + ")) and id_chat not in" +
                                    "(select id_chat from chat.users_chats where id_user in" +
                                    "(select id from chat.users where login not in (" + DataLogins + "))) group by id_chat having count(*) = " + (UsersList.Count + 1).ToString();
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

                        MessageBox.Show(insert.ToString());

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString());
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

        public bool ShowUsers(List<string> list, string name,ref int CountUser)//Delete this function
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

        public bool ShowUsers1(List<string> UsersList, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users "+
                                "where id not in (select id from chat.users where login in ("+ GenerateData(UsersList, NameUser) + ")) " +
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
                    return read.Read();//this is part of code dont work//successfully
                }
                catch(Exception error)
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

        public bool ShowUsersChat2(List<string> UsersChatList, int IdChat, ref int CountUser)//Delete this function
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id in(select id_user from chat.users_chats where id_chat=@idchat) order by id";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idchat", IdChat);
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

        public bool ShowUsersDeleteChat(List<string> UsersChat,List<string> DeleteUsersChat, int IdChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where login in ("+GenerateData(UsersChat,"")+") except " +
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

        public bool ShowAllUsersDelete(List<string> UsersChat, List<string> DeleteUsersChat)//rewrite this function
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select * from ( values "+GenerateData(UsersChat,"('","')")+") tlogins(login) except"+
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

        public bool ShowUsersChat1(List<string> UsersChatList, int IdChat, string NameUser)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id in " +
                                    "(select id_user from chat.users_chats where id_user not in" +
                                        "(select id from chat.users where login in ("+GenerateData(UsersChatList,NameUser)+")) " +
                                    "and id_chat=@IdChat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("IdChat",IdChat);

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

        public bool ShowProfileUser(Users u)
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
                    MessageBox.Show(error.ToString());
                    return false;
                }
            }
        }

        public byte[] ShowImageUser(string  name)
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

        public bool UpdateProfileUser(ref string NameUser,string NewNameUser, byte[] ImgArr)
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

        public bool GetNameAdminChat(int IdChat, ref string NameAdminChat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id = (select id_admin from chat.chats where id=@idchat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idchat",IdChat);
                try
                {
                    NameAdminChat = sqlCommand.ExecuteScalar().ToString();
                    return true;
                }
                catch(Exception error)
                {
                    return false;
                }
            }
        }

        public bool SearchUsersAll(List<string> UserList, string LoginUser)
        {                           
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
<<<<<<< HEAD
                string select = "select login from chat.users where login like '%"+LoginUser+"%'";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("userlogin", LoginUser);
=======
                string select = "select login,status from chat.users where login like @userlogin";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("userlogin", "%"+LoginUser+"%");
>>>>>>> 00bf2a38ab13cc78e8c25dddfab3d650227ba6fd
                
                try
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if(Convert.ToBoolean(reader["status"]))
                            UserList.Add(reader["login"].ToString()+" Online");
                        else
                            UserList.Add(reader["login"].ToString());
                    }
                    MessageBox.Show(string.Join(",", UserList.Select(x => x.ToString()).ToArray()));
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString()); ;
                    return false;
                }
            }
        }
    }
} 

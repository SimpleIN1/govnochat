using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace newchat2.ClASSES
{
    class ConnectionWithDb
    {
        private string _connection;
        public static bool check_changed_password = false;

        public ConnectionWithDb(string connection)
        {
            this._connection = @connection;
        }

        public void show_users(ListBox list,string name)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select id,login from chat.users";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select,conn);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                int i = 0;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    //foreach (Object value in row.ItemArray)
                    //{
                    //    list.Items.Add(value);
                    //}
                    if (row.ItemArray[1].ToString()!=name)
                        list.Items.Add(row.ItemArray[1]);
                }
            }
        }

/*херня работает не правильно*/
        public void show_chats(Dictionary<int, string> chatsKeyValuePairs, string name)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                //string select = "select login from chat.users where id in"+ 
                //                 "(select id_user from chat.users_chats where id_chat in"+
                //                  "(select id_chat from chat.users_chats where id_user ="+
                //                            "(select id from chat.users where login = @login))"+
                //                     "group by id_user)"+
                //                    "and id<>(select id from chat.users where login= @login)";
                string select = "select id, chat_name from chat.chats where id in " +
                                    "(select id_chat from chat.users_chats where id_user = " +
                                        "(select id from chat.users where login = @login))";
                SqlCommand sqlCommand = new SqlCommand(select, conn);   
                sqlCommand.Parameters.AddWithValue("login",name);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    //list.Items.Add(sqlDataReader.GetValue(0));
                    //chatsKeyValuePairs.Contains();
                    //Dictionary<int, string> a = new Dictionary<int, string>(Convert.ToInt32(sqlDataReader.GetValue(0)), sqlDataReader.GetValue(1).ToString());
                    if(!chatsKeyValuePairs.ContainsKey(Convert.ToInt32(sqlDataReader.GetValue(0))))
                        chatsKeyValuePairs.Add(Convert.ToInt32(sqlDataReader.GetValue(0)), sqlDataReader.GetValue(1).ToString());                    
                }
            }
        }

        public void insert_user(string name_reg, string password_reg)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                if (name_reg.IndexOf(' ') >= 0 || password_reg.IndexOf(' ') >= 0 || name_reg == "Name" || password_reg=="Password")
                {
                    //name_reg.Text = "Name";
                    //password_reg.PasswordChar = '\0';
                    //password_reg.Text = "Password";   
                    check_changed_password = true;
                    MessageBox.Show("Incorrect name or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //label1.Text = name.Text + " " + password.Text;
                    try
                    {
                        conn.Open();
                        string insert = "insert into chat.users(login,password) values (@login,@password)";
                        SqlCommand sqlCommand = new SqlCommand(insert, conn);

                        sqlCommand.Parameters.AddWithValue("login", name_reg);
                        Crypt passCrypt = new Crypt(password_reg);
                        string passwordCrypt = passCrypt.getEncryptingData();
                        sqlCommand.Parameters.AddWithValue("password", passwordCrypt);


                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("You are registering", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //name_reg.Text = "Name";
                            //password_reg.PasswordChar = '\0';
                            //password_reg.Text = "Password";
                            check_changed_password = true;
                        }

                        catch (Exception error)
                        {
                            MessageBox.Show("User is exist with this nickname", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Trouble with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool insert_message(string nameUser, int idChat, string message)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = "insert into chat.messages (id_user,id_chat,message, date) values ((select id from chat.users where login=@nameu),@idc,@mes,current_timestamp)";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.Parameters.AddWithValue("nameu", nameUser);
                sqlCommand.Parameters.AddWithValue("idc", idChat);
                sqlCommand.Parameters.AddWithValue("mes", message);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void show_messages(int idChat, ListBox list,int count_written)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select * from chat.messages where id_chat=@idc order by date asc";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                //sqlCommand.Parameters.AddWithValue("idu", idUser);
                sqlCommand.Parameters.AddWithValue("idc", idChat);

                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    int count_i = 0;
                    while(sqlDataReader.Read())
                    {
                        if(++count_i>count_written && count_i>list.Items.Count)
                            list.Items.Add(sqlDataReader["message"]);
                    }
                    count_written += (count_i - count_written); 
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        public void login_user(MainPage mainPage,string name, string password)
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
                        mainPage.Visible = false; 
                        Form1 form1 = new Form1(name);
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("wrong a name and password", "Error logIn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Trouble with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void create_chat(string user_name, ListBox list, string chat_name)
        {
            string data_login = "('"+user_name+"'";

            foreach (object element in list.SelectedItems)
            {
                data_login += ",'" + element+"'";
            }
            data_login += ")";


            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select;
                if (list.SelectedItems.Count + 1 == 2)
                {
                    select = "select id_chat, count(id_user) from chat.users_chats where id_user in" +
                                    "(select id from chat.users where login in " + data_login + ") and id_chat not in" +
                                    "(select id_chat from chat.users_chats where id_user in" +
                                    "(select id from chat.users where login not in " + data_login + ")) group by id_chat having count(*) = " + (list.SelectedItems.Count + 1).ToString();
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
                        MessageBox.Show("Chats is exists", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        sqlDataReader.Close();
                        string insert = "declare @idc int;" +
                                        "insert into chat.chats(chat_name,date) values(@name,current_timestamp);" +
                                        "set @idc = SCOPE_IDENTITY();" +
                                        "insert into chat.users_chats(id_user, id_chat)values((select id from chat.users where login = @login0),@idc)";
                        int i = 0;
                        while (i++ < list.SelectedItems.Count)
                        {
                            insert += ",((select id from chat.users where login = @login" + i.ToString() + "),@idc)";
                        }

                        SqlCommand sqlCommand = new SqlCommand(insert, conn);
                        sqlCommand.Parameters.AddWithValue("name", chat_name);
                        sqlCommand.Parameters.AddWithValue("login0", user_name);

                        i = 0;
                        foreach (object element in list.SelectedItems)
                        {
                            i++;
                            sqlCommand.Parameters.AddWithValue("login" + i.ToString(), element);
                        }

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Chat is created", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("Something with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

/*это залупа тоже работает не правильно по отношения к нескольким пользователям*/
        public string get_file_name(int id_chat)
        {
            //create_chat(user_name, user_some);
            string path=null;

            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                //string select = "select name_chat from chat.chats where id =" +
                //                    "(select id_chat from chat.users_chats where id_user in " +
                //                        "(select id from chat.users where login in(@login1,@login2)) " +
                //                    "group by id_chat having COUNT(id_chat)=2 )";
                //SqlCommand sqlCommand = new SqlCommand(select, conn);
                ////sqlCommand.Parameters.AddWithValue("name", name);
                //sqlCommand.Parameters.AddWithValue("login1", user_name);
                //sqlCommand.Parameters.AddWithValue("login2", user_some);

                string select = "select name_chat from chat.chats where id = @id_chat";
                SqlCommand sqlCommand = new SqlCommand(select, conn);

                sqlCommand.Parameters.AddWithValue("id_chat",id_chat);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                    path = sqlDataReader.GetValue(0).ToString();
                //else
                //{
                //    create_chat(user_name, user_some);
                //    path = get_file_name(user_name, user_some);
                //}
            }   
            return path;
        }
    }
}

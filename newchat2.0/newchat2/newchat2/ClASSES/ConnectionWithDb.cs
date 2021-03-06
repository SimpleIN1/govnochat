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
                        string insert = "insert into chat.users(login,password,status) values (@login,@password,0)";
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
                            MessageBox.Show("User exists with this nickname", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string select = "select u.login,m.message,m.image,m.date from chat.messages as m "+
                                " inner join chat.users as u on u.id = m.id_user "+
                                " where m.id_chat=@idc order by date asc;";//"select * from chat.messages where id_chat=@idc order by date asc";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                //sqlCommand.Parameters.AddWithValue("idu", idUser);
                sqlCommand.Parameters.AddWithValue("idc", idChat);
               // l.Text = select;
                try
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    int count_i = 0;
                    while(sqlDataReader.Read())
                    {
                        if(++count_i>count_written && count_i>list.Items.Count)
                            list.Items.Add(sqlDataReader["login"] +" -> "+sqlDataReader["message"]);
                    }
                    count_written += (count_i - count_written); 
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        public void update_status_user(string name,bool status)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string update = "update chat.users set status=@status where login=@login";

                SqlCommand sqlCommand = new SqlCommand(update, conn);
                sqlCommand.Parameters.AddWithValue("status",status);
                sqlCommand.Parameters.AddWithValue("login", name);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        this.update_status_user(name, true);
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

        public void create_chat(string user_name, ListBox list, string chat_name,byte[]image_arr)
        {
            string data_login = "('"+user_name+"'";

            foreach (object element in list.SelectedItems)
            {
                data_login += ",'" + element+"'";
            }
            data_login += ")";


            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Form1.status_user = false;
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
                                        "insert into chat.chats(chat_name,date,id_admin,image) values(@name,current_timestamp,(select id from chat.users where login=@login0),";

                        if (image_arr == null)
                            insert += "null";
                        else
                            insert += "@imagep";

                        insert+=");set @idc = SCOPE_IDENTITY();" +
                        "insert into chat.users_chats(id_user, id_chat,id_person_who_invited)values((select id from chat.users where login = @login0),@idc,(select id from chat.users where login = @login0))";
                        int i = 0;
                        while (i++ < list.SelectedItems.Count)
                        {
                            insert += ",((select id from chat.users where login = @login" + i.ToString() + "),@idc,(select id from chat.users where login = @login0))";
                        }

                        SqlCommand sqlCommand = new SqlCommand(insert, conn);
                        sqlCommand.Parameters.AddWithValue("name", chat_name);
                        sqlCommand.Parameters.AddWithValue("login0", user_name);

                        if(image_arr!=null)
                            sqlCommand.Parameters.AddWithValue("imagep", image_arr);

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
                    MessageBox.Show("Something with connection or\n"+error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public byte[] show_image(int id_chat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string select_image = "select image from chat.chats where id = @id_chat";
                SqlCommand sqlCommand = new SqlCommand(select_image, conn);
                sqlCommand.Parameters.AddWithValue("id_chat",id_chat);

                try
                {
                    return (byte[])sqlCommand.ExecuteScalar();

                }
                catch(Exception error)
                {
                    return null;
                }
            }
        }
        /*это залупа тоже работает не правильно по отношения к нескольким пользователям*/
        public void show_users_chat(ListBox list_user,int id_chat)
        {
            using (SqlConnection conn=new SqlConnection(_connection))
            {
                conn.Open();
                string select = "select login from chat.users where id in(select id_user from chat.users_chats where id_chat=@idchat)";
                SqlCommand sqlCommand = new SqlCommand(select, conn);
                sqlCommand.Parameters.AddWithValue("idchat",id_chat);
                try
                {
                    SqlDataReader read = sqlCommand.ExecuteReader();
                    read.Read();

                    int count_i = 0;
                    while (read.Read())
                    {
                        if (++count_i > list_user.Items.Count)
                            list_user.Items.Add(read["login"]);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("error in add user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 

        public bool delete_user(string name_user,int id_chat, string your_name)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string delete = "delete from chat.users_chats where id_chat=@idchat and id_user in (select id from chat.users where login in ("+name_user+")) and (id_person_who_invited=(select id from chat.users where login=@y_name) or id_chat=(select id from chat.chats where id_admin=(select id from chat.users where login=(select id from chat.users where login=@y_name))))";
                SqlCommand sqlCommand = new SqlCommand(delete, conn);
                sqlCommand.Parameters.AddWithValue("idchat", id_chat);
                sqlCommand.Parameters.AddWithValue("y_name", your_name);
                try
                {
                    sqlCommand.ExecuteReader();
                    return true;
                }
                catch (Exception error)
                {
                    
                    MessageBox.Show("You can not delete the user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool add_user_chat(List<string> users_list, string name_user, int id_chat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();

                string insert_user = "insert into chat.users_chats(id_user, id_chat,id_person_who_invited) values ";
                int count_sep = 0;
                foreach (object item in users_list)
                {
                    insert_user += "((select id from chat.users where login ='" + item.ToString() + "'),@idchat,(select id from chat.users where login = @uname))";
                    if (++count_sep < users_list.Count)
                        insert_user += ",";
                } 

                SqlCommand sqlCommand = new SqlCommand(insert_user, conn);
                sqlCommand.Parameters.AddWithValue("idchat",id_chat);
                sqlCommand.Parameters.AddWithValue("uname", name_user);

                try
                {
                    sqlCommand.ExecuteReader();
                    return true;
                }
                catch (Exception error)
                {

                    MessageBox.Show("Person is added", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool update_chat_image_name(byte[] img_arr, string chat_name, int id_chat)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                conn.Open();
                string insert = " update chat.chats set chat_name=@chatname, image=@img where id=@idchat";
                SqlCommand sqlCommand = new SqlCommand(insert,conn);
                sqlCommand.Parameters.AddWithValue("chatname",chat_name);
                sqlCommand.Parameters.AddWithValue("idchat",id_chat);
                sqlCommand.Parameters.AddWithValue("img", img_arr);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}

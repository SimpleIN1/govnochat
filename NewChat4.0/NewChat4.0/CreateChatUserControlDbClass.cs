using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewChat4._0
{
    class CreateChatUserControlDbClass
    {
        private string _connection;
        public CreateChatUserControlDbClass(string connection)
        {
            this._connection = connection;
        }

        public bool ShowUsers1(List<string> UsersList, string NameUser)
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

        public bool CreateChat(string UserName, List<string> UsersList, string ChatName, byte[] ImageArr, ref string errorStr)
        {
            string DataLogins = ChatFormUserControlDbClass.GenerateData(UsersList, UserName);/*"("+UsersList.Join(',') + ")" //*/

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

                        //MessageBox.Show(insert.ToString());

                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception error)
                        {
                            //MessageBox.Show(error.ToString());
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
    }
}

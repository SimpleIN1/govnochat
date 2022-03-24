using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using MaterialSkin.Controls;
using System.Net;
using newchat2.ClASSES;
using MaterialSkin;

namespace newchat2
{
    public partial class Form1 : Form
    {
        ConnectionWithDb connectionWithDb = new ConnectionWithDb(MainPage.connection);
        private string _path_to_file = null;
        private static int _count_written = 0;
        private string _name_user;
        private int _id_chat;
        int _count_second = 0;
        Dictionary<int, string> chatsKeyValuePairs = new Dictionary<int, string>();
        //int[] setKey = null;
        //List<int> setKey = new List<int>();
        //Dictionary<int, string>[] setChatsKeyValuePairs;  
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string name_user)
        {
            this._name_user = name_user;
            InitializeComponent();
        }
        private void fileRead()
        {
            if (_path_to_file != null)
            {
                label4.Text = _path_to_file;
                using (FileStream fout = new FileStream(_path_to_file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader str1 = new StreamReader(fout))
                    {
                        string s;
                        int i_count = 0;
                        while ((s = str1.ReadLine()) != null)
                            if (++i_count > _count_written) { listBox1.Items.Add(s); label4.Text = Convert.ToString(i_count); }
                        _count_written += (i_count - _count_written);
                    }
                }
            }
        }

        private void fileWrite()
        {
            if (_path_to_file != null)
            {
                FileStream fin;
                try
                {
                    fin = new FileStream(_path_to_file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    // C:/Users/griha/Desktop/data.txt
                }
                catch (IOException err)
                {
                    MessageBox.Show(Convert.ToString(err));
                    return;
                }
                using (StreamWriter str1 = new StreamWriter(fin))
                {
                    if (message.Text != "Message")
                    {
                        str1.Write(_name_user + " -> " + message.Text + '\n');
                        listBox1.Items.Add(_name_user + " -> " + message.Text + '\n');
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        ++_count_written;
                    }
                    else
                        MessageBox.Show("Enter something!");
                }
                fin.Close();
            }
        }

        private void download_file_from_ftp()
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://rudy.zzz.com.ua/wwwgos.zzz.com.ua/test/data.txt");

            request.Method = WebRequestMethods.Ftp.DownloadFile;
            //request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("myhost1", "Prq2pw_5zzz");

            //using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            //{
            //    Stream responseto = response.GetResponseStream();

            //}

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Stream responseStream = response.GetResponseStream();
                using (FileStream fs = new FileStream("../../DATA/data.txt", FileMode.Create))
                {
                    byte[] buffer = new byte[64];
                    int size = 0;
                    while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        fs.Write(buffer, 0, size);
                }
            }

        }

        private void upload_file_to_ftp()
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://rudy.zzz.com.ua/wwwgos.zzz.com.ua/test/data.txt");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("myhost1", "Prq2pw_5zzz");

            using (FileStream fs = new FileStream("../../DATA/data.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Write(buffer, 0, buffer.Length);
                request.ContentLength = buffer.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        //public delegate void ParameterizedThreadStart(object obj);

        //Thread new_thread = new Thread(delegate() { fileRead(sender,e); });// для создания потока принимающий функцию с параметрами
        private void Form1_Load(object sender, EventArgs e)
        {
            //label2.Text = listBox2.Items.Count.ToString();

            //fileRead();
            //connectionWithDb.show_chats(listBox2,_name_user);
            intrvled_show_chats();
            message.Enabled = false;
            send_message.Enabled = false;
            //send_message.
            //label2.Text = listBox2.Items.Count.ToString();
            //foreach (object v in listBox2.Items)
            //    label2.Text += v.ToString() + '\n';
            //comboBox1.DrawItem.
            //listView1.Items.Clear();
            //for (int i = 0; i < 11; ++i)
            //{
            //    ListViewItem l = new ListViewItem();
            //    l.ImageIndex = i;
            //    listView1.Items.Add(l);
            //}



        }

        private void send_message_Click(object sender, EventArgs e)
        {
            //fileWrite();
            
            if(connectionWithDb.insert_message(_name_user, _id_chat, message.Text))
            { 
                listBox1.Items.Add(_name_user+" -> "+message.Text);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                ++_count_written;
            }
            
            //fileRead();
            //upload_file_to_ftp();
            //download_file_from_ftp();
        }

        private void create_chat_Click(object sender, EventArgs e)
        {
            //label4.Text = listBox2.SelectedItems.Contains.ToString();
            CreateChat createChat = new CreateChat(_name_user);
            createChat.Show();
        }


        private void intrvled_show_chats()
        {
            connectionWithDb.show_chats(chatsKeyValuePairs, _name_user);
            foreach (var element in chatsKeyValuePairs)
            {
                //if (!setChatsKeyValuePairs.Contains(element))
                //{
                //if(!setKey.Contains(element.Key))
                //    setKey.Append(element.Key);
                listBox2.Items.Add(element.Value);
                //}
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fileRead();
            connectionWithDb.show_messages(_id_chat,listBox1,_count_written);
            
            if (_count_second++ > 10)
            {
                listBox2.Items.Clear();
                _count_second = 0;
                //connectionWithDb.show_chats(listBox2, _name_user);
                intrvled_show_chats();
            }
            //label4.Text = (10).ToString();
            //connectionWithDb.show_chats(listBox2, _name_user);
            //download_file_from_ftp();
            //upload_file_to_ftp(); 
        }

        private void message_Enter(object sender, EventArgs e)
        {
            if (message.Text == "Message")
                message.Text = "";
        }

        private void message_Leave(object sender, EventArgs e)
        {
            if (message.Text == "")
                message.Text = "Message";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string name = listBox2.SelectedItem.ToString();
            //label2.Text = listBox2.Items.Count.ToString();
            //if (listBox2.Items.Contains(listBox2.SelectedItem))
            //{
            //    _count_written = 0;
            //    listBox1.Items.Clear();
            //    _path_to_file = "//DESKTOP-H4QAP6P/temp/" + _name_user + "_" + name + ".txt";
            //    if(!File.Exists(_path_to_file))
            //        _path_to_file = "//DESKTOP-H4QAP6P/temp/" + name + "_" + _name_user + ".txt";
            //    //filenotfoundexception filenotfoundexception = new filenotfoundexception(_path_to_file);
            //    //filenotfoundexception.
            //}

            //\\DESKTOP-H4QAP6P
            //T:/!/ЯРЫГИ/r.txt
            //"DESKTOP-H4QAP6P/temp/data.txt"

            //if (listBox2.SelectedItem!=null)//проверка, что нажат элемент listbox
            //{
            //    _count_written = 0;
            //    listBox1.Items.Clear();
            //    _path_to_file = "T:/!/ЯРЫГИ/temp_chats/" + connectionWithDb.get_file_name(chatsKeyValuePairs.ElementAt(listBox2.SelectedIndex).Key);
            //}

            //label4.Text = chatsKeyValuePairs.ElementAt(listBox2.SelectedIndex).Key.ToString();//setKey[listBox2.SelectedIndex].ToString();
            //label4.Text = listBox2.SelectedIndex.ToString();
            //label1.Text = name;
            if (listBox2.SelectedItem != null)
            {
                _count_written = 0;
                listBox1.Items.Clear();
                message.Enabled = true;
                send_message.Enabled = true;
                _id_chat = chatsKeyValuePairs.ElementAt(listBox2.SelectedIndex).Key;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectionWithDb.update_status_user(_name_user, false);
            this.Close();
            MainPage s = new MainPage();
            s.Show();
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                send_message.PerformClick();
            }
        }

        private void edit_chat_button_Click(object sender, EventArgs e)
        {
            Edit_chat edit_Chat = new Edit_chat(_id_chat, _name_user);
            edit_Chat.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionWithDb.update_status_user(_name_user, false);
        }
    }
}

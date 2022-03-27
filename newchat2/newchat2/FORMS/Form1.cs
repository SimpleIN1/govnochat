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
        private static int _count_written = 0;
        private string _name_user;
        private int _id_chat;
        int _count_second = 0;
        private Dictionary<int, string> chatsKeyValuePairs = new Dictionary<int, string>();
        private List<int> key_chats = new List<int>();
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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void intrvled_show_chats()
        {
            connectionWithDb.show_chats(chatsKeyValuePairs, _name_user);
            foreach (var element in chatsKeyValuePairs)
            {
                //if (!setChatsKeyValuePairs.Contains(element))
                //{
                //if(!setKey.Contains(element.Key))
                //    setKey.Append(element.Key);
                if (!key_chats.Contains(element.Key))
                {
                    key_chats.Add(element.Key);
                   // listBox2.Items.Add(element.Value);
                    chatNameComboBox.Items.Add(element.Value);
                }

                //}
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fileRead();
            connectionWithDb.show_messages(_id_chat,listBox1,_count_written);
            
            if (_count_second++ > 10)
            {
                //listBox2.Items.Clear();
                //chatNameComboBox.Items.Clear();
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

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                send_message.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionWithDb.update_status_user(_name_user, false);
        }

        private void chatNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chatNameComboBox.SelectedItem != null)
            {
                _count_written = 0;
                listBox1.Items.Clear();
                message.Enabled = true;
                send_message.Enabled = true;
                _id_chat = chatsKeyValuePairs.ElementAt(chatNameComboBox.SelectedIndex).Key;

                byte[] arr_image;
                if((arr_image = connectionWithDb.show_image(_id_chat)) !=null)
                {
                    MemoryStream streamImg = new MemoryStream(arr_image);
                    //Image image = Image.FromStream(streamImg);
                    pictureBox1.Image = Image.FromStream(streamImg);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void create_chat_button_Click(object sender, EventArgs e)
        {
            CreateChat createChat = new CreateChat(_name_user);
            createChat.Show();
        }

        private void edit_chat_button_Click(object sender, EventArgs e)
        {
            Edit_chat edit_Chat = new Edit_chat(_id_chat, _name_user);
            edit_Chat.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            connectionWithDb.update_status_user(_name_user, false);
            this.Close();
            MainPage s = new MainPage();
            s.Show();
        }

    }
}

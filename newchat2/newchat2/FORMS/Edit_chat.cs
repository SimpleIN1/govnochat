using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newchat2
{
    public partial class Edit_chat : Form
    {
        private int _id_chat;
        private string _name_user;
        public Edit_chat(int id_chat, string name_user)
        {
            InitializeComponent();
            this._id_chat = id_chat;
            this._name_user = name_user;
        }

    }
}

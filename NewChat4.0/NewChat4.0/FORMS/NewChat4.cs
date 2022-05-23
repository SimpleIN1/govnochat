using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewChat4._0
{
    public partial class NewChat4 : Form
    {
        public NewChat4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewChat4Panel.Controls.Add(new MainPageUserControl(NewChat4Panel));
        }

        private void NewChat4_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPageUserControl.CheckStatusEnterExitUser(false);
        }
    }
}


namespace newchat2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.send_message = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.create_chat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.Location = new System.Drawing.Point(180, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 316);
            this.listBox1.TabIndex = 0;
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(370, 398);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(159, 20);
            this.send_message.TabIndex = 1;
            this.send_message.Text = "send";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Window;
            this.message.Location = new System.Drawing.Point(180, 398);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(184, 20);
            this.message.TabIndex = 2;
            this.message.Text = "Message";
            this.message.Enter += new System.EventHandler(this.message_Enter);
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            this.message.Leave += new System.EventHandler(this.message_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME IN NEW CHAT";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.AccessibleDescription = "";
            this.listBox2.BackColor = System.Drawing.SystemColors.Window;
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(39, 76);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(135, 316);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // create_chat
            // 
            this.create_chat.Location = new System.Drawing.Point(39, 398);
            this.create_chat.Name = "create_chat";
            this.create_chat.Size = new System.Drawing.Size(135, 20);
            this.create_chat.TabIndex = 10;
            this.create_chat.Text = "Create chat";
            this.create_chat.UseVisualStyleBackColor = true;
            this.create_chat.Click += new System.EventHandler(this.create_chat_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::newchat2.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(483, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 48);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2.png");
            this.imageList1.Images.SetKeyName(1, "3.png");
            this.imageList1.Images.SetKeyName(2, "4.png");
            this.imageList1.Images.SetKeyName(3, "5.png");
            this.imageList1.Images.SetKeyName(4, "6.png");
            this.imageList1.Images.SetKeyName(5, "7.png");
            this.imageList1.Images.SetKeyName(6, "8.png");
            this.imageList1.Images.SetKeyName(7, "9.png");
            this.imageList1.Images.SetKeyName(8, "10.png");
            this.imageList1.Images.SetKeyName(9, "11.png");
            this.imageList1.Images.SetKeyName(10, "12.png");
            this.imageList1.Images.SetKeyName(11, "13.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 518);
            this.Controls.Add(this.create_chat);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button create_chat;
        private System.Windows.Forms.ImageList imageList1;
    }
}



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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chatNameComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.profile_button = new System.Windows.Forms.ToolStripButton();
            this.edit_chat_button = new System.Windows.Forms.ToolStripButton();
            this.create_chat_button = new System.Windows.Forms.ToolStripButton();
            this.exit_button = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 308);
            this.listBox1.TabIndex = 0;
            // 
            // send_message
            // 
            this.send_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_message.Location = new System.Drawing.Point(260, 406);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(101, 26);
            this.send_message.TabIndex = 1;
            this.send_message.Text = "send";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Window;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(12, 406);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(242, 24);
            this.message.TabIndex = 2;
            this.message.Text = "Message";
            this.message.Enter += new System.EventHandler(this.message_Enter);
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            this.message.Leave += new System.EventHandler(this.message_Leave);
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
            this.label4.Location = new System.Drawing.Point(442, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
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
            // chatNameComboBox
            // 
            this.chatNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatNameComboBox.FormattingEnabled = true;
            this.chatNameComboBox.Location = new System.Drawing.Point(158, 40);
            this.chatNameComboBox.Name = "chatNameComboBox";
            this.chatNameComboBox.Size = new System.Drawing.Size(120, 26);
            this.chatNameComboBox.TabIndex = 12;
            this.chatNameComboBox.SelectedIndexChanged += new System.EventHandler(this.chatNameComboBox_SelectedIndexChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profile_button,
            this.edit_chat_button,
            this.create_chat_button,
            this.exit_button});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(394, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(93, 443);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.profile_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.profile_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profile_button.Image = ((System.Drawing.Image)(resources.GetObject("profile_button.Image")));
            this.profile_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(90, 25);
            this.profile_button.Text = "Profile";
            // 
            // edit_chat_button
            // 
            this.edit_chat_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.edit_chat_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_chat_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_chat_button.Image")));
            this.edit_chat_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_chat_button.Name = "edit_chat_button";
            this.edit_chat_button.Size = new System.Drawing.Size(90, 25);
            this.edit_chat_button.Text = "Edit chat";
            this.edit_chat_button.Click += new System.EventHandler(this.edit_chat_button_Click);
            // 
            // create_chat_button
            // 
            this.create_chat_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.create_chat_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.create_chat_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_chat_button.Image = ((System.Drawing.Image)(resources.GetObject("create_chat_button.Image")));
            this.create_chat_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.create_chat_button.Name = "create_chat_button";
            this.create_chat_button.Size = new System.Drawing.Size(90, 25);
            this.create_chat_button.Text = "Create chat";
            this.create_chat_button.Click += new System.EventHandler(this.create_chat_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exit_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(90, 52);
            this.exit_button.Text = "toolStripButton3";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 71);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chat name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chatNameComboBox);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.message);
            this.Name = "Form1";
            this.Text = "+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox chatNameComboBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton create_chat_button;
        private System.Windows.Forms.ToolStripButton edit_chat_button;
        private System.Windows.Forms.ToolStripButton profile_button;
        private System.Windows.Forms.ToolStripButton exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}


namespace NewChat4._0
{
    partial class EditChatUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditChatUserControl));
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.LeaveTheChatButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AllUsersListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ParticipantsListBox = new System.Windows.Forms.ListBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.NameChatTextBox = new System.Windows.Forms.TextBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ParticipantAllUserToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.AutoSize = true;
            this.AdminNameLabel.BackColor = System.Drawing.Color.White;
            this.AdminNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.AdminNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdminNameLabel.Location = new System.Drawing.Point(181, 96);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(45, 16);
            this.AdminNameLabel.TabIndex = 27;
            this.AdminNameLabel.Text = "label1";
            // 
            // LeaveTheChatButton
            // 
            this.LeaveTheChatButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.LeaveTheChatButton.Location = new System.Drawing.Point(293, 201);
            this.LeaveTheChatButton.Name = "LeaveTheChatButton";
            this.LeaveTheChatButton.Size = new System.Drawing.Size(97, 31);
            this.LeaveTheChatButton.TabIndex = 26;
            this.LeaveTheChatButton.Text = "LeaveTheChat";
            this.LeaveTheChatButton.UseVisualStyleBackColor = true;
            this.LeaveTheChatButton.Click += new System.EventHandler(this.LeaveTheChatButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(400, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(191, 264);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddUserButton);
            this.tabPage1.Controls.Add(this.AllUsersListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(183, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.AddUserButton.Location = new System.Drawing.Point(25, 207);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(136, 24);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AllUsersListBox
            // 
            this.AllUsersListBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.AllUsersListBox.FormattingEnabled = true;
            this.AllUsersListBox.ItemHeight = 16;
            this.AllUsersListBox.Location = new System.Drawing.Point(13, 5);
            this.AllUsersListBox.Name = "AllUsersListBox";
            this.AllUsersListBox.Size = new System.Drawing.Size(159, 196);
            this.AllUsersListBox.TabIndex = 0;
            this.AllUsersListBox.DoubleClick += new System.EventHandler(this.AllUsersListBox_DoubleClick);
            this.AllUsersListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllUsersListBox_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteButton);
            this.tabPage2.Controls.Add(this.ParticipantsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(183, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participants of chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(23, 207);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(136, 24);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete user";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ParticipantsListBox
            // 
            this.ParticipantsListBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParticipantsListBox.FormattingEnabled = true;
            this.ParticipantsListBox.ItemHeight = 16;
            this.ParticipantsListBox.Location = new System.Drawing.Point(12, 6);
            this.ParticipantsListBox.Name = "ParticipantsListBox";
            this.ParticipantsListBox.Size = new System.Drawing.Size(159, 196);
            this.ParticipantsListBox.TabIndex = 1;
            this.ParticipantsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ParticipantsListBox_KeyDown);
            this.ParticipantsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ParticipantsListBox_MouseDoubleClick);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ChangeButton.Location = new System.Drawing.Point(184, 322);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(210, 30);
            this.ChangeButton.TabIndex = 24;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChatNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ChatNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ChatNameLabel.Location = new System.Drawing.Point(303, 124);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(79, 16);
            this.ChatNameLabel.TabIndex = 23;
            this.ChatNameLabel.Text = "Chat Name:";
            // 
            // NameChatTextBox
            // 
            this.NameChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameChatTextBox.Location = new System.Drawing.Point(293, 168);
            this.NameChatTextBox.Name = "NameChatTextBox";
            this.NameChatTextBox.Size = new System.Drawing.Size(98, 20);
            this.NameChatTextBox.TabIndex = 22;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImageLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ImageLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ImageLabel.Location = new System.Drawing.Point(208, 124);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(47, 16);
            this.ImageLabel.TabIndex = 21;
            this.ImageLabel.Text = "Image";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePictureBox.Location = new System.Drawing.Point(184, 149);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(101, 94);
            this.ImagePictureBox.TabIndex = 20;
            this.ImagePictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(722, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 35);
            this.CloseButton.TabIndex = 28;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AdminNameLabel);
            this.Controls.Add(this.LeaveTheChatButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.NameChatTextBox);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "EditChatUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.EditProfileUserControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.Button LeaveTheChatButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.ListBox AllUsersListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox ParticipantsListBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChatNameLabel;
        private System.Windows.Forms.TextBox NameChatTextBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.ToolTip ParticipantAllUserToolTip;
        private System.Windows.Forms.Button CloseButton;
    }
}

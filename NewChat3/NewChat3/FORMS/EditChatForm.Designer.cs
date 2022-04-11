namespace NewChat3
{
    partial class EditChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(166, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(158, 264);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddUserButton);
            this.tabPage1.Controls.Add(this.AllUsersListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(150, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(6, 210);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(136, 24);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AllUsersListBox
            // 
            this.AllUsersListBox.FormattingEnabled = true;
            this.AllUsersListBox.Location = new System.Drawing.Point(6, 6);
            this.AllUsersListBox.Name = "AllUsersListBox";
            this.AllUsersListBox.Size = new System.Drawing.Size(137, 199);
            this.AllUsersListBox.TabIndex = 0;
            this.AllUsersListBox.DoubleClick += new System.EventHandler(this.AllUsersListBox_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteButton);
            this.tabPage2.Controls.Add(this.ParticipantsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(150, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participants of chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(6, 210);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(136, 24);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete user";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ParticipantsListBox
            // 
            this.ParticipantsListBox.FormattingEnabled = true;
            this.ParticipantsListBox.Location = new System.Drawing.Point(6, 6);
            this.ParticipantsListBox.Name = "ParticipantsListBox";
            this.ParticipantsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ParticipantsListBox.Size = new System.Drawing.Size(137, 199);
            this.ParticipantsListBox.TabIndex = 1;
            this.ParticipantsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ParticipantsListBox_MouseDoubleClick);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(26, 303);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(301, 30);
            this.ChangeButton.TabIndex = 16;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChatNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatNameLabel.Location = new System.Drawing.Point(47, 193);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(60, 13);
            this.ChatNameLabel.TabIndex = 15;
            this.ChatNameLabel.Text = "Chat Name";
            // 
            // NameChatTextBox
            // 
            this.NameChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameChatTextBox.Location = new System.Drawing.Point(26, 214);
            this.NameChatTextBox.Name = "NameChatTextBox";
            this.NameChatTextBox.Size = new System.Drawing.Size(109, 20);
            this.NameChatTextBox.TabIndex = 14;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageLabel.Location = new System.Drawing.Point(57, 35);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 13;
            this.ImageLabel.Text = "Image";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePictureBox.Location = new System.Drawing.Point(26, 51);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(109, 94);
            this.ImagePictureBox.TabIndex = 12;
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // EditChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 357);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.NameChatTextBox);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "EditChatForm";
            this.Text = "Edit chat";
            this.Load += new System.EventHandler(this.EditChatForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}
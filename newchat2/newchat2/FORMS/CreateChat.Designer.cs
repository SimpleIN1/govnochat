namespace newchat2
{
    partial class CreateChat
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
            this.users_ListBox = new System.Windows.Forms.ListBox();
            this.name_chat_txt = new System.Windows.Forms.TextBox();
            this.create_chat = new System.Windows.Forms.Button();
            this.chat_name_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // users_ListBox
            // 
            this.users_ListBox.FormattingEnabled = true;
            this.users_ListBox.Location = new System.Drawing.Point(12, 12);
            this.users_ListBox.Name = "users_ListBox";
            this.users_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.users_ListBox.Size = new System.Drawing.Size(162, 303);
            this.users_ListBox.TabIndex = 0;
            this.users_ListBox.SelectedIndexChanged += new System.EventHandler(this.users_ListBox_SelectedIndexChanged);
            // 
            // name_chat_txt
            // 
            this.name_chat_txt.Location = new System.Drawing.Point(181, 116);
            this.name_chat_txt.Name = "name_chat_txt";
            this.name_chat_txt.Size = new System.Drawing.Size(100, 20);
            this.name_chat_txt.TabIndex = 1;
            // 
            // create_chat
            // 
            this.create_chat.Location = new System.Drawing.Point(181, 142);
            this.create_chat.Name = "create_chat";
            this.create_chat.Size = new System.Drawing.Size(100, 30);
            this.create_chat.TabIndex = 2;
            this.create_chat.Text = "Create";
            this.create_chat.UseVisualStyleBackColor = true;
            this.create_chat.Click += new System.EventHandler(this.create_chat_Click);
            // 
            // chat_name_label1
            // 
            this.chat_name_label1.AutoSize = true;
            this.chat_name_label1.Location = new System.Drawing.Point(201, 100);
            this.chat_name_label1.Name = "chat_name_label1";
            this.chat_name_label1.Size = new System.Drawing.Size(60, 13);
            this.chat_name_label1.TabIndex = 3;
            this.chat_name_label1.Text = "Chat Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // CreateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chat_name_label1);
            this.Controls.Add(this.create_chat);
            this.Controls.Add(this.name_chat_txt);
            this.Controls.Add(this.users_ListBox);
            this.Name = "CreateChat";
            this.Text = "CreateChat";
            this.Load += new System.EventHandler(this.CreateChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox users_ListBox;
        private System.Windows.Forms.TextBox name_chat_txt;
        private System.Windows.Forms.Button create_chat;
        private System.Windows.Forms.Label chat_name_label1;
        private System.Windows.Forms.Label label1;
    }
}
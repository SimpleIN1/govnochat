
namespace newchat2
{
    partial class Edit_chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_chat));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chat_name_label1 = new System.Windows.Forms.Label();
            this.name_chat_txt = new System.Windows.Forms.TextBox();
            this.Change_Button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_user_button = new System.Windows.Forms.Button();
            this.All_Users_ListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_button = new System.Windows.Forms.Button();
            this.Participants_ListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 94);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chat_name_label1
            // 
            this.chat_name_label1.AutoSize = true;
            this.chat_name_label1.BackColor = System.Drawing.Color.Transparent;
            this.chat_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_name_label1.Location = new System.Drawing.Point(33, 144);
            this.chat_name_label1.Name = "chat_name_label1";
            this.chat_name_label1.Size = new System.Drawing.Size(83, 18);
            this.chat_name_label1.TabIndex = 9;
            this.chat_name_label1.Text = "Chat Name";
            // 
            // name_chat_txt
            // 
            this.name_chat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_chat_txt.Location = new System.Drawing.Point(12, 165);
            this.name_chat_txt.Name = "name_chat_txt";
            this.name_chat_txt.Size = new System.Drawing.Size(116, 24);
            this.name_chat_txt.TabIndex = 8;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(12, 292);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(299, 30);
            this.Change_Button.TabIndex = 10;
            this.Change_Button.Text = "Change";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(152, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(156, 264);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add_user_button);
            this.tabPage1.Controls.Add(this.All_Users_ListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(148, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(6, 210);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(136, 24);
            this.add_user_button.TabIndex = 1;
            this.add_user_button.Text = "add";
            this.add_user_button.UseVisualStyleBackColor = true;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // All_Users_ListBox
            // 
            this.All_Users_ListBox.FormattingEnabled = true;
            this.All_Users_ListBox.Location = new System.Drawing.Point(6, 6);
            this.All_Users_ListBox.Name = "All_Users_ListBox";
            this.All_Users_ListBox.Size = new System.Drawing.Size(137, 199);
            this.All_Users_ListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_button);
            this.tabPage2.Controls.Add(this.Participants_ListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(148, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participants of chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(6, 210);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(136, 24);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Delete user";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Participants_ListBox
            // 
            this.Participants_ListBox.FormattingEnabled = true;
            this.Participants_ListBox.Location = new System.Drawing.Point(6, 6);
            this.Participants_ListBox.Name = "Participants_ListBox";
            this.Participants_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Participants_ListBox.Size = new System.Drawing.Size(137, 199);
            this.Participants_ListBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Edit_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(320, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.chat_name_label1);
            this.Controls.Add(this.name_chat_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Edit_chat";
            this.Text = "Edit_chat";
            this.Load += new System.EventHandler(this.Edit_chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label chat_name_label1;
        private System.Windows.Forms.TextBox name_chat_txt;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.ListBox All_Users_ListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListBox Participants_ListBox;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace NewChat3
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.NamePageTextBox = new System.Windows.Forms.TextBox();
            this.DeletePageButton = new System.Windows.Forms.Button();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.NamePageLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(12, 39);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(135, 126);
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // NamePageTextBox
            // 
            this.NamePageTextBox.Location = new System.Drawing.Point(153, 61);
            this.NamePageTextBox.Name = "NamePageTextBox";
            this.NamePageTextBox.Size = new System.Drawing.Size(116, 20);
            this.NamePageTextBox.TabIndex = 8;
            // 
            // DeletePageButton
            // 
            this.DeletePageButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.DeletePageButton.Location = new System.Drawing.Point(162, 139);
            this.DeletePageButton.Name = "DeletePageButton";
            this.DeletePageButton.Size = new System.Drawing.Size(98, 26);
            this.DeletePageButton.TabIndex = 9;
            this.DeletePageButton.Text = "Delete your page";
            this.DeletePageButton.UseVisualStyleBackColor = true;
            this.DeletePageButton.Click += new System.EventHandler(this.DeletePageButton_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ImageLabel.Location = new System.Drawing.Point(58, 20);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(47, 16);
            this.ImageLabel.TabIndex = 10;
            this.ImageLabel.Text = "Image";
            // 
            // NamePageLabel
            // 
            this.NamePageLabel.AutoSize = true;
            this.NamePageLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.NamePageLabel.Location = new System.Drawing.Point(153, 42);
            this.NamePageLabel.Name = "NamePageLabel";
            this.NamePageLabel.Size = new System.Drawing.Size(116, 16);
            this.NamePageLabel.TabIndex = 11;
            this.NamePageLabel.Text = "Change nickname";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ChangeButton.Location = new System.Drawing.Point(88, 199);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(122, 39);
            this.ChangeButton.TabIndex = 12;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(277, 265);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NamePageLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.DeletePageButton);
            this.Controls.Add(this.NamePageTextBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "EditProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.EditProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.TextBox NamePageTextBox;
        private System.Windows.Forms.Button DeletePageButton;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Label NamePageLabel;
        private System.Windows.Forms.Button ChangeButton;
    }
}
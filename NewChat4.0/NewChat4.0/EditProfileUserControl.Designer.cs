namespace NewChat4._0
{
    partial class EditProfileUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileUserControl));
            this.ChangeButton = new System.Windows.Forms.Button();
            this.NamePageLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.DeletePageButton = new System.Windows.Forms.Button();
            this.NamePageTextBox = new System.Windows.Forms.TextBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ChangeButton.Location = new System.Drawing.Point(334, 298);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(122, 39);
            this.ChangeButton.TabIndex = 18;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // NamePageLabel
            // 
            this.NamePageLabel.AutoSize = true;
            this.NamePageLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.NamePageLabel.Location = new System.Drawing.Point(399, 141);
            this.NamePageLabel.Name = "NamePageLabel";
            this.NamePageLabel.Size = new System.Drawing.Size(116, 16);
            this.NamePageLabel.TabIndex = 17;
            this.NamePageLabel.Text = "Change nickname";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ImageLabel.Location = new System.Drawing.Point(304, 119);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(47, 16);
            this.ImageLabel.TabIndex = 16;
            this.ImageLabel.Text = "Image";
            // 
            // DeletePageButton
            // 
            this.DeletePageButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.DeletePageButton.Location = new System.Drawing.Point(408, 238);
            this.DeletePageButton.Name = "DeletePageButton";
            this.DeletePageButton.Size = new System.Drawing.Size(158, 26);
            this.DeletePageButton.TabIndex = 15;
            this.DeletePageButton.Text = "Delete your page";
            this.DeletePageButton.UseVisualStyleBackColor = true;
            this.DeletePageButton.Click += new System.EventHandler(this.DeletePageButton_Click);
            // 
            // NamePageTextBox
            // 
            this.NamePageTextBox.Location = new System.Drawing.Point(399, 160);
            this.NamePageTextBox.Name = "NamePageTextBox";
            this.NamePageTextBox.Size = new System.Drawing.Size(116, 20);
            this.NamePageTextBox.TabIndex = 14;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(258, 138);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(135, 126);
            this.ImagePictureBox.TabIndex = 13;
            this.ImagePictureBox.TabStop = false;
            this.ImagePictureBox.Click += new System.EventHandler(this.ImagePictureBox_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(722, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 35);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.NamePageLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.DeletePageButton);
            this.Controls.Add(this.NamePageTextBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "EditProfileUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.EditProfileUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label NamePageLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button DeletePageButton;
        private System.Windows.Forms.TextBox NamePageTextBox;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button CloseButton;
    }
}


namespace newchat2
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.enter_Btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.regGroupBox = new System.Windows.Forms.GroupBox();
            this.register_Btn = new System.Windows.Forms.Button();
            this.name_reg = new System.Windows.Forms.TextBox();
            this.password_reg = new System.Windows.Forms.TextBox();
            this.LoginGroupBox.SuspendLayout();
            this.regGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginGroupBox.Controls.Add(this.enter_Btn);
            this.LoginGroupBox.Controls.Add(this.password);
            this.LoginGroupBox.Controls.Add(this.name);
            this.LoginGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(374, 125);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(141, 134);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "LogIn";
            // 
            // enter_Btn
            // 
            this.enter_Btn.Location = new System.Drawing.Point(23, 80);
            this.enter_Btn.Name = "enter_Btn";
            this.enter_Btn.Size = new System.Drawing.Size(96, 23);
            this.enter_Btn.TabIndex = 2;
            this.enter_Btn.Text = "Enter";
            this.enter_Btn.UseVisualStyleBackColor = true;
            this.enter_Btn.Click += new System.EventHandler(this.enter_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(23, 50);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 27);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(23, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 27);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // regGroupBox
            // 
            this.regGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.regGroupBox.Controls.Add(this.register_Btn);
            this.regGroupBox.Controls.Add(this.name_reg);
            this.regGroupBox.Controls.Add(this.password_reg);
            this.regGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.regGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regGroupBox.Location = new System.Drawing.Point(70, 99);
            this.regGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Name = "regGroupBox";
            this.regGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Size = new System.Drawing.Size(186, 198);
            this.regGroupBox.TabIndex = 1;
            this.regGroupBox.TabStop = false;
            this.regGroupBox.Text = "Registration";
            // 
            // register_Btn
            // 
            this.register_Btn.Location = new System.Drawing.Point(36, 116);
            this.register_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(106, 29);
            this.register_Btn.TabIndex = 2;
            this.register_Btn.Text = "Register";
            this.register_Btn.UseVisualStyleBackColor = true;
            this.register_Btn.Click += new System.EventHandler(this.register_Click);
            // 
            // name_reg
            // 
            this.name_reg.Location = new System.Drawing.Point(36, 54);
            this.name_reg.Margin = new System.Windows.Forms.Padding(2);
            this.name_reg.Name = "name_reg";
            this.name_reg.Size = new System.Drawing.Size(106, 27);
            this.name_reg.TabIndex = 2;
            this.name_reg.Text = "Name";
            this.name_reg.Enter += new System.EventHandler(this.name_reg_Enter);
            this.name_reg.Leave += new System.EventHandler(this.name_reg_Leave);
            // 
            // password_reg
            // 
            this.password_reg.Location = new System.Drawing.Point(36, 85);
            this.password_reg.Margin = new System.Windows.Forms.Padding(2);
            this.password_reg.Name = "password_reg";
            this.password_reg.Size = new System.Drawing.Size(106, 27);
            this.password_reg.TabIndex = 2;
            this.password_reg.Text = "Password";
            this.password_reg.Enter += new System.EventHandler(this.password_reg_Enter);
            this.password_reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_reg_KeyDown);
            this.password_reg.Leave += new System.EventHandler(this.password_reg_Leave);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.regGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.regGroupBox.ResumeLayout(false);
            this.regGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button enter_Btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox regGroupBox;
        private System.Windows.Forms.Button register_Btn;
        private System.Windows.Forms.TextBox name_reg;
        private System.Windows.Forms.TextBox password_reg;
    }
}
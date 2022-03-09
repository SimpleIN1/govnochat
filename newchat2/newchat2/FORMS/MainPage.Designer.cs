
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
            this.Login = new System.Windows.Forms.GroupBox();
            this.enter = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.register = new System.Windows.Forms.Button();
            this.name_reg = new System.Windows.Forms.TextBox();
            this.password_reg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Window;
            this.Login.Controls.Add(this.enter);
            this.Login.Controls.Add(this.password);
            this.Login.Controls.Add(this.name);
            this.Login.Location = new System.Drawing.Point(381, 117);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(141, 134);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "LogIn";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(23, 71);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(96, 23);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(23, 45);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(23, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.register);
            this.groupBox1.Controls.Add(this.name_reg);
            this.groupBox1.Controls.Add(this.password_reg);
            this.groupBox1.Location = new System.Drawing.Point(74, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(59, 130);
            this.register.Margin = new System.Windows.Forms.Padding(2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(106, 29);
            this.register.TabIndex = 2;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // name_reg
            // 
            this.name_reg.Location = new System.Drawing.Point(59, 82);
            this.name_reg.Margin = new System.Windows.Forms.Padding(2);
            this.name_reg.Name = "name_reg";
            this.name_reg.Size = new System.Drawing.Size(106, 20);
            this.name_reg.TabIndex = 2;
            this.name_reg.Text = "Name";
            this.name_reg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.name_reg.Enter += new System.EventHandler(this.name_reg_Enter);
            this.name_reg.Leave += new System.EventHandler(this.name_reg_Leave);
            // 
            // password_reg
            // 
            this.password_reg.Location = new System.Drawing.Point(59, 106);
            this.password_reg.Margin = new System.Windows.Forms.Padding(2);
            this.password_reg.Name = "password_reg";
            this.password_reg.Size = new System.Drawing.Size(106, 20);
            this.password_reg.TabIndex = 2;
            this.password_reg.Text = "Password";
            this.password_reg.Enter += new System.EventHandler(this.password_reg_Enter);
            this.password_reg.Leave += new System.EventHandler(this.password_reg_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Login);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox name_reg;
        private System.Windows.Forms.TextBox password_reg;
        private System.Windows.Forms.Label label1;
    }
}
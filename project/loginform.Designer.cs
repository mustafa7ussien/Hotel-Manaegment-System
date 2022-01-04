
namespace project
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.empbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminlogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.employeelogin = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.employeefristname = new System.Windows.Forms.TextBox();
            this.employeessid = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.adminlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.employeelogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // empbt
            // 
            this.empbt.BackColor = System.Drawing.Color.Black;
            this.empbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.empbt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.empbt.ForeColor = System.Drawing.Color.BurlyWood;
            this.empbt.Location = new System.Drawing.Point(207, 373);
            this.empbt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empbt.Name = "empbt";
            this.empbt.Size = new System.Drawing.Size(125, 84);
            this.empbt.TabIndex = 4;
            this.empbt.Text = "Employee";
            this.empbt.UseVisualStyleBackColor = false;
            this.empbt.Click += new System.EventHandler(this.empbt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(207, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 84);
            this.button1.TabIndex = 5;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminlogin
            // 
            this.adminlogin.BackColor = System.Drawing.Color.White;
            this.adminlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminlogin.BackgroundImage")));
            this.adminlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminlogin.Controls.Add(this.pictureBox1);
            this.adminlogin.Controls.Add(this.label4);
            this.adminlogin.Controls.Add(this.label5);
            this.adminlogin.Controls.Add(this.login);
            this.adminlogin.Controls.Add(this.password);
            this.adminlogin.Controls.Add(this.user);
            this.adminlogin.Location = new System.Drawing.Point(65, 72);
            this.adminlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(415, 521);
            this.adminlogin.TabIndex = 31;
            this.adminlogin.Paint += new System.Windows.Forms.PaintEventHandler(this.adminlogin_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(390, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PapayaWhip;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "User Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.BurlyWood;
            this.login.Location = new System.Drawing.Point(219, 301);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(130, 49);
            this.login.TabIndex = 4;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(170, 246);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(216, 35);
            this.password.TabIndex = 3;
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(170, 196);
            this.user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(216, 35);
            this.user.TabIndex = 2;
            // 
            // employeelogin
            // 
            this.employeelogin.BackColor = System.Drawing.Color.White;
            this.employeelogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeelogin.BackgroundImage")));
            this.employeelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeelogin.Controls.Add(this.pictureBox2);
            this.employeelogin.Controls.Add(this.label2);
            this.employeelogin.Controls.Add(this.label6);
            this.employeelogin.Controls.Add(this.button4);
            this.employeelogin.Controls.Add(this.employeefristname);
            this.employeelogin.Controls.Add(this.employeessid);
            this.employeelogin.Location = new System.Drawing.Point(80, 49);
            this.employeelogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeelogin.Name = "employeelogin";
            this.employeelogin.Size = new System.Drawing.Size(403, 523);
            this.employeelogin.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(376, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "SSID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PapayaWhip;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frist Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.button4.Location = new System.Drawing.Point(204, 323);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // employeefristname
            // 
            this.employeefristname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeefristname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeefristname.Location = new System.Drawing.Point(166, 183);
            this.employeefristname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeefristname.Multiline = true;
            this.employeefristname.Name = "employeefristname";
            this.employeefristname.Size = new System.Drawing.Size(216, 35);
            this.employeefristname.TabIndex = 3;
            // 
            // employeessid
            // 
            this.employeessid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeessid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeessid.Location = new System.Drawing.Point(166, 242);
            this.employeessid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeessid.Multiline = true;
            this.employeessid.Name = "employeessid";
            this.employeessid.PasswordChar = '*';
            this.employeessid.Size = new System.Drawing.Size(216, 35);
            this.employeessid.TabIndex = 2;
            this.employeessid.TextChanged += new System.EventHandler(this.employeessid_TextChanged);
            this.employeessid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeessid_KeyPress);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(496, 1);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 623);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.employeelogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empbt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginform";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.adminlogin.ResumeLayout(false);
            this.adminlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.employeelogin.ResumeLayout(false);
            this.employeelogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empbt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel adminlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Panel employeelogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox employeefristname;
        private System.Windows.Forms.TextBox employeessid;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
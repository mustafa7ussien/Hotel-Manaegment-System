
namespace project
{
    partial class clientform
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.fristname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.passport = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addcustomarButton = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearbt = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            this.updatebt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewforgust = new System.Windows.Forms.DataGridView();
            this.backbt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforgust)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(425, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(343, 76);
            label9.TabIndex = 92;
            label9.Text = "CUSTOMER \r";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Stencil", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(1015, 1);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(236, 80);
            label10.TabIndex = 93;
            label10.Text = "CUSTOMER \rTABLE";
            label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fristname
            // 
            this.fristname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fristname.Location = new System.Drawing.Point(534, 205);
            this.fristname.Multiline = true;
            this.fristname.Name = "fristname";
            this.fristname.Size = new System.Drawing.Size(326, 40);
            this.fristname.TabIndex = 2;
            this.fristname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fristname_KeyPress);
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(534, 274);
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(326, 40);
            this.lastname.TabIndex = 3;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_KeyPress);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(534, 130);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(326, 40);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // passport
            // 
            this.passport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passport.Location = new System.Drawing.Point(534, 345);
            this.passport.Multiline = true;
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(326, 40);
            this.passport.TabIndex = 4;
            this.passport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passport_KeyPress);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(534, 413);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(326, 40);
            this.city.TabIndex = 5;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_KeyPress);
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(534, 619);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(326, 34);
            this.birthday.TabIndex = 8;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(534, 481);
            this.PhoneNumber.Multiline = true;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(326, 40);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "SSID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frist Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "City";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date of Birth";
            // 
            // addcustomarButton
            // 
            this.addcustomarButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addcustomarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcustomarButton.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomarButton.ForeColor = System.Drawing.Color.Black;
            this.addcustomarButton.Location = new System.Drawing.Point(64, 204);
            this.addcustomarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addcustomarButton.Name = "addcustomarButton";
            this.addcustomarButton.Size = new System.Drawing.Size(160, 90);
            this.addcustomarButton.TabIndex = 14;
            this.addcustomarButton.TabStop = false;
            this.addcustomarButton.Text = "Add";
            this.addcustomarButton.UseVisualStyleBackColor = false;
            this.addcustomarButton.Click += new System.EventHandler(this.addcustomarButton_Click);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Azure;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(534, 550);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(326, 44);
            this.gender.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 558);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(64, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 90);
            this.button1.TabIndex = 17;
            this.button1.TabStop = false;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearbt
            // 
            this.clearbt.BackColor = System.Drawing.Color.AliceBlue;
            this.clearbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbt.ForeColor = System.Drawing.Color.Black;
            this.clearbt.Location = new System.Drawing.Point(64, 486);
            this.clearbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(160, 90);
            this.clearbt.TabIndex = 18;
            this.clearbt.TabStop = false;
            this.clearbt.Text = "Clear";
            this.clearbt.UseVisualStyleBackColor = false;
            this.clearbt.Click += new System.EventHandler(this.clearbt_Click);
            // 
            // deletebt
            // 
            this.deletebt.BackColor = System.Drawing.Color.AliceBlue;
            this.deletebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebt.ForeColor = System.Drawing.Color.Black;
            this.deletebt.Location = new System.Drawing.Point(64, 298);
            this.deletebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(160, 90);
            this.deletebt.TabIndex = 19;
            this.deletebt.TabStop = false;
            this.deletebt.Text = "Delete";
            this.deletebt.UseVisualStyleBackColor = false;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // updatebt
            // 
            this.updatebt.BackColor = System.Drawing.Color.AliceBlue;
            this.updatebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebt.ForeColor = System.Drawing.Color.Black;
            this.updatebt.Location = new System.Drawing.Point(64, 110);
            this.updatebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebt.Name = "updatebt";
            this.updatebt.Size = new System.Drawing.Size(160, 90);
            this.updatebt.TabIndex = 20;
            this.updatebt.TabStop = false;
            this.updatebt.Text = "Update";
            this.updatebt.UseVisualStyleBackColor = false;
            this.updatebt.Click += new System.EventHandler(this.updatebt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(64, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 90);
            this.button2.TabIndex = 21;
            this.button2.TabStop = false;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewforgust
            // 
            this.dataGridViewforgust.AllowUserToAddRows = false;
            this.dataGridViewforgust.AllowUserToDeleteRows = false;
            this.dataGridViewforgust.AllowUserToResizeColumns = false;
            this.dataGridViewforgust.AllowUserToResizeRows = false;
            this.dataGridViewforgust.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewforgust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforgust.Location = new System.Drawing.Point(926, 84);
            this.dataGridViewforgust.MultiSelect = false;
            this.dataGridViewforgust.Name = "dataGridViewforgust";
            this.dataGridViewforgust.ReadOnly = true;
            this.dataGridViewforgust.RowHeadersWidth = 51;
            this.dataGridViewforgust.RowTemplate.Height = 24;
            this.dataGridViewforgust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewforgust.Size = new System.Drawing.Size(410, 625);
            this.dataGridViewforgust.TabIndex = 22;
            this.dataGridViewforgust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforgust_CellContentClick);
            this.dataGridViewforgust.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforgust_CellEnter);
            // 
            // backbt
            // 
            this.backbt.BackColor = System.Drawing.Color.AliceBlue;
            this.backbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbt.ForeColor = System.Drawing.Color.Black;
            this.backbt.Location = new System.Drawing.Point(64, 580);
            this.backbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(160, 90);
            this.backbt.TabIndex = 23;
            this.backbt.TabStop = false;
            this.backbt.Text = "Back";
            this.backbt.UseVisualStyleBackColor = false;
            this.backbt.Click += new System.EventHandler(this.backbt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.backbt);
            this.panel1.Controls.Add(this.updatebt);
            this.panel1.Controls.Add(this.addcustomarButton);
            this.panel1.Controls.Add(this.clearbt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.deletebt);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 683);
            this.panel1.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Location = new System.Drawing.Point(910, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 701);
            this.panel4.TabIndex = 91;
            // 
            // clientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewforgust);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.city);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.fristname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientform";
            this.Load += new System.EventHandler(this.clientform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforgust)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fristname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addcustomarButton;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearbt;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Button updatebt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewforgust;
        private System.Windows.Forms.Button backbt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}
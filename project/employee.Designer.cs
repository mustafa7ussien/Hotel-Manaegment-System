
namespace project
{
    partial class employee
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
            this.backbt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updatebt = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            this.clearbt = new System.Windows.Forms.Button();
            this.searchbt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.addcustomarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.city = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.fristname = new System.Windows.Forms.TextBox();
            this.dataGridViewforemployee = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(236, -1);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(343, 53);
            label9.TabIndex = 114;
            label9.Text = "EMPLOYEE";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(845, -1);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(464, 53);
            label10.TabIndex = 115;
            label10.Text = "EMPLOYEE TABLE";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbt
            // 
            this.backbt.BackColor = System.Drawing.Color.DarkMagenta;
            this.backbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbt.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbt.ForeColor = System.Drawing.Color.White;
            this.backbt.Location = new System.Drawing.Point(562, 612);
            this.backbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(139, 64);
            this.backbt.TabIndex = 46;
            this.backbt.TabStop = false;
            this.backbt.Text = "Back";
            this.backbt.UseVisualStyleBackColor = false;
            this.backbt.Click += new System.EventHandler(this.backbt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(121, 612);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 63);
            this.button2.TabIndex = 45;
            this.button2.TabStop = false;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatebt
            // 
            this.updatebt.BackColor = System.Drawing.Color.DarkMagenta;
            this.updatebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebt.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebt.ForeColor = System.Drawing.Color.White;
            this.updatebt.Location = new System.Drawing.Point(335, 535);
            this.updatebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebt.Name = "updatebt";
            this.updatebt.Size = new System.Drawing.Size(139, 64);
            this.updatebt.TabIndex = 44;
            this.updatebt.TabStop = false;
            this.updatebt.Text = "Update";
            this.updatebt.UseVisualStyleBackColor = false;
            this.updatebt.Click += new System.EventHandler(this.updatebt_Click);
            // 
            // deletebt
            // 
            this.deletebt.BackColor = System.Drawing.Color.DarkMagenta;
            this.deletebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebt.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebt.ForeColor = System.Drawing.Color.White;
            this.deletebt.Location = new System.Drawing.Point(562, 454);
            this.deletebt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(139, 64);
            this.deletebt.TabIndex = 43;
            this.deletebt.TabStop = false;
            this.deletebt.Text = "Delete";
            this.deletebt.UseVisualStyleBackColor = false;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // clearbt
            // 
            this.clearbt.BackColor = System.Drawing.Color.DarkMagenta;
            this.clearbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbt.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbt.ForeColor = System.Drawing.Color.White;
            this.clearbt.Location = new System.Drawing.Point(335, 613);
            this.clearbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbt.Name = "clearbt";
            this.clearbt.Size = new System.Drawing.Size(139, 63);
            this.clearbt.TabIndex = 42;
            this.clearbt.TabStop = false;
            this.clearbt.Text = "Clear";
            this.clearbt.UseVisualStyleBackColor = false;
            this.clearbt.Click += new System.EventHandler(this.clearbt_Click);
            // 
            // searchbt
            // 
            this.searchbt.BackColor = System.Drawing.Color.DarkMagenta;
            this.searchbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbt.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbt.ForeColor = System.Drawing.Color.White;
            this.searchbt.Location = new System.Drawing.Point(335, 455);
            this.searchbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(139, 67);
            this.searchbt.TabIndex = 41;
            this.searchbt.TabStop = false;
            this.searchbt.Text = "Search";
            this.searchbt.UseVisualStyleBackColor = false;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(91, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Gender";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(233, 347);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(362, 32);
            this.gender.TabIndex = 7;
            // 
            // addcustomarButton
            // 
            this.addcustomarButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.addcustomarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcustomarButton.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomarButton.ForeColor = System.Drawing.Color.White;
            this.addcustomarButton.Location = new System.Drawing.Point(121, 459);
            this.addcustomarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addcustomarButton.Name = "addcustomarButton";
            this.addcustomarButton.Size = new System.Drawing.Size(139, 63);
            this.addcustomarButton.TabIndex = 38;
            this.addcustomarButton.TabStop = false;
            this.addcustomarButton.Text = "Add";
            this.addcustomarButton.UseVisualStyleBackColor = false;
            this.addcustomarButton.Click += new System.EventHandler(this.addcustomarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label7.Location = new System.Drawing.Point(61, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(103, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(128, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(91, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Frist Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "SSID";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(233, 302);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(362, 30);
            this.phone.TabIndex = 6;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(233, 407);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(362, 32);
            this.birthday.TabIndex = 9;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(233, 256);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(362, 30);
            this.city.TabIndex = 5;
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_KeyPress);
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(233, 210);
            this.salary.Multiline = true;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(362, 30);
            this.salary.TabIndex = 4;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(233, 71);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(362, 30);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(233, 164);
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(362, 30);
            this.lastname.TabIndex = 3;
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_KeyPress);
            // 
            // fristname
            // 
            this.fristname.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fristname.Location = new System.Drawing.Point(233, 117);
            this.fristname.Multiline = true;
            this.fristname.Name = "fristname";
            this.fristname.Size = new System.Drawing.Size(362, 30);
            this.fristname.TabIndex = 2;
            this.fristname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fristname_KeyPress);
            // 
            // dataGridViewforemployee
            // 
            this.dataGridViewforemployee.AllowUserToAddRows = false;
            this.dataGridViewforemployee.AllowUserToDeleteRows = false;
            this.dataGridViewforemployee.AllowUserToResizeColumns = false;
            this.dataGridViewforemployee.AllowUserToResizeRows = false;
            this.dataGridViewforemployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewforemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforemployee.Location = new System.Drawing.Point(776, 55);
            this.dataGridViewforemployee.MultiSelect = false;
            this.dataGridViewforemployee.Name = "dataGridViewforemployee";
            this.dataGridViewforemployee.ReadOnly = true;
            this.dataGridViewforemployee.RowHeadersWidth = 51;
            this.dataGridViewforemployee.RowTemplate.Height = 24;
            this.dataGridViewforemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewforemployee.Size = new System.Drawing.Size(545, 598);
            this.dataGridViewforemployee.TabIndex = 47;
            this.dataGridViewforemployee.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforgust_CellEnter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Location = new System.Drawing.Point(747, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 641);
            this.panel3.TabIndex = 91;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1341, 692);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewforemployee);
            this.Controls.Add(this.backbt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updatebt);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.clearbt);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.addcustomarButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.city);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.fristname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updatebt;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Button clearbt;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button addcustomarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox fristname;
        private System.Windows.Forms.DataGridView dataGridViewforemployee;
        private System.Windows.Forms.Panel panel3;
    }
}
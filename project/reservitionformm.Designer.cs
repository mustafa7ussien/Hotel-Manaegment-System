
namespace project
{
    partial class reservitionformm
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
            System.Windows.Forms.Label label4;
            this.backbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Booking_ID = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Check_in_date = new System.Windows.Forms.DateTimePicker();
            this.Check_out_date = new System.Windows.Forms.DateTimePicker();
            this.Gust_ID = new System.Windows.Forms.ComboBox();
            this.Room_NO = new System.Windows.Forms.ComboBox();
            this.dataGridViewforBooking = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(185, 1);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(343, 76);
            label9.TabIndex = 93;
            label9.Text = "RESERVATION";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(872, 1);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(585, 76);
            label4.TabIndex = 95;
            label4.Text = "RESERVATION table";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbt
            // 
            this.backbt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbt.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbt.Location = new System.Drawing.Point(257, 594);
            this.backbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbt.Name = "backbt";
            this.backbt.Size = new System.Drawing.Size(123, 88);
            this.backbt.TabIndex = 47;
            this.backbt.Text = "Back";
            this.backbt.UseVisualStyleBackColor = false;
            this.backbt.Click += new System.EventHandler(this.backbt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 48;
            this.label1.Text = "Booking ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "Guest SSID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 43);
            this.label5.TabIndex = 52;
            this.label5.Text = "Check_in_date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 34);
            this.label6.TabIndex = 53;
            this.label6.Text = "Check_out_date";
            // 
            // Booking_ID
            // 
            this.Booking_ID.Location = new System.Drawing.Point(286, 105);
            this.Booking_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Booking_ID.Multiline = true;
            this.Booking_ID.Name = "Booking_ID";
            this.Booking_ID.Size = new System.Drawing.Size(242, 33);
            this.Booking_ID.TabIndex = 1;
            this.Booking_ID.TextChanged += new System.EventHandler(this.Booking_ID_TextChanged);
            this.Booking_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Booking_ID_KeyPress);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(116, 490);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(123, 88);
            this.Add.TabIndex = 60;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Check_in_date
            // 
            this.Check_in_date.Location = new System.Drawing.Point(286, 297);
            this.Check_in_date.Margin = new System.Windows.Forms.Padding(4);
            this.Check_in_date.Name = "Check_in_date";
            this.Check_in_date.Size = new System.Drawing.Size(242, 22);
            this.Check_in_date.TabIndex = 4;
            // 
            // Check_out_date
            // 
            this.Check_out_date.Location = new System.Drawing.Point(287, 347);
            this.Check_out_date.Margin = new System.Windows.Forms.Padding(4);
            this.Check_out_date.Name = "Check_out_date";
            this.Check_out_date.Size = new System.Drawing.Size(242, 22);
            this.Check_out_date.TabIndex = 5;
            // 
            // Gust_ID
            // 
            this.Gust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gust_ID.FormattingEnabled = true;
            this.Gust_ID.Location = new System.Drawing.Point(286, 166);
            this.Gust_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Gust_ID.Name = "Gust_ID";
            this.Gust_ID.Size = new System.Drawing.Size(242, 33);
            this.Gust_ID.TabIndex = 2;
            this.Gust_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gust_ID_KeyPress);
            // 
            // Room_NO
            // 
            this.Room_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_NO.FormattingEnabled = true;
            this.Room_NO.Location = new System.Drawing.Point(286, 228);
            this.Room_NO.Margin = new System.Windows.Forms.Padding(4);
            this.Room_NO.Name = "Room_NO";
            this.Room_NO.Size = new System.Drawing.Size(242, 33);
            this.Room_NO.TabIndex = 3;
            this.Room_NO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Room_NO_KeyPress);
            // 
            // dataGridViewforBooking
            // 
            this.dataGridViewforBooking.AllowUserToAddRows = false;
            this.dataGridViewforBooking.AllowUserToDeleteRows = false;
            this.dataGridViewforBooking.AllowUserToResizeColumns = false;
            this.dataGridViewforBooking.AllowUserToResizeRows = false;
            this.dataGridViewforBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewforBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforBooking.Location = new System.Drawing.Point(728, 81);
            this.dataGridViewforBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewforBooking.MultiSelect = false;
            this.dataGridViewforBooking.Name = "dataGridViewforBooking";
            this.dataGridViewforBooking.ReadOnly = true;
            this.dataGridViewforBooking.RowHeadersWidth = 51;
            this.dataGridViewforBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewforBooking.Size = new System.Drawing.Size(827, 613);
            this.dataGridViewforBooking.TabIndex = 66;
            this.dataGridViewforBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforBooking_CellContentClick);
            this.dataGridViewforBooking.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforBooking_CellEnter);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(405, 490);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(123, 88);
            this.delete.TabIndex = 68;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(675, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 708);
            this.panel4.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(-2, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 12);
            this.panel1.TabIndex = 96;
            // 
            // reservitionformm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1590, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(label9);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridViewforBooking);
            this.Controls.Add(this.Room_NO);
            this.Controls.Add(this.Gust_ID);
            this.Controls.Add(this.Check_out_date);
            this.Controls.Add(this.Check_in_date);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Booking_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reservitionformm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reservitionform";
            this.Load += new System.EventHandler(this.reservitionform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Booking_ID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker Check_in_date;
        private System.Windows.Forms.DateTimePicker Check_out_date;
        private System.Windows.Forms.ComboBox Gust_ID;
        private System.Windows.Forms.ComboBox Room_NO;
        private System.Windows.Forms.DataGridView dataGridViewforBooking;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}
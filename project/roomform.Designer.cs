
namespace project
{
    partial class roomform
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomtypeDataGridView = new System.Windows.Forms.DataGridView();
            this.Deletetoom = new System.Windows.Forms.Button();
            this.addroom = new System.Windows.Forms.Button();
            this.updateroom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.roomnum = new System.Windows.Forms.TextBox();
            this.roomprice = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.OpenFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.roomtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(863, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(294, 47);
            label9.TabIndex = 108;
            label9.Text = "Rooms";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(804, 377);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(409, 50);
            label6.TabIndex = 109;
            label6.Text = "images for room";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomtypeDataGridView
            // 
            this.roomtypeDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomtypeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomtypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomtypeDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomtypeDataGridView.Location = new System.Drawing.Point(657, 59);
            this.roomtypeDataGridView.MultiSelect = false;
            this.roomtypeDataGridView.Name = "roomtypeDataGridView";
            this.roomtypeDataGridView.ReadOnly = true;
            this.roomtypeDataGridView.RowHeadersWidth = 51;
            this.roomtypeDataGridView.RowTemplate.Height = 24;
            this.roomtypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomtypeDataGridView.Size = new System.Drawing.Size(697, 315);
            this.roomtypeDataGridView.TabIndex = 83;
            this.roomtypeDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomtypeDataGridView_CellEnter);
            // 
            // Deletetoom
            // 
            this.Deletetoom.BackColor = System.Drawing.Color.White;
            this.Deletetoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletetoom.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletetoom.ForeColor = System.Drawing.Color.Black;
            this.Deletetoom.Location = new System.Drawing.Point(15, 310);
            this.Deletetoom.Name = "Deletetoom";
            this.Deletetoom.Size = new System.Drawing.Size(161, 118);
            this.Deletetoom.TabIndex = 92;
            this.Deletetoom.Text = "Delete";
            this.Deletetoom.UseVisualStyleBackColor = false;
            this.Deletetoom.Click += new System.EventHandler(this.Deletetoom_Click);
            // 
            // addroom
            // 
            this.addroom.BackColor = System.Drawing.Color.White;
            this.addroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addroom.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addroom.ForeColor = System.Drawing.Color.Black;
            this.addroom.Location = new System.Drawing.Point(15, 23);
            this.addroom.Name = "addroom";
            this.addroom.Size = new System.Drawing.Size(161, 118);
            this.addroom.TabIndex = 90;
            this.addroom.Text = "Add";
            this.addroom.UseVisualStyleBackColor = false;
            this.addroom.Click += new System.EventHandler(this.addroom_Click);
            // 
            // updateroom
            // 
            this.updateroom.BackColor = System.Drawing.Color.White;
            this.updateroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateroom.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateroom.ForeColor = System.Drawing.Color.Black;
            this.updateroom.Location = new System.Drawing.Point(15, 165);
            this.updateroom.Name = "updateroom";
            this.updateroom.Size = new System.Drawing.Size(161, 118);
            this.updateroom.TabIndex = 91;
            this.updateroom.Text = "Update";
            this.updateroom.UseVisualStyleBackColor = false;
            this.updateroom.Click += new System.EventHandler(this.updateroom_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(194, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 109);
            this.label4.TabIndex = 100;
            this.label4.Text = "\r\nDescription";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 38);
            this.label2.TabIndex = 98;
            this.label2.Text = "Room Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 97;
            this.label1.Text = "Room Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(400, 163);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(207, 110);
            this.description.TabIndex = 96;
            this.description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.description_KeyPress);
            // 
            // roomnum
            // 
            this.roomnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnum.Location = new System.Drawing.Point(400, 22);
            this.roomnum.Multiline = true;
            this.roomnum.Name = "roomnum";
            this.roomnum.Size = new System.Drawing.Size(207, 40);
            this.roomnum.TabIndex = 95;
            this.roomnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomnum_KeyPress);
            // 
            // roomprice
            // 
            this.roomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomprice.Location = new System.Drawing.Point(400, 117);
            this.roomprice.Multiline = true;
            this.roomprice.Name = "roomprice";
            this.roomprice.Size = new System.Drawing.Size(207, 40);
            this.roomprice.TabIndex = 94;
            this.roomprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomprice_KeyPress);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(15, 446);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(161, 118);
            this.Back.TabIndex = 101;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 150);
            this.label5.TabIndex = 102;
            this.label5.Text = " images for Room";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // images
            // 
            this.images.FormattingEnabled = true;
            this.images.ItemHeight = 16;
            this.images.Location = new System.Drawing.Point(400, 280);
            this.images.Name = "images";
            this.images.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.images.Size = new System.Drawing.Size(207, 148);
            this.images.TabIndex = 103;
            this.images.SelectedIndexChanged += new System.EventHandler(this.images_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.FileName = "openFileDialog1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(657, 430);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(697, 326);
            this.panel.TabIndex = 104;
            // 
            // roomtype
            // 
            this.roomtype.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.roomtype.Location = new System.Drawing.Point(400, 70);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(207, 44);
            this.roomtype.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(194, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 38);
            this.label3.TabIndex = 99;
            this.label3.Text = "Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(621, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 744);
            this.panel3.TabIndex = 110;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.updateroom);
            this.panel1.Controls.Add(this.Deletetoom);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.addroom);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 651);
            this.panel1.TabIndex = 111;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(400, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 97);
            this.button1.TabIndex = 112;
            this.button1.Text = "Add images";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(label6);
            this.Controls.Add(label9);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.images);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.roomnum);
            this.Controls.Add(this.roomprice);
            this.Controls.Add(this.roomtypeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomform";
            this.Text = "roomform";
            this.Load += new System.EventHandler(this.roomform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomtypeDataGridView;
        private System.Windows.Forms.Button Deletetoom;
        private System.Windows.Forms.Button addroom;
        private System.Windows.Forms.Button updateroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox roomnum;
        private System.Windows.Forms.TextBox roomprice;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox images;
        private System.Windows.Forms.OpenFileDialog add;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox roomtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
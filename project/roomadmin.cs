using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
namespace project
{
    public partial class roomadmin : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel_db;uid=root;pwd=roooooot");

        MySqlDataReader reader;
        public roomadmin()
        {
            InitializeComponent();
        }
        public void refreshdatagrid()
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM room";
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            roomtypeDataGridView.DataSource = dt;
            connection.Close();
        }
        public void cleartx()
        {
            roomnum.Clear();
            roomtype.SelectedItem = null;
            roomprice.Clear();
            description.Clear();
            panel.Controls.Clear();
            images.Items.Clear();
        }
        private void addroom_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand();


            try
            {

                if (roomnum.Text == String.Empty || roomtype.Text == String.Empty || roomprice.Text == String.Empty || description.Text == String.Empty || images.Items == null)
                {
                    MessageBox.Show("Pleas provide all information");
                    connection.Close();
                }
                else
                {


                    cmd1.Connection = connection;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "insert_into_Room";
                    cmd1.Parameters.AddWithValue("@Room_NO", Convert.ToDouble(roomnum.Text));
                    cmd1.Parameters.AddWithValue("@Room_Type", roomtype.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@price_room", Convert.ToDouble(roomprice.Text.ToString()));
                    cmd1.Parameters.AddWithValue("@Description", description.Text.ToString());
                    string[] s = add.FileNames;
                    int y = 0;
                    connection.Open();
                    int i = cmd1.ExecuteNonQuery();
                    connection.Close();

                    foreach (string file in s)
                    {
                        if (file != "openFileDialog1")
                        {
                            MySqlCommand cmd2 = new MySqlCommand();
                            cmd2.Connection = connection;
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.CommandText = "insert_into_Room_img";
                            cmd2.Parameters.AddWithValue("@Room_NO", Convert.ToDouble(roomnum.Text));
                            cmd2.Parameters.AddWithValue("@img", file);
                            connection.Open();
                            y = cmd2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }




                    if (i != 0 && y != 0)
                    {
                        MessageBox.Show("added successfully");

                        refreshdatagrid();
                        cleartx();
                        connection.Close();
                    }
                    else if (i == 0) { MessageBox.Show("not added"); }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cann't add this value becouse it added befor ");
                connection.Close();
            }

        }

        private void updateroom_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();


            try
            {

                if (roomnum.Text == String.Empty || roomtype.Text == String.Empty || roomprice.Text == String.Empty || description.Text == String.Empty || images.Items == null)
                {
                    MessageBox.Show("Pleas provide all information to update ");
                    connection.Close();
                }
                else
                {

                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd3 = new MySqlCommand();
                    cmd3.Connection = connection;
                    cmd3.CommandText = "delete from room_img where Room_NO =" + Convert.ToDouble(roomnum.Text);
                    cmd3.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_room";
                    cmd.Parameters.AddWithValue("@Room_NO", Convert.ToDouble(roomnum.Text));
                    cmd.Parameters.AddWithValue("@Room_Type", roomtype.Text.ToString());
                    cmd.Parameters.AddWithValue("@price_room", roomprice.Text.ToString());
                    cmd.Parameters.AddWithValue("@Description", description.Text.ToString());

                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                    int y = 0;
                    foreach (string file in images.Items)
                    {
                        MySqlCommand cmd2 = new MySqlCommand();
                        cmd2.Connection = connection;
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.CommandText = "insert_into_Room_img";
                        cmd2.Parameters.AddWithValue("@Room_NO", Convert.ToDouble(roomnum.Text));
                        cmd2.Parameters.AddWithValue("@img", file.ToString());
                        connection.Open();
                        y = cmd2.ExecuteNonQuery();
                        connection.Close();

                    }




                    if (i != 0 && y != 0)
                    {
                        MessageBox.Show("updated successfully");
                        refreshdatagrid();
                        cleartx();
                        connection.Close();
                    }
                    else if (i == 0) { MessageBox.Show("not updated"); }



                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("you cann't updated this room becouse it booking  ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cann't updated this room " + ex);
                connection.Close();
            }
        }

        private void Deletetoom_Click(object sender, EventArgs e)
        {

            try
            {
                if (roomnum.Text != null)
                {
                    MySqlCommand cmd1 = new MySqlCommand();
                    MySqlCommand cmd2 = new MySqlCommand();
                    connection.Close();
                    connection.Open();
                    cmd2.Connection = connection;

                    cmd1.Connection = connection;
                    cmd1.CommandText = "SELECT * FROM hotel_db.room where Room_NO =" + Convert.ToDouble(roomnum.Text);
                    reader = cmd1.ExecuteReader();

                    while (reader.Read())
                    {
                        if (roomnum.Text == reader.GetString(0))
                        {
                            connection.Close();
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = connection;
                            cmd.CommandText = "delete from Room where Room_NO =" + Convert.ToDouble(roomnum.Text);
                            cmd2.CommandText = "delete from room_img where Room_NO =" + Convert.ToDouble(roomnum.Text);
                            cmd2.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("deleted successfully");
                            refreshdatagrid();
                            connection.Close();
                            cleartx();
                            break;
                        }
                        else if (roomnum.Text != reader.GetString(0))
                        {
                            MessageBox.Show("please enter a valid SSID");
                            connection.Close();
                            break;
                        }
                    }

                }
                else { MessageBox.Show("please enter SSID To delete it "); }


            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("you don't select any item to delete it ");
                connection.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("you cann't delete this room because it booking by gust ");
                connection.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
            homepage h1 = new homepage();
            foreach (Control c in h1.Controls)
            {
                if (c.Name == "button1")
                    c.Visible = false;
                if (c.Name == "button2")
                    c.Visible = false;
                if (c.Name == "button3")
                    c.Visible = false;


            }
            h1.Show();
        }
        ListBox listboxpath = new ListBox();
        private void button1_Click(object sender, EventArgs e)
        {

            listboxpath.Items.Clear();
            images.Items.Clear();
            add.Multiselect = true;
            add.Filter = "images|*.jpg;*.png";
            if (add.ShowDialog() == DialogResult.OK)
            {
                string[] s = add.FileNames;
                foreach (string file in s)
                {
                    listboxpath.Items.Add(file);
                    images.Items.Add(Path.GetFileName(file));
                }


            }
        }

        private void roomtypeDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            listboxpath.Items.Clear();
            connection.Close();
            MySqlCommand cmd = new MySqlCommand();
            images.Items.Clear();
            panel.Controls.Clear();

            roomnum.Text = roomtypeDataGridView.CurrentRow.Cells[0].Value.ToString();
            roomtype.Text = roomtypeDataGridView.CurrentRow.Cells[1].Value.ToString();
            roomprice.Text = roomtypeDataGridView.CurrentRow.Cells[2].Value.ToString();
            description.Text = roomtypeDataGridView.CurrentRow.Cells[3].Value.ToString();
            if (roomtypeDataGridView.CurrentRow.Cells[0].Value.ToString() != String.Empty)
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT* FROM room_img where room_no =" + Convert.ToInt64(roomtypeDataGridView.CurrentRow.Cells[0].Value.ToString());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listboxpath.Items.Add(reader.GetString(1));
                    images.Items.Add(Path.GetFileName(reader.GetString(1)));
                }
                connection.Close();
            }
        }

        private void images_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                panel.Controls.Clear();
                int index = images.SelectedIndex;
                string picturepath = listboxpath.Items[index].ToString();
                PictureBox pic = new PictureBox();
                pic.Size = new Size(panel.Width, panel.Height);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = Image.FromFile(picturepath);
                this.panel.Controls.Add(pic);
            }
            catch (System.ArgumentOutOfRangeException ex) { }
            catch (System.IO.FileNotFoundException ex) { }
        }

        private void roomadmin_Load(object sender, EventArgs e)
        {
            refreshdatagrid();
            connection.Close();
        }

        private void roomnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void roomprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void description_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace project
{
    public partial class clientform : Form
    {
        public clientform()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel_db;uid=root;pwd=roooooot");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        private void addcustomarButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {

                if (id.Text == String.Empty || fristname.Text == String.Empty || lastname.Text == String.Empty || passport.Text == String.Empty || birthday.Text == String.Empty || PhoneNumber.Text == String.Empty || city.Text == String.Empty || gender.Text == String.Empty)
                {
                    MessageBox.Show("Pleas provide all information");
                    connection.Close();
                }
                else
                {


                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_into_GUST";
                    cmd.Parameters.AddWithValue("@Gust_ID", Convert.ToDouble(id.Text));
                    cmd.Parameters.AddWithValue("@first_name", fristname.Text.ToString());
                    cmd.Parameters.AddWithValue("@last_name", lastname.Text.ToString());
                    cmd.Parameters.AddWithValue("@passport", Convert.ToDouble(passport.Text));
                    cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@city", city.Text.ToString());
                    cmd.Parameters.AddWithValue("@Phone_Number", Convert.ToDouble(PhoneNumber.Text));
                    cmd.Parameters.AddWithValue("@birthday", DateTime.Parse(birthday.Text));
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();

            if (id.Text != String.Empty)
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM hotel_db.gust where Gust_ID =" + Convert.ToInt64(id.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read().ToString() == "True")
                {
                    fristname.Text = reader.GetString(1);
                    lastname.Text = reader.GetString(2);
                    gender.SelectedItem = reader.GetString(3);
                    passport.Text = reader.GetString(4);
                    city.Text = reader.GetString(5);
                    PhoneNumber.Text = reader.GetString(6);
                    birthday.Value = DateTime.Parse(reader.GetString(7));

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("this SSID is not found");
                    fristname.Clear();
                    lastname.Clear();
                    passport.Clear();
                    gender.SelectedItem = null;
                    city.Clear();
                    PhoneNumber.Clear();
                    birthday.Value = DateTime.Now;
                    connection.Close();
                }
            }

            else if (id.Text == String.Empty)
            {

                MessageBox.Show("Please enter SSID to search");
            }
        }

        private void clearbt_Click(object sender, EventArgs e)
        {
            dataGridViewforgust.DataSource = null;
            cleartx();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text != String.Empty)
                {
                    MySqlCommand cmd1 = new MySqlCommand();

                    connection.Close();
                    connection.Open();
                    cmd1.Connection = connection;
                    cmd1.CommandText = "SELECT * FROM hotel_db.gust where Gust_ID =" + Convert.ToInt64(id.Text);
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        if (id.Text == reader.GetString(0))
                        {
                            connection.Close();
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "delete_into_GUST";
                            cmd.Parameters.AddWithValue("@GustID", id.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("deleted successfully");
                            refreshdatagrid();
                            connection.Close();
                            cleartx();
                            break;
                        }
                        else if (id.Text != reader.GetString(0))
                        {
                            MessageBox.Show("please enter a valid SSID");
                            connection.Close();
                            break;
                        }
                    }

                }
                else if (id.Text != String.Empty) { MessageBox.Show("please enter SSID To delete it "); }


            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("you don't select any item to delete it ");
                connection.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("you cann't delete this gust becouse it booking Room ");
                connection.Close();
            }
        }

        private void updatebt_Click(object sender, EventArgs e)
        {


            MySqlCommand cmd = new MySqlCommand();

            try
            {

                if (id.Text == String.Empty || fristname.Text == String.Empty || lastname.Text == String.Empty || passport.Text == String.Empty || birthday.Text == String.Empty || PhoneNumber.Text == String.Empty || city.Text == String.Empty || gender.Text == String.Empty)
                {
                    MessageBox.Show("Pleas provide all information to update ");
                    connection.Close();
                }
                else
                {


                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_gust";
                    cmd.Parameters.AddWithValue("@GustID", Convert.ToDouble(id.Text));
                    cmd.Parameters.AddWithValue("@firstname", fristname.Text.ToString());
                    cmd.Parameters.AddWithValue("@lastname", lastname.Text.ToString());
                    cmd.Parameters.AddWithValue("@pass_port", Convert.ToDouble(passport.Text));
                    cmd.Parameters.AddWithValue("@Gend", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@cit", city.Text.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNumber", Convert.ToDouble(PhoneNumber.Text));
                    cmd.Parameters.AddWithValue("@birth_day", DateTime.Parse(birthday.Text));
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
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
                MessageBox.Show("you cann't updated this gust becouse it booking Room ");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cann't updated this gust" + ex);
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewforgust.Visible = true;
            connection.Open();
            refreshdatagrid();

        }
        public void refreshdatagrid()
        {
            connection.Close();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM gust";
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridViewforgust.DataSource = dt;
            connection.Close();
        }
        
        public void cleartx()
        {
            id.Clear();
            fristname.Clear();
            lastname.Clear();
            passport.Clear();
            gender.SelectedItem = null;
            city.Clear();
            PhoneNumber.Clear();
            birthday.Value = DateTime.Now;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewforgust_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                id.Text = dataGridViewforgust.CurrentRow.Cells[0].Value.ToString();
                fristname.Text = dataGridViewforgust.CurrentRow.Cells[1].Value.ToString();
                lastname.Text = dataGridViewforgust.CurrentRow.Cells[2].Value.ToString();
                gender.SelectedItem = dataGridViewforgust.CurrentRow.Cells[3].Value.ToString();
                passport.Text = dataGridViewforgust.CurrentRow.Cells[4].Value.ToString();
                city.Text = dataGridViewforgust.CurrentRow.Cells[5].Value.ToString();
                PhoneNumber.Text = dataGridViewforgust.CurrentRow.Cells[6].Value.ToString();
                birthday.Value = DateTime.Parse(dataGridViewforgust.CurrentRow.Cells[7].Value.ToString());
            
            }

        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {    // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }


        }

        private void fristname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void passport_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void backbt_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            homepage h1 = new homepage();
            foreach (Control c in h1.Controls)
            {
                if (c.Name == "button6")
                    c.Visible = false;
                if (c.Name == "button5")
                    c.Visible = false;
                if (c.Name == "button4")
                    c.Visible = false;
                if (c.Name == "empbt")
                    c.Visible = false;
                if (c.Name == "label18")
                    c.Visible = false;
                if (c.Name == "pictureBox17")
                    c.Visible = false;
            
            }
            h1.Show();
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
             // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void dataGridViewforgust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientform_Load(object sender, EventArgs e)
        {
            refreshdatagrid();
            connection.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

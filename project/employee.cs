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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel_db;uid=root;pwd=roooooot");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        public void cleartx()
        {
            id.Clear();
            fristname.Clear();
            lastname.Clear();
            salary.Clear();
            gender.SelectedItem = null;
            city.Clear();
            phone.Clear();
            birthday.Value = DateTime.Now;
        }
        private void addcustomarButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {

                if (id.Text == String.Empty || fristname.Text == String.Empty || lastname.Text == String.Empty || salary.Text == String.Empty || birthday.Text == String.Empty || phone.Text == String.Empty || city.Text == String.Empty || gender.Text == String.Empty)
                {
                    MessageBox.Show("Pleas provide all information");
                    connection.Close();
                }
                else
                {


                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_into_Employee";
                    cmd.Parameters.AddWithValue("@em_ID", Convert.ToDouble(id.Text));
                    cmd.Parameters.AddWithValue("@first_name", fristname.Text.ToString());
                    cmd.Parameters.AddWithValue("@last_name", lastname.Text.ToString());
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(salary.Text));
                    cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@city", city.Text.ToString());
                    cmd.Parameters.AddWithValue("@phone", Convert.ToDouble(phone.Text));
                    cmd.Parameters.AddWithValue("@birthday", DateTime.Parse(birthday.Text));
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("added successfully");
                        cleartx();
                        refreshdatagrid();
                        connection.Close();
                    }
                    else if (i == 0) { MessageBox.Show("not added");
                        connection.Close();
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cann't add this value becouse it added befor ");
                connection.Close();
            }
        
        }
        public void refreshdatagrid()
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM employee";
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridViewforemployee.DataSource = dt;
            connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            refreshdatagrid();

        }

        private void dataGridViewforgust_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            id.Text = dataGridViewforemployee.CurrentRow.Cells[0].Value.ToString();
            fristname.Text = dataGridViewforemployee.CurrentRow.Cells[2].Value.ToString();
            lastname.Text = dataGridViewforemployee.CurrentRow.Cells[3].Value.ToString();
            salary.Text = dataGridViewforemployee.CurrentRow.Cells[4].Value.ToString();
            city.Text = dataGridViewforemployee.CurrentRow.Cells[5].Value.ToString();
            gender.SelectedItem = dataGridViewforemployee.CurrentRow.Cells[6].Value.ToString();
            birthday.Value = DateTime.Parse(dataGridViewforemployee.CurrentRow.Cells[7].Value.ToString());
            phone.Text = dataGridViewforemployee.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            try {
                if (id.Text !=String.Empty)
                {
                    MySqlCommand cmd1 = new MySqlCommand();

                    connection.Close();
                    connection.Open();
                    cmd1.Connection = connection;
                    cmd1.CommandText = "SELECT * FROM hotel_db.employee where em_ID =" + Convert.ToInt64(id.Text);
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
                            cmd.CommandText = "delete_into_employee";
                            cmd.Parameters.AddWithValue("@employee_ID", id.Text);
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
                else { MessageBox.Show("please enter SSID To delete it "); 
                    connection.Close(); }

            } catch (System.FormatException ex) {
                MessageBox.Show("you don't select any item to delete it ");
                connection.Close();
            
            } }

        private void backbt_Click(object sender, EventArgs e)
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

        private void clearbt_Click(object sender, EventArgs e)
        {
            dataGridViewforemployee.DataSource = null;
            cleartx();
        }

        private void searchbt_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();

            if (id.Text != String.Empty)
            {
                connection.Close();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM hotel_db.employee where em_ID =" + Convert.ToInt64(id.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read().ToString() == "True")
                {
                  
                    fristname.Text = reader.GetString(2);
                    lastname.Text = reader.GetString(3);
                    salary.Text = reader.GetString(4);
                    city.Text = reader.GetString(5);
                    gender.SelectedItem = reader.GetString(6);
                    birthday.Value = DateTime.Parse(reader.GetString(7));
                    phone.Text = reader.GetString(8);
                   

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("this SSID is not found");
                    fristname.Clear();
                    lastname.Clear();
                    salary.Clear();
                    gender.SelectedItem = null;
                    city.Clear();
                    phone.Clear();
                    birthday.Value = DateTime.Now;
                    connection.Close();
                }
            }
            else if (fristname.Text == null)
            {
                MessageBox.Show("you can only search with SSID ");
                cleartx();
                connection.Close();
            }
            else if (id.Text == null)
            {

                MessageBox.Show("Please enter SSID to search");
            }
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {

                if (id.Text == String.Empty || fristname.Text == String.Empty || lastname.Text == String.Empty || salary.Text == String.Empty || birthday.Text == String.Empty || phone.Text == String.Empty || city.Text == String.Empty || gender.Text == String.Empty)
                {
                    MessageBox.Show("Pleas provide all information to update ");
                    connection.Close();
                }
                else
                {


                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_employee";
                    cmd.Parameters.AddWithValue("@em_ID", Convert.ToDouble(id.Text));
                    cmd.Parameters.AddWithValue("@first_name", fristname.Text.ToString());
                    cmd.Parameters.AddWithValue("@last_name", lastname.Text.ToString());
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(salary.Text));
                    cmd.Parameters.AddWithValue("@Gender", gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@city", city.Text.ToString());
                    cmd.Parameters.AddWithValue("@phone", Convert.ToDouble(phone.Text));
                    cmd.Parameters.AddWithValue("@birthday", DateTime.Parse(birthday.Text));
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
                    connection.Close();


                }

           }
            catch (Exception ex)
            {
                MessageBox.Show("you cann't updated this value becouse it added befor " + ex);
                connection.Close();
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
            refreshdatagrid();
            connection.Close();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows only numbers
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

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}

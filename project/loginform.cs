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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;database=hotel_db;uid=root;pwd=roooooot");
        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin.Show();
           
        }

        private void empbt_Click(object sender, EventArgs e)
        {
            employeelogin.Show();

                    }

        private void login_Click(object sender, EventArgs e)
        {
            if (password.Text.ToString() == String.Empty && user.Text.ToString() == String.Empty)
            {

                MessageBox.Show("Please provide Username and Password");

            }
            else
          if (user.Text == "")
            {

                MessageBox.Show("Please provide Username ");
            }
            else if (password.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Please provide Password ");
            }
            else if (user.Text.ToString() != String.Empty && password.Text.ToString() != String.Empty&&user.Text== "admin")
                {
                    
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT pass FROM admin where user_name ='admin'";
                reader = cmd.ExecuteReader();

                    if (reader.Read().ToString() == "True" && reader.GetString(0) == password.Text)
                    {
                        adminlogin.Hide();
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
                else if (reader.Read().ToString() == "False" || reader.GetString(0) != password.Text)
                {
                    MessageBox.Show(" User Name or Password are not correct!");
                }
            }
            else { MessageBox.Show(" User Name or Password are not correct!"); }
            connection.Close();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
           
            
            adminlogin.Hide();
            employeelogin.Hide();
        }

        private void adminlogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminlogin.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
             
            
           
            if (employeessid.Text.ToString() == String.Empty && employeefristname.Text.ToString() == String.Empty)
            {

                MessageBox.Show("Please provide Username and Password");

            }
            else if (employeefristname.Text == "")
            {

                MessageBox.Show("Please provide Frist Name ");
            }
            
            else if (employeessid.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Please provide SSID ");
            }
            else if (employeessid.Text.ToString() != String.Empty && employeessid.Text.ToString() != String.Empty)
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT first_name FROM employee where em_ID =" + employeessid.Text;
                reader = cmd.ExecuteReader();

                if (reader.Read().ToString() == "True" && reader.GetString(0) == employeefristname.Text)
                {
                    employeelogin.Hide();
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
                else if (reader.Read().ToString() == "False" || reader.GetString(0) != employeefristname.Text) {
                    MessageBox.Show("SSID or Frist Name  are not correct!");
                }
            }
           

            connection.Close();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employeelogin.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeessid_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void employeessid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}

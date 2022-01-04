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
    public partial class homepage : Form
    { MySqlConnection con = new MySqlConnection("server=localhost;database=hotel_db;uid=root;pwd=roooooot");
        public homepage()
        {
            InitializeComponent();
            changePanel.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clientform c1 = new clientform();
            c1.Show();
            this.Hide();
        }

        private void empbt_Click(object sender, EventArgs e)
        {
            employee e1 = new employee();
            e1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roomform r1 = new roomform();
            r1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reservitionformm f1 = new reservitionformm();
            f1.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            changePanel.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            changePanel.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            changePanel.Hide();
            timer1.Start();

            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            MySqlDataReader reader ,reader1;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM hotel where hotel_code ='Hotel'";
            reader = cmd.ExecuteReader();
           
            if (reader.Read().ToString() == "True")
            {
                hotelname.Text = reader.GetString(1);
                hotelcity.Text = reader.GetString(2);
                hotelst.Text = reader.GetString(3);
                hotelstar.Text = reader.GetString(4);

                con.Close();
                con.Open();
                cmd1.Connection = con;
                cmd1.CommandText = "SELECT phone FROM hotel_tel where hotel_code ='Hotel'";
                reader1 = cmd1.ExecuteReader();
                
                if ( reader1.Read().ToString() == "True")
                {
                    hotelphone.Text = reader1.GetString(0);
                }

            }
            con.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
             DateTime saveNow = DateTime.Now;

             label2.Text = saveNow.ToString();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text.ToString() == String.Empty && newPassTextBox.Text.ToString() == String.Empty)
            {

                MessageBox.Show("Please provide old Password and new Password");

            }

            else if (oldPassTextBox.Text == "")
            {

                MessageBox.Show("Please provide  old Password ");
            }
            else if (newPassTextBox.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Please provide new Password ");
            }
            else if (newPassTextBox.Text.ToString() != String.Empty && oldPassTextBox.Text.ToString() != String.Empty)
            {

                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT pass FROM admin where user_name ='admin'";
                reader = cmd.ExecuteReader();

                if (reader.Read().ToString() == "True" && reader.GetString(0) == oldPassTextBox.Text)
                {
                    con.Close();
                    MySqlCommand cmd1 = new MySqlCommand();
                    
                    con.Open();
                    cmd1.Connection = con;
                    cmd1.CommandText = "replace into admin (user_name,pass)values ('admin','"+newPassTextBox.Text.ToString()+"')";
                    int i = cmd1.ExecuteNonQuery();
                    if(i!=0)
                    {
                        MessageBox.Show("changed successfully");
                        changePanel.Hide();
                    }

                }
                else if (reader.Read().ToString() == "False" || reader.GetString(0) != oldPassTextBox.Text)
                {
                    MessageBox.Show(" old Password are not correct!");
                }
            }
            else { MessageBox.Show(" new Password or old Password are not correct!"); }
            con.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform l1 = new loginform();
            l1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientadmin c1 = new clientadmin();
            c1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            roomadmin r1 = new roomadmin();
            r1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reservitionadmin f1 = new reservitionadmin();
            f1.Show();
            this.Hide();
        }
    }
}

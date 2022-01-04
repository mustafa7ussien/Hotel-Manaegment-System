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
    public partial class reservitionformm : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database=hotel_db;uid=root;pwd=roooooot");
        
        MySqlDataReader reader;
        public void cleartx()
        {
            Booking_ID.Clear();
            Gust_ID.SelectedItem = null;
            Room_NO.SelectedItem = null;
            
            Check_in_date.Value = DateTime.Now;
            Check_out_date.Value = DateTime.Now;
            
        }

        public reservitionformm()
        {
            InitializeComponent();
        }

        private void backbt_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            homepage h1 = new homepage();
            foreach (Control c in h1.Controls)
            {
                if (c.Name == "button5")
                    c.Visible = false;
                if (c.Name == "button4")
                    c.Visible = false;
                if (c.Name == "button6")
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

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
          try
           {

                if (Booking_ID.Text == String.Empty || Gust_ID.Text == String.Empty || Room_NO.Text == String.Empty )
                {
                    MessageBox.Show("Pleas provide all information");
                    con.Close();
                }
                else if( (DateTime.Parse(Check_out_date.Text)- DateTime.Parse(Check_in_date.Text)).Days<0){
                    MessageBox.Show("you can't make (booking date out) before (booking date in)   ");
                }
                else
                {
                con.Open();
                cmd1.Connection = con;
                cmd1.CommandText = "update gust set reserved ='yes' where Gust_ID=" + Gust_ID.SelectedItem.ToString();
                int x = cmd1.ExecuteNonQuery();
                
                cmd2.Connection = con;
                cmd2.CommandText = "update room set state ='busy' where Room_NO=" + Room_NO.SelectedItem.ToString();
                int z = cmd2.ExecuteNonQuery();
                cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_into_Booking";
                    cmd.Parameters.AddWithValue("Booking_ID", Convert.ToDouble(Booking_ID.Text));
                    cmd.Parameters.AddWithValue("@Gust_ID", Gust_ID.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Room_NO", Room_NO.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Booking_date", DateTime.Parse(DateTime.Now.ToShortDateString()));
                cmd.Parameters.AddWithValue("@Check_in_date", DateTime.Parse(Check_in_date.Text));
                    cmd.Parameters.AddWithValue("@Check_out_date", DateTime.Parse(Check_out_date.Text));
                   
                    int i = cmd.ExecuteNonQuery();
                    
                    if (i != 0&&x!=0&&z!=0)
                    {
                        MessageBox.Show("added successfully");
                        cleartx();
                    
                    refreshdatagrid();
                    
                        con.Close();
                    reservupdate();
                }
                    else if (i == 0) { MessageBox.Show("not added"); }

                    con.Close();

                }
            }
          catch (Exception ex)
           {
               MessageBox.Show("you cann't add this value because it added befor ");
               con.Close();
           }



        }
        public void reservupdate()
        {
            Gust_ID.Items.Clear();
            Room_NO.Items.Clear();
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM room where state='empty'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Room_NO.Items.Add(reader.GetString(0));

            }
            con.Close();
            con.Open();


            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM gust where reserved='no'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Gust_ID.Items.Add(reader.GetString(0));

            }
            con.Close();
        }
private void reservitionform_Load(object sender, EventArgs e)
        {
            reservupdate();
            refreshdatagrid();


        }
        public void refreshdatagrid()
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Booking";
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridViewforBooking.DataSource = dt;
            con.Close();
        }

        private void Show_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewforBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewforBooking_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Booking_ID.Text = dataGridViewforBooking.CurrentRow.Cells[0].Value.ToString();
            Gust_ID.Text =  dataGridViewforBooking.CurrentRow.Cells[1].Value.ToString();
            Room_NO.Text = dataGridViewforBooking.CurrentRow.Cells[2].Value.ToString();
            Check_in_date.Value = DateTime.Parse(dataGridViewforBooking.CurrentRow.Cells[3].Value.ToString());
            Check_out_date.Value = DateTime.Parse(dataGridViewforBooking.CurrentRow.Cells[4].Value.ToString());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;

            try
            {
                if (Booking_ID.Text != null)
                {
                    MySqlCommand cmd1 = new MySqlCommand();

                    con.Close();
                    con.Open();
                    cmd1.Connection = con;
                    cmd1.CommandText = "select * from booking where Booking_ID  =" + Convert.ToInt64(Booking_ID.Text);
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        //int x = cmd1.ExecuteNonQuery();
                        if (Booking_ID.Text == reader.GetString(0))
                        {

                            con.Close();
                            con.Open();
                            cmd1.CommandText = "delete from Booking where Booking_ID =" + Convert.ToDouble(Booking_ID.Text);
                            cmd1.ExecuteNonQuery();
                            cmd1.Connection = con;
                            
                            MySqlCommand cmd = new MySqlCommand();
                            MySqlCommand cmd2 = new MySqlCommand();
                            //MySqlCommand cmd3 = new MySqlCommand();

                            cmd.Connection = con;
                            cmd.CommandText = "update gust set reserved ='no' where  Gust_ID=" + Convert.ToInt64(Gust_ID.Text);
                            cmd.ExecuteNonQuery();
                            cmd2.Connection = con;
                            cmd2.CommandText = "update room set state ='empty' where  Room_NO=" + Convert.ToInt64(Room_NO.Text);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("deleted successfully");                           
                            reservupdate();
                            refreshdatagrid();
                            con.Close();
                            cleartx();
                            break;
                        }
                        else if (Booking_ID.Text != reader.GetString(0))
                        {
                            MessageBox.Show("please enter a valid Booking Id");
                            con.Close();

                        }
                    }
                    }

               
                else { MessageBox.Show("please enter Booking Id To delete it "); }


            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("you don't select any item to delete it ");
                con.Close();

            }
        }

        private void Booking_ID_KeyPress(object sender, KeyPressEventArgs e)
        {


            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Gust_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }

            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Room_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar))

            {

                e.Handled = true;

            }

            // allows only letters

            if (!char.IsLetter(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void Booking_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

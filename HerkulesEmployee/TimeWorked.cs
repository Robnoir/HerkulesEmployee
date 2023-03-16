using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HerkulesEmployee
{
    public partial class TimeWorked : Form
    {
        MySqlConnection conn;
        MySqlDataReader reader;
        // public static int viewTime; //ADDERA knapp lr nått? så man kan kolla sina timmar
        public TimeWorked()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "herkules";
            string uid = "root";
            string password = "mamamia";// <------ database password here

            string connectstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connectstring);
        }// <------ database password here

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT herkules_id AS ID, herkules_user AS USER, herkules_hour AS Hour, herkules_pay AS Payment, herkules_title AS Title, herkules_status AS Presence, herkules_vacation AS Vacation FROM herkules";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                reader = cmd.ExecuteReader();

                conn.Close();
            }catch (Exception) {
                MessageBox.Show("Something went wrong.");
            }
        }

        // textBox1 = ID, textBox2 =? add hours, textBox3 = Remove
        private void button3_Click(object sender, EventArgs e) // UPDATE btn
        {
            try
            {
                string query = "UPDATE herkules SET herkules_hour='"+textBox2.Text+"', herkules_pay='"+textBox3.Text+"' WHERE herkules_id='" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                reader = cmd.ExecuteReader();

                conn.Close();
                MessageBox.Show("You've updated your work hours with your prefered hourly rate!");
                button1_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }
        private void button4_Click(object sender, EventArgs e) // SEMESTER btn
        {
            MessageBox.Show("Here's your total Semester / annual leave days: Unfortunately this bötton doesn't work yet");
        }

        private void button5_Click(object sender, EventArgs e) // SALARY TOTAL or something
        {
            MessageBox.Show("Here's your total Salary earned so far: (>^_^)>");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bojan is not working today, he's out gambling");
        }
    }
}

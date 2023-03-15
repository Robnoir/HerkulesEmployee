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

namespace HerkulesEmployee
{
    public partial class NewUser : Form
    {
        MySqlConnection conn;
        MySqlDataReader reader;
        public static string userName { get; set; } //idk man
        public static double passWord { get; set; }
        public NewUser()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "herkules";
            string uid = "root";
            string password = "mamamia";// <------ database password here

            string connectstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connectstring);
        }// <------ database password here

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //USELESS KOD, lade till något dock
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    userName = textBox1.Text;
                    passWord = Convert.ToDouble(textBox2.Text);
                    string query = $"INSERT INTO `herkules` (`herkules_user`, `herkules_password`) VALUES ('{userName}', '{passWord}')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    /*/MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;/*/
                    conn.Open();

                    reader = cmd.ExecuteReader();

                    conn.Close();
                }
                MessageBox.Show($"Your username is {textBox1.Text} and Password is {textBox2.Text}.\r\n Don't tell anyone.");
            }
            catch(Exception)
            {
                MessageBox.Show("Only numbers are allowed in Password");
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

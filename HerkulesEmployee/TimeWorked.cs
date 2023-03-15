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
                string query = $"SELECT herkules_id AS ID, herkules_user AS USER, herkules_hour AS Hour, herkules_pay AS Payment FROM herkules";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Open();
                reader = cmd.ExecuteReader();

                conn.Close();
                MessageBox.Show("Don't tell anyone.");
            }catch (Exception) {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}

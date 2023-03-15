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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HerkulesEmployee
{
    public partial class ReportTime : Form
    {
        MySqlConnection conn;
        MySqlDataReader reader;
        public static double reportTime { get; set; }
        public static double checkSalary { get; set; }

        public ReportTime()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "herkules";
            string uid = "root";
            string password = "mamamia";// <------ database password here

            string connectstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connectstring);
        }// <------ database password here

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // OK btn, här skall du addera timmarna till din tidsbank/arbetade h
        {
            try
            {
                if (textBox1.Text != "")
                {
                    reportTime = Convert.ToDouble(textBox1.Text);
                    checkSalary = reportTime * 200;
                    string query = $"INSERT INTO `herkules`(`herkules_hour`, `herkules_pay`) VALUES ('{reportTime}', '{checkSalary}');";

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
                MessageBox.Show($"You've added {reportTime} Hours and you earned" +Convert.ToDouble(checkSalary)+ "Euros");
            }
            catch (Exception)
            {
                MessageBox.Show("Add your work time in whole numbers.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

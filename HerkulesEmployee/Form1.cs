using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HerkulesEmployee
{
    public partial class Form1 : Form
    {
        MySqlConnection conn; // BORDE EGEGENLIGEN GÖRA EN KLASS vid namn DATABASså jag kan kalla på klassen t ex dataBase.GetData(); istället för att skriva // CONNECT TO DATABASE om och om igen (följer ej DRY rekommendationer XD) i varje Form
        MySqlDataReader reader;
        public Form1()
        {
            InitializeComponent();

            // CONNECT TO DATABASE
            string server = "localhost";
            string database = "herkules";
            string uid = "root";
            string password = "mamamia";

            string connectstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conn = new MySqlConnection(connectstring);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm) // kan öppna andra windows via panelen med denna kod
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            login1.Controls.Add(childForm);
            login1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            login1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void login1_Load(object sender, EventArgs e)
        {
            login1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            login1.Visible = true; // Don't understand this Rob. -- "Login : UserControl" -- where ist das usercontrol?
        }
        #region MENYBUTTONS OPENCHILDFÖRMS, OPEN OTHER WINDÖWS
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSettings()); //öppnar settings
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new ReportTime()); // Öppnar reporttime
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Schedule()); //öppnar Schedule
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TimeWorked()); //öppnar Tid jobbat
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new NewUser()); //öppnar skapaUser
        }
        #endregion
    }
}

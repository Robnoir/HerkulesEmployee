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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
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

        private void button1_Click(object sender, EventArgs e)
        {
            login1.Visible = true;
        }

        private void login1_Load(object sender, EventArgs e)
        {
            login1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new ReportTime()); // Öppnar reporttime
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSettings()); //öppnar settings
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Schedule());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TimeWorked());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new NewUser());
        }
    }
}

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

namespace HerkulesEmployee
{
    public partial class ReportTime : Form
    {
        public static double reportTime;
        public static double checkSalary;
        
        public ReportTime()
        {
            InitializeComponent();
        }

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

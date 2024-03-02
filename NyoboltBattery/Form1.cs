using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyoboltBattery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Location = new Point(599, 12);
            pictureBox2.Location = new Point(599, 12);
            pictureBox3.Location = new Point(599, 12);
            pictureBox4.Location = new Point(599, 12);

            int charge = 67;
            int? temperature = 43;
            textBox1.Text = $"Battery Milage: 49 miles\r\nBattery Logs: \r\n  -  Date: 2024-03-02  \r\n  -  Battery Voltage: 213V\r\n  -  Battery Capacity: 22kWh\r\n  -  Temperature: {temperature}*C\r\n  -  State of Charge: {charge}%\r\n  -  State of Health: 78%";
            if (charge > 75)
            {
                label4.Text = charge.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (charge > 50)
            {
                label4.Text = charge.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (charge > 25)
            {
                label4.Text = charge.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                label4.Text = charge.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

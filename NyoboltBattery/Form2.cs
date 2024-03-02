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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Date: 2024-03-02\r\nBattery Voltage: 31V\r\nBattery Capacity: 57kWh\r\nTemperature: 131*C\r\nState of Charge: 95%\r\nState of Health: 42% \r\n " +
                "\r\nDate: 2024-02-02\r\nBattery Voltage: 235V\r\nBattery Capacity: 7kWh\r\nTemperature: 117*C\r\nState of Charge: 7%\r\nState of Health: 77% \r\n " +
                "\r\nDate: 2024-01-02\r\nBattery Voltage: 499V\r\nBattery Capacity: 10kWh\r\nTemperature: 5*C\r\nState of Charge: 53%\r\nState of Health: 81% \r\n" + 
                "\r\nDate: 2024-29-01\r\nBattery Voltage: 230V\r\nBattery Capacity: 61kWh\r\nTemperature: 131*C\r\nState of Charge: 33%\r\nState of Health: 49% \r\n" + 
                "\r\nDate: 2024-28-01\r\nBattery Voltage: 311V\r\nBattery Capacity: 57kWh\r\nTemperature: 84*C\r\nState of Charge: 81%\r\nState of Health: 45%";
        }
    }
}

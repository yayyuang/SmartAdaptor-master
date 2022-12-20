using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace ArduinoProject

{
    public partial class Arduino : Form
    {
        SerialPort port;
        
        public Arduino()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Arduino_FormClosed);
            if (port  == null)
            {
                port = new SerialPort("COM3", 9600);//Set your board COM
                port.Open();
                
            }
        

        }
        Dictionary<UInt16, string> StatusCodes;
        void Arduino_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
            
        }

        private void Arduino_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSerialPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                cmbSerialPort.SelectedIndex = 0;

            }
            catch (Exception)
            {

            serialPort1.BaudRate = 9600;
            serialPort1.ReadTimeout = 2000;
            serialPort1.WriteTimeout = 2000;
            
            
            }
        
            batterystatus();
            ShowPowerStatus();

            var ports = SerialPort.GetPortNames();
            cmbSerialPort.DataSource = ports;

        }

        /*private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbSerialPort.Text;
                serialPort1.Open();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Silahkan Masukan Port");
            }
        }*/
            

        private void btnON_Click(object sender, EventArgs e)
        {
            serialportCommand("on");
            PortWrite("1");

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            serialportCommand("off");
            PortWrite("0");
        }
        private void PortWrite(string message)
        {
            port.Write(message);
        }
        
        private void cmbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*serialPort1.PortName = cmbSerialPort.Text;*/

        }

        private void serialportCommand(string commandname)
        {
            try
            {
                serialPort1.PortName = cmbSerialPort.Text;
                serialPort1.Open();
                serialPort1.WriteLine(commandname);
                serialPort1.Close();

            }
            catch (Exception)
            {
                
            }
        }

        private void batterystatus()
        {
            StatusCodes = new Dictionary<ushort, string>();

            StatusCodes.Add(1, "The battery is discharging");

            StatusCodes.Add(2, "The system has access to AC so no battery is being discharged. However, the battery is not necessarily charging");

            StatusCodes.Add(3, "Fully Charged");

            StatusCodes.Add(4, "Low");

            StatusCodes.Add(5, "Critical");

            StatusCodes.Add(6, "Charging");

            StatusCodes.Add(7, "Charging and High");

            StatusCodes.Add(8, "Charging and Low");

            StatusCodes.Add(9, "Undefined");

            StatusCodes.Add(10, "Partially Charged");



            /* Set progress bar values and Properties */


            timer1.Enabled = true;


            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");

            foreach (ManagementObject mo in mos.Get())

            {

                lblBatteryName.Text = mo["Name"].ToString();

                UInt16 statuscode = (UInt16)mo["BatteryStatus"];

                string statusString = StatusCodes[statuscode];

                lblBatteryStatus.Text = statusString;

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)

        {

            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery where Name='" + lblBatteryName.Text + "'");
            ShowPowerStatus();
            foreach (ManagementObject mo in mos.Get())

            {

                UInt16 statuscode = (UInt16)mo["BatteryStatus"];

                string statusString = StatusCodes[statuscode];

                lblBatteryStatus.Text = statusString;

                /* Set Progress bar according to status  */

            }
        }
        private void ShowPowerStatus()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            txtChargeStatus.Text = status.BatteryChargeStatus.ToString();
            if (status.BatteryFullLifetime == -1)
                txtFullLifetime.Text = "Unknown";
            else
                txtFullLifetime.Text = status.BatteryFullLifetime.ToString();
                txtBatere.Text = status.BatteryLifePercent.ToString("P0");
                float battpercent = status.BatteryLifePercent * 100;

            if (battpercent == 100)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
            }
            else if (battpercent < 100 && battpercent > 80)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
            }
            else if (battpercent <= 80 && battpercent > 60)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
            }
            else if (battpercent <= 60 && battpercent > 40)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
            }
            else if (battpercent <= 40 && battpercent > 20)
            {
                bt1.Visible = true;
                bt2.Visible = true;
                bt1.BackColor = Color.Green;
            }
            else if (battpercent <= 20)
            {
                bt1.Visible = true;
                bt2.Visible = false;
                bt1.BackColor = Color.Red;
            }


           /* try
            {
                if (battpercent >= float.Parse(txtChargeOff.Text.ToString()))
                {
                    serialportCommand("1");
                    PortWrite("1");


                }
                if (battpercent <= float.Parse(txtChargeON.Text) && txtChargeStatus.Text=="0")
                {
                    serialportCommand("0");
                    PortWrite("0");
                }
            }
            catch (Exception)
            {

            }*/
            
            if (status.BatteryLifeRemaining == -1)
                txtLifeRemaining.Text = "Unknown";
            else
                txtLifeRemaining.Text =
                status.BatteryLifeRemaining.ToString();
                txtLineStatus.Text = status.PowerLineStatus.ToString();

            if (txtLineStatus.Text == "Online")
            {
                petir.Visible = true;
            }
            else
            {
                petir.Visible = false;
            }
           // if (battpercent >= float.Parse(txtChargeOff.Text.ToString()))
          //  {
                
            //    PortWrite("1");
                

           // }
           // if (battpercent <= float.Parse(txtChargeON.Text) && txtChargeStatus.Text == "0")
            //{
                
            //    PortWrite("0");
           // }
            
        }

        private void txtChargeON_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtChargeOff_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatere_Click(object sender, EventArgs e)
        {

        }
    }
}
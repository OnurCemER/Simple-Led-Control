using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ChecboxLed
{
    public partial class formArduinoLed : Form
    {
        String[] portListesi;
        bool baglantiDurumu = false;
        public formArduinoLed()
        {
            InitializeComponent();
        }
        void PortListele() 
        {
            comboBox1.Items.Clear();
            portListesi = SerialPort.GetPortNames();
            foreach (string port in portListesi)
            {
                comboBox1.Items.Add(port);
            }

            if (portListesi.Length<1)
            {
                MessageBox.Show("Hiçbir Port Bulunamadı. Arduinonuzun Bağlı Olduğundan Emin Olun Ve Yenileyin.");
            }
            else {
                comboBox1.SelectedItem = portListesi[0];
            }
        }

        private void formArduinoLed_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            PortListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            PortListele();
        }

        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            if (baglantiDurumu == false)
            {
                serialPort1.PortName = comboBox1.GetItemText(comboBox1.SelectedItem);
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                comboBox1.Enabled = false;
                btnYenile.Enabled = false;
                baglantiDurumu = true;
                btnBaglanti.Text = "Bağlantıyı Kes";
                groupBox2.Enabled = true;
            }
            else {
                baglantiDurumu = false;
                btnBaglanti.Text = "Bağlan";
                btnYenile.Enabled = true;
                comboBox1.Enabled = true;
                groupBox2.Enabled = false;
                checkKirmizi.Checked = false;
                checkMavi.Checked = false;
                checkSari.Checked = false;
                checkYesil.Checked = false;
                serialPort1.Close();
            }
        }

        private void checkKirmizi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKirmizi.Checked)
            {
                serialPort1.Write("1");
            }
            else if(checkKirmizi.Checked==false)
            {
                serialPort1.Write("2");
            } if (checkYesil.Checked)
            {
                serialPort1.Write("3");
            }
            else if (checkYesil.Checked == false)
            {
                serialPort1.Write("4");
            } if (checkSari.Checked)
            {
                serialPort1.Write("5");
            }
            else if (checkSari.Checked == false)
            {
                serialPort1.Write("6");
            } if (checkMavi.Checked)
            {
                serialPort1.Write("7");
            }
            else if (checkMavi.Checked == false)
            {
                serialPort1.Write("8");
            }
        }

        private void btnSondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            checkYesil.Checked = false;
            checkKirmizi.Checked = false;
            checkMavi.Checked = false;
            checkSari.Checked = false;
        }

        private void btnYak_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
            checkYesil.Checked = true;
            checkKirmizi.Checked = true;
            checkMavi.Checked = true;
            checkSari.Checked = true;
        }
    }
}

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
using System.IO;

namespace Vehiculo_4x4
{
    public partial class Form1 : Form
    {
        public string DatosRecibidos;

        public Form1()
        {
            InitializeComponent();

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ConfigurarUART();

        }

        void ConfigurarUART()
        {



            string[] PuertosDisponibles = SerialPort.GetPortNames();
            comBox_Puertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                comBox_Puertos.Items.Add(puerto_simple);

            }
            if (comBox_Puertos.Items.Count > 0)
            {

                comBox_Puertos.SelectedIndex = 0;
                serialPort1.BaudRate = 19200;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = comBox_Puertos.Text;



            }


        }

      



        void ConexionUART()
        {


            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                    Recibido.Text = "CONECTADO";

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message.ToString());
                }


            }
            else
            {

                try
                {

                    serialPort1.Open();
                    serialPort1.DiscardOutBuffer();
                    serialPort1.DiscardInBuffer();
                    Recibido.Text = "DESCONECTADO";


                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message.ToString());
                }
            }







        }

       

        void EnviarUART(string DataOUT)
        {

            serialPort1.WriteLine(DataOUT);

        }

        private void Right_Click(object sender, EventArgs e)
        {
            EnviarUART("Right");
        }

        private void Left_Click(object sender, EventArgs e)
        {
            EnviarUART("Left");
        }

        private void Up_Click(object sender, EventArgs e)
        {
            EnviarUART("Up");
        }

        private void Down_Click(object sender, EventArgs e)
        {
            EnviarUART("Down");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DatosRecibidos = serialPort1.ReadLine();
            Recibido.Text = DatosRecibidos;
            Console.WriteLine(DatosRecibidos);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            serialPort1.Close();
            serialPort1.Dispose();
        }

        private void ConectarPuerto1_Click_1(object sender, EventArgs e)
        {
          
            ConexionUART();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            EnviarUART(Recibido.Text);
        }

        private void Slider_ValueChanged(object sender, EventArgs e)
        {

            int Slide = Slider.Value;
            string Slide2 = Slide.ToString();
            Recibido.Text = Slide2;
 
        }
    }
}

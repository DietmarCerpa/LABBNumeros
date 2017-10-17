using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace GuiCajas
{

   
    public partial class Form1 : Form
    {

        Socket listen;
        IPEndPoint connect;
        bool Conectar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
                     
        }

        private void BotonEnviar_Click(object sender, EventArgs e)
        {
            byte[] enviar_info = new byte[100];

            string data;

            data = Mensaje.Text;

            enviar_info = Encoding.Default.GetBytes(data);

            listen.Send(enviar_info);
        }

        private void BotonConectar_Click(object sender, EventArgs e)
        {
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connect = new IPEndPoint(IPAddress.Parse(IPServidor.Text), Int32.Parse(PuertoServidor.Text));
            listen.Connect(connect);
            Conectar = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

/*
           Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6500);

           listen.Connect(connect);

           byte[] enviar_info = new byte[100];
           string data;

           Console.WriteLine("ingresa la info a Enviar: ");

           data = Console.ReadLine();

           enviar_info = Encoding.Default.GetBytes(data);

           listen.Send(enviar_info);

           Console.ReadKey();
 */

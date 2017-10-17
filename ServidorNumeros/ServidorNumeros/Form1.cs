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

namespace ServidorNumeros
{


    public partial class Form1 : Form
    {

        string CampoIP, CampoPuerto, DatosRecibidos = "";

        byte[] TramaRecibida = new byte[100];

        int MaxHosts = 10, DimensionVector = 0;

        bool ConexionEstablecida = false;


        Socket Leer, Conexion;

        IPEndPoint Conectar;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CampoIP = IPText.Text;

            //CampoPuerto = PuertoText.Text;
        }

        private void BotonConectar_Click(object sender, EventArgs e)
        {
            Leer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Conectar = new IPEndPoint(IPAddress.Parse(IPText.Text), Int32.Parse(PuertoText.Text));

            Leer.Bind(Conectar);

            Leer.Listen(10);

            Conexion = Leer.Accept();

            listBox1.Items.Add("CONEXION ESTABLECIDA    " + DateTime.Now);

            ConexionEstablecida = true;

            //timer1.Start();

            try
            {
             

                //ConexionEstablecida = true;

                //timer1.Start();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int cuantos = Conexion.Available;

            DimensionVector = Conexion.Receive(TramaRecibida, 0, TramaRecibida.Length, 0);

            Array.Resize(ref TramaRecibida, DimensionVector);

            if (TramaRecibida != null)
            {
                DatosRecibidos = Encoding.Default.GetString(TramaRecibida);
                listBox1.Items.Add(DatosRecibidos);
            }
                     
           
        }

    }
}


/*

Socket conexion;
IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6500);

listen.Bind(connect);
            listen.Listen(10);

            conexion = listen.Accept();
            Console.WriteLine("Conexion Aceptada");

            byte[] recibir_info = new byte[100];
string data = "";
int array_size = 0;

array_size = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);

            Array.Resize(ref recibir_info, array_size);

            data = Encoding.Default.GetString(recibir_info);

            Console.WriteLine("La Info recibida es : " + data);
            Console.ReadKey();


 *  Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket conexion;
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6500);

            listen.Bind(connect);
            listen.Listen(10);

            conexion = listen.Accept();
            Console.WriteLine("Conexion Aceptada");

            byte[] recibir_info = new byte[100];
            string data = "";
            int array_size = 0;

            array_size = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);

            Array.Resize(ref recibir_info, array_size);

            data = Encoding.Default.GetString(recibir_info);

            Console.WriteLine("La Info recibida es : " + data);
            Console.ReadKey();
 * 
 */


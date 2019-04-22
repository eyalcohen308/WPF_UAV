using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FlightSimulator.Model.Interface;
using FlightSimulator.ViewModels;
using System.Net;
using System.Net.Sockets;
namespace FlightSimulator.ViewModels.Windows
{
    class Server:BaseNotify
    {
        private static Server server = null;
        private TcpListener tcpListener;
        private string socketData;
        private volatile bool toStop;
        private readonly object mut;
        /// <summary>
        /// SingleTon Server, Private CTOR.
        /// </summary>
        private Server()
        {
            tcpListener = null;
            mut = new Object();
            toStop = false;
            socketData = "";
        }
        public static Server getInstnace
        {
            get
            {
                return server == null ? new Server() : server;
            }
        }
        public string SocketData
        {
            get
            {
                return socketData;
            }
            set
            {
                socketData = value;
                NotifyPropertyChanged("SocketData");
            }
        }
        public Object Mut
        {
            get
            {
                return mut;
            }
        }
        public void open(string ip, int port)
        {
            try
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
                tcpListener = new TcpListener(ep);
                tcpListener.Start();
                Console.WriteLine("Waiting for incoming connections...");
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("Accepted Client !");
                NetworkStream stream = client.GetStream();
                Thread t = new Thread(() => {
                    while (!toStop)
                    {
                        if (stream.DataAvailable)
                        {
                            byte[] buffer = new byte[1024];
                            int read = stream.Read(buffer, 0, buffer.Length);
                            string parsedData = Encoding.UTF8.GetString(buffer, 0, read);
                            SocketData = parsedData;
                        }
                    }
                    stream.Close();
                    client.Close();
                });
                t.Start();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                tcpListener.Stop();
            }
        }
        public void close()
        {
            toStop = true;
        }
        public bool isServerOpen()
        {
            return this.tcpListener!=null;
        }
    }
}

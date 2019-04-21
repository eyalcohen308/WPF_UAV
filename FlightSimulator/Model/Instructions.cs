using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Net;
using FlightSimulator.Model.Interface;
using System.Net.Sockets;
namespace FlightSimulator.Model
{
    class Instructions
    {
        private TcpClient client;
        private NetworkStream stream;
        private readonly object mut;
        private static Instructions instructions=null;
        private Dictionary<string, string> commandsToPath;
        
        /**
         * Private CTOR - SingleTon.
         **/
         private Instructions()
        {
            client = null;
            stream = null;
            commandsToPath = new Dictionary<string, string>();
            mut = new object();
            InitPathMapValues();
        }
        public static Instructions getInstance
        {
            get
            {
                // if exists return instance, else create it and return.
                return null == instructions ? new Instructions() : instructions;
            }
        }
        public void ManualSendCommand(string command,double val)
        {
            if (client == null)
            {
                return;
            }
            string line = "set " + commandsToPath[command] + " ";
            line += val.ToString("N5");
            lock (mut)
            {
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(line.ToString());
                stream.Write(buffer, 0, buffer.Length);
                Console.WriteLine("command: " + line + " sent");
            }
        }
        private void InitPathMapValues()
        {
            commandsToPath.Add("rudder", "/controls/flight/rudder");
            commandsToPath.Add("throttle", "/controls/engines/current-engine/throttle");
            commandsToPath.Add("aileron", "/controls/flight/aileron");
            commandsToPath.Add("elevator", "/controls/flight/elevator");
        }
    }
}

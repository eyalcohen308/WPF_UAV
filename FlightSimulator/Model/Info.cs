using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FlightSimulator.Model.Interface;
using FlightSimulator.ViewModels;
namespace FlightSimulator.Model
{
    static class Constants
    {
        public const string LON_PATH = "/position/longitude-deg";
        public const string LAT_PATH = "/position/latitude-deg";
        public const char COMMA = ',';
    }
    class Info:BaseNotify
    {
        private Data data;
        private Server server;

        public Info()
        {
            data = Data.getInstance;
            server = Server.getInstnace;
            server.PropertyChanged +=updateData;
        }
        private void updateData(object sender,PropertyChangedEventArgs e)
        {
            lock (server.Mut)
            {
                String[] values = server.SocketData.Split(Constants.COMMA);
                data.SetPathtoDataValues(values);
            }
            NotifyPropertyChanged("SocketData");
        }
        public double Lon
        {
            get
            {
                lock (server.Mut)
                {
                    Console.Write("LON: "+data[Constants.LON_PATH]);
                    return data[Constants.LON_PATH];
                }
            }
        }
        public double Lat
        {
            get
            {
                lock (server.Mut)
                {
                    Console.Write("LAT: "+data[Constants.LAT_PATH]);
                    return data[Constants.LAT_PATH];
                }
            }
        }
    }
}

using FlightSimulator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model;
using System.Windows.Input;
using System.ComponentModel;
namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
        private double lon, lat;
        private Info info;
        public FlightBoardViewModel()
        {
            info = new Info();
            lon = 0;
            lat = 0;
            info.PropertyChanged += updateData;
           
        }
        private void updateData(object sender,PropertyChangedEventArgs e)
        {
            Lon = info.Lon;
            Lat = info.Lat;
            NotifyPropertyChanged("Lon");
            NotifyPropertyChanged("Lat");

        }

        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
            }
        }

        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
            }
        }


    }
}

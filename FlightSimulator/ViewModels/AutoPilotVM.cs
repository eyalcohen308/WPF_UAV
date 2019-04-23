using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlightSimulator.Model;
namespace FlightSimulator.ViewModels
{
    class AutoPilotVM : BaseNotify
    {
        private string color;
        private string text;
        private ICommand _okCommand;
        private ICommand _clearCommand;
        private bool startedWrite;
        /**
         * CTOR:
         * */
        public AutoPilotVM()
        {
            color = "White";
            text = "";
            startedWrite = false;
            _okCommand = null;
            _clearCommand = null;
        }
        public string TextProperty
        {
            get
            {
                return text;
            }
            set
            {
                startedWrite = true;
                text = value;
                NotifyPropertyChanged("TextProperty");
                NotifyPropertyChanged("Color");
            }
        }
        public string Color
        {
            get
            {
                color = startedWrite ? "Pink" : "White";
                return color;
            }
        }
        public ICommand clearCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand = new CommandHandler(() => FlushBox()));
            }
        }
        public ICommand okCommand
        {
            get
            {
                return _okCommand ?? (_okCommand = new CommandHandler(() => SendInstructions()));
            }
        }

        private void FlushBox()
        {
            startedWrite = false;
            text = "";
            NotifyPropertyChanged("TextProperty");
            NotifyPropertyChanged("Color");
        }
        private void SendInstructions()
        {
            string[] delimeter = { "\r\n" };
            List<string> lines = text.Split(delimeter, StringSplitOptions.None).ToList();
            startedWrite = false;
            //text = "";
            //NotifyPropertyChanged("TextProperty");
            Instructions.getInstance.send(lines);
            NotifyPropertyChanged("Color");
        }
    }
}

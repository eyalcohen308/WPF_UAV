using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model;
using FlightSimulator.Views;
using System.Windows.Input;
namespace FlightSimulator.ViewModels
{
    class LUserControlVM
    {
        private Instructions client;
        private Settings settings;
        private ICommand _connect;
        private ICommand _openSettings;

        public LUserControlVM()
        {
            client = Instructions.getInstance;
        }
        public ICommand ConnectCommand
        {
            get
            {
                return _connect ?? (_connect = new CommandHandler(() => funcConnect()));
            }
        }
        private void funcConnect()
        {
            Server.getInstnace.open(ApplicationSettingsModel.Instance.FlightServerIP, ApplicationSettingsModel.Instance.FlightInfoPort);
            Instructions.getInstance.open(ApplicationSettingsModel.Instance.FlightServerIP, ApplicationSettingsModel.Instance.FlightCommandPort);
        }


        public ICommand OpenSettingsCommand
        {
            get
            {
                return _openSettings ?? (_openSettings = new CommandHandler(() => funcOpenSettings()));
            }
        }
        private void funcOpenSettings()
        {
            settings = new Settings();
            settings.ShowDialog();
        }

    }
}

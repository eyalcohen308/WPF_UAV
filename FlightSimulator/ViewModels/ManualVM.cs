﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model;
namespace FlightSimulator.ViewModels
{
    class ManualVM : BaseNotify
    {
        private double _aileron;
        private double _throttle;
        private double _rudder;
        private double _elevator;
        private Instructions instructionsModel;
        public ManualVM(Instructions ins)
        {
            _aileron = 0;
            _elevator = 0;
            _rudder = 0;
            _throttle = 0;
            instructionsModel = ins;
        }
        public double ChangeRudder
        {
            get
            {
                return _rudder;
            }
            set
            {
                _rudder = value;
                NotifyPropertyChanged("ChangeRudder");
                // Send to property changed to commands and from there to server.
                instructionsModel.ManualSendCommand("rudder", value);
            }

        }
        public double ChangeThrottle
        {
            get
            {
                return _throttle;
            }
            set
            {
                _throttle = value;
                NotifyPropertyChanged("ChangeThrottle");
                // Send to property changed to commands and from there to server.
                instructionsModel.ManualSendCommand("throttle", value);
            }
        }
        public double ChangeAileron
        {
            get
            {
                return _aileron;
            }
            set
            {
                _aileron = value;
                NotifyPropertyChanged("ChangeAileron");
                // Send to property changed to commands and from there to server.
                instructionsModel.ManualSendCommand("aileron", value);
            }
        }
        public double ChangeElevator
        {
            get
            {
                return _elevator;
            }
            set
            {
                _elevator = value;
                NotifyPropertyChanged("ChangeElevator");
                // Send to property changed to commands and from there to server.
                instructionsModel.ManualSendCommand("elevator",value);
            }
        }
    }
    }

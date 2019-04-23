using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    class Data
    {
        private Dictionary<string, double> pathToValue;
        private static Data data = null;
        /// <summary>
        /// SingleTon of Flight Data from the server.
        /// </summary>
        private Data()
        {
            pathToValue = new Dictionary<string, double>();
            DataInitialize();
        }
        public static Data getInstance
        {
            get
            {
                return data == null ? data=new Data() : data;
            }
        }
        // indexer, can use info with [], return the number if key exists, else return Nan.
        public double this [string key]
        {
            get
            {
                return pathToValue.ContainsKey(key) ? pathToValue[key] : Double.NaN;
            }
        }
        private void DataInitialize()
        {
            pathToValue.Add("/position/longitude-deg", 0);
            pathToValue.Add("/position/latitude-deg", 0);
            pathToValue.Add("/instrumentation/airspeed-indicator/indicated-speed-kt", 0);
            pathToValue.Add("/instrumentation/altimeter/indicated-altitude-ft", 0);
            pathToValue.Add("/instrumentation/altimeter/pressure-alt-ft", 0);
            pathToValue.Add("/instrumentation/attitude-indicator/indicated-pitch-deg", 0);
            pathToValue.Add("/instrumentation/attitude-indicator/indicated-roll-deg", 0);
            pathToValue.Add("/instrumentation/attitude-indicator/internal-pitch-deg", 0);
            pathToValue.Add("/instrumentation/attitude-indicator/internal-roll-deg", 0);
            pathToValue.Add("/instrumentation/encoder/indicated-altitude-ft", 0);
            pathToValue.Add("/instrumentation/encoder/pressure-alt-ft", 0);
            pathToValue.Add("/instrumentation/gps/indicated-altitude-ft", 0);
            pathToValue.Add("/instrumentation/gps/indicated-ground-speed-kt", 0);
            pathToValue.Add("/instrumentation/gps/indicated-vertical-speed", 0);
            pathToValue.Add("/instrumentation/heading-indicator/indicated-heading-deg", 0);
            pathToValue.Add("/instrumentation/magnetic-compass/indicated-heading-deg", 0);
            pathToValue.Add("/instrumentation/slip-skid-ball/indicated-slip-skid", 0);
            pathToValue.Add("/instrumentation/turn-indicator/indicated-turn-rate", 0);
            pathToValue.Add("/instrumentation/vertical-speed-indicator/indicated-speed-fpm", 0);
            pathToValue.Add("/controls/flight/aileron", 0);
            pathToValue.Add("/controls/flight/elevator", 0);
            pathToValue.Add("/controls/flight/rudder", 0);
            pathToValue.Add("/controls/flight/flaps", 0);
            pathToValue.Add("/controls/engines/current-engine/throttle", 0);
            pathToValue.Add("/engines/engine/rpm", 0);
        }
        public void SetPathtoDataValues(String[] tokens)
        {
            try
            {
                pathToValue["/position/longitude-deg"] = Double.Parse(tokens[0]);
                pathToValue["/position/latitude-deg"] = Double.Parse(tokens[1]);
                pathToValue["/instrumentation/airspeed-indicator/indicated-speed-kt"] = Double.Parse(tokens[2]);
                pathToValue["/instrumentation/altimeter/indicated-altitude-ft"] = Double.Parse(tokens[3]);
                pathToValue["/instrumentation/altimeter/pressure-alt-ft"] = Double.Parse(tokens[4]);
                pathToValue["/instrumentation/attitude-indicator/indicated-pitch-deg"] = Double.Parse(tokens[5]);
                pathToValue["/instrumentation/attitude-indicator/indicated-roll-deg"] = Double.Parse(tokens[6]);
                pathToValue["/instrumentation/attitude-indicator/internal-pitch-deg"] = Double.Parse(tokens[7]);
                pathToValue["/instrumentation/attitude-indicator/internal-roll-deg"] = Double.Parse(tokens[8]);
                pathToValue["/instrumentation/encoder/indicated-altitude-ft"] = Double.Parse(tokens[9]);
                pathToValue["/instrumentation/encoder/pressure-alt-ft"] = Double.Parse(tokens[10]);
                pathToValue["/instrumentation/gps/indicated-altitude-ft"] = Double.Parse(tokens[11]);
                pathToValue["/instrumentation/gps/indicated-ground-speed-kt"] = Double.Parse(tokens[12]);
                pathToValue["/instrumentation/gps/indicated-vertical-speed"] = Double.Parse(tokens[13]);
                pathToValue["/instrumentation/heading-indicator/indicated-heading-deg"] = Double.Parse(tokens[14]);
                pathToValue["/instrumentation/magnetic-compass/indicated-heading-deg"] = Double.Parse(tokens[15]);
                pathToValue["/instrumentation/slip-skid-ball/indicated-slip-skid"] = Double.Parse(tokens[16]);
                pathToValue["/instrumentation/turn-indicator/indicated-turn-rate"] = Double.Parse(tokens[17]);
                pathToValue["/instrumentation/vertical-speed-indicator/indicated-speed-fpm"] = Double.Parse(tokens[18]);
                pathToValue["/controls/flight/aileron"] = Double.Parse(tokens[19]);
                pathToValue["/controls/flight/elevator"] = Double.Parse(tokens[20]);
                pathToValue["/controls/flight/rudder"] = Double.Parse(tokens[21]);
                pathToValue["/controls/flight/flaps"] = Double.Parse(tokens[22]);
                pathToValue["/controls/engines/current-engine/throttle"] = Double.Parse(tokens[23]);
                pathToValue["/engines/engine/rpm"] = Double.Parse(tokens[24]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

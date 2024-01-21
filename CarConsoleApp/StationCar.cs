using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    internal class StationCar : Car
    {
 
        public string _stationmodel { get; set; }

        public StationCar(string stationmodel, string regno, string model, int hk)
        {

            _stationmodel = stationmodel;
            RegNo = regno;
            Model = model;
            Hk = hk;
            

        }

        public override string ToString()
        {
            return $"{{{nameof(_stationmodel)}={_stationmodel}, {nameof(RegNo)}={RegNo}, {nameof(Model)}={Model}, {nameof(Hk)}={Hk.ToString()}}}";
        }
    }
}

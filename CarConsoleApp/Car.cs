using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class Car
    {
        public string RegNo { get; set; }
        public string Model { get; set; }
        public int Hk { get; set; }

        public Car()
        {
            RegNo = string.Empty;
            Model = string.Empty;
            Hk = 0;
        }

        public Car(string registraionNumber, string model, int hk)
        {
            RegNo = registraionNumber;
            Model = model;
            Hk = hk;
        }

        public override string ToString()
        {
            return $"{{{nameof(RegNo)}={RegNo}, {nameof(Model)}={Model}, {nameof(Hk)}={Hk.ToString()}}}";
        }
    }
}

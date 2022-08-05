using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_Bus
    {
        private int _idbus;
        private string _brand;
        private string _model;
        private string _license_plate;
        private string _color;
        private string _year;

        public int IdBus { get => _idbus;  set => _idbus = value; } 
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value;}
        public string License_Plate { get => _license_plate; set => _license_plate = value; }
        public string Color { get => _color; set => _color = value; }
        public string year { get => _year; set => _year = value;}
    }
}

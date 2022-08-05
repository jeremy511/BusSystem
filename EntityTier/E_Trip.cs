using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_Trip
    {
        private int _IdTrip;
        private int _IdDriver;
        private string _Driver;
        private string _Idtificarion_Card;
        private string _Model;
        private string _Brand;
        private int _IdBus;
        private int _IdRoute;
        private string _NameRoute;
        private string _Distance;
        private int _Stop;


        public int IdTrip { get => _IdTrip; set => _IdTrip = value; }
        public int IdDriver { get => _IdDriver; set => _IdDriver = value; }
        public string Driver { get => _Idtificarion_Card; set => _Idtificarion_Card = value; }    
        public string Idtification { get => _Driver; set => _Driver = value; }       
        public int IdBus { get => _IdBus; set => _IdBus = value; }
        public string Model { get => _Model; set => _Model = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public int IdRoute { get => _IdRoute; set => _IdRoute = value; }
        public string Route { get => _NameRoute; set => _NameRoute= value; }
        public string Distance { get => _Distance; set => _Distance = value; }
        public int Stop { get => _Stop; set => _Stop = value; }

    }
}

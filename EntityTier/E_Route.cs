using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_Route
    {

        private int _IdRoute;
        private string _Name;
        private string _Distance;
        private int _Stop;


        public int IdRoute { get => _IdRoute; set => _IdRoute = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Distance { get => _Distance; set => _Distance = value; }
        public int Stop { get => _Stop; set => _Stop = value; }


    }
}

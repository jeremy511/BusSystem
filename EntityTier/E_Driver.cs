using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_Driver
    {
        private int _IdDriver;
        private string _Name;
        private string _Lastname;
        private DateTime _BirthDate;
        private string _Cedula;


        public int IdDriver { get => _IdDriver; set => _IdDriver = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Lastname { get => _Lastname; set => _Lastname = value; }
        public DateTime BirthDate { get => _BirthDate; set => _BirthDate = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }

    }
}

using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;

namespace BusinessTier
{
    public class B_Trip
    {
        D_Trip objData = new D_Trip();
        public List<E_Trip> ListAllTrip(string find)
        {
            return objData.ListAllTrip(find);
        }

        public void InsertTrip(E_Trip trip)
        {
            objData.InsertTrip(trip);
        }

        public void EditTrip(E_Trip trip)
        {
            objData.EditTrip(trip);
        }

        public void DeleteTrip(E_Trip trip)
        {
            objData.DeleteTrip(trip);
        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using EntityTier;

namespace BusinessTier
{
    public class B_Bus
    {
        D_Bus objData = new D_Bus();
        public List<E_Bus> ListAllBus(string find)
        {
            return objData.ListAllBus(find);
        }

        public void InsertBus(E_Bus autobuses)
        {
            objData.InsertBus(autobuses);
        }

        public void EditBus(E_Bus autobuses)
        {
            objData.EditBus(autobuses);
        }

        public void DeleteBus(E_Bus autobuses)
        {
            objData.DeleteBus(autobuses);
        }
    }
}

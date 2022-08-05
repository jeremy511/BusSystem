using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using DataTier;

namespace BusinessTier
{
    public class B_Route
    {
        D_Route objData = new D_Route();
        public List<E_Route> ListAllRoute(string find)
        {
            return objData.ListAllRoute(find);
        }

        public void InsertRoute(E_Route route)
        {
            objData.InsertRoute(route);
        }

        public void EditRoute(E_Route route)
        {
            objData.EditRoute(route);
        }

        public void DeleteRoute(E_Route route)
        {
            objData.DeleteRoute(route);
        }
    }
}

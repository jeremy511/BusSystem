using DataTier;
using EntityTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class B_Driver
    {

        D_Driver objData = new D_Driver();
        public List<E_Driver> ListAllDriver(string find)
        {
            return objData.ListAllDriver(find);
        }

        public void InsertDriver(E_Driver driver)
        {
            objData.InsertDriver(driver);
        }

        public void EditDriver(E_Driver driver)
        {
            objData.EditDriver(driver);
        }

        public void DeleteDriver(E_Driver driver)
        {
            objData.DeleteDriver(driver);
        }
    }
}


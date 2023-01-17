using OrderApp.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class DBConnection
    {
        public static SellPencilEntities connection = new SellPencilEntities();
    }
}

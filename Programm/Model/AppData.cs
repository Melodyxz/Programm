using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm.Model
{
    public static class AppData
    {
        public static CheltipoEntities2 db = new CheltipoEntities2();
        public static User currentUser;
    }
}

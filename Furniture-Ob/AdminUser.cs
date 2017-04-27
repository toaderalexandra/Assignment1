using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Ob
{
    public class AdminUser : User
    {
        public override string type
        {
            get
            {
                return "Admin";
            }
            set
            {
                type = "Admin";
            }
        }
    }
}

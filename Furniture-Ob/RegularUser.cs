using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Ob
{
    public class RegularUser : User
    {
        public override string type
        {
            get
            {
                return "User";
            }
            set
            {
                type = "User";
            }
        }
    }
}

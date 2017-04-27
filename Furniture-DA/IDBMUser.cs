using System;
using Furniture_Ob;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_DA
{
    public interface IDBMUser
    {
        //IList<User> RetrieveUsers;
        //int CheckUser(User user, string password);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}

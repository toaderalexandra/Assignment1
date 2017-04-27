using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furniture_Ob;
using Furniture_DA;

namespace Furniture_B
{
   public class Login
    {
       public User ProcessLogin (string username, string password)
        {
            int result;
            UserDB userDB = new UserDB();
            string md5password = Encrypt.GetMD5(password);
           // result = userDB.CheckUser(username, md5password);
            result = 1;
            User userLogin = null;


            if (result == 1)
            {
                userLogin = new AdminUser();
                userLogin.UserName = username;
                userLogin.Password = password;
            }
            else if (result == 2)
            {
                userLogin = new RegularUser();
                userLogin.UserName = username;
                userLogin.Password = password;
            }

            return userLogin;
        }
    }
}

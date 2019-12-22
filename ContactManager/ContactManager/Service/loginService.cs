using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Service
{
    class loginService
    {
        public static User CheckLogin(String un, String pw)
        {
            //return new ContactDBContent().Users.Single(e => e.userName == un && e.password == pw);
            return new ContactDBContent().Users.Where(e => e.userName == un && e.password == pw).FirstOrDefault();
        }
    }
}
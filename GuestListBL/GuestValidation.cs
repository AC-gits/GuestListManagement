using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestListBL
{
    public class GuestValidation
    {
        GuestListServices getservices = new GuestListServices();

        public bool CheckIfGuestNameExists(string name)
        {
            bool result = getservices.GetUser(name) != null;
            return result;

        }
        public bool CheckIfGuestNameExists(string name, string nationality, string email, string age)
        {
            bool result = getservices.GetUser(name, nationality, email, age) != null;
            return result;
        }
    }
}

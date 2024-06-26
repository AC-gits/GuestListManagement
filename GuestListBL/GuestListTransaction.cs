using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GuestListDL;
using GuestListModel;
namespace GuestListBL
{
    public class GuestListTransaction

    {
        GuestValidation validationServices = new GuestValidation();
        GuestListD userData = new GuestListD();


        public bool CreateGuest(Guest user)
        {
            bool result = false;

            if (validationServices.CheckIfGuestNameExists(user.name))
            {
                result = userData.AddGuest(user) > 0;
            }

            return result;
        }

        public bool CreateGuest(string name, string nationality, string email, string age)
        {
            Guest user = new Guest { name = name, nationality = nationality, email = email, age=age };
            return CreateGuest(user);
        }

        public bool UpdateGuest(Guest user)
        {
            bool result = false;

            if (validationServices.CheckIfGuestNameExists(user.name))
            {
                result = userData.UpdateGuest(user) > 0;
            }

            return result;
        }

        public bool UpdateGuest(string name, string nationality, string email, string age)
        {
            Guest user = new Guest  { name = name, nationality = nationality, email = email, age = age };
            return UpdateGuest(user);
        }

        public bool DeleteUser(Guest user)
        {
            bool result = false;

            if (validationServices.CheckIfGuestNameExists(user.name))
            {
                result = userData.DeleteGuest(user) > 0;
            }

            return result;
        }
    }
}

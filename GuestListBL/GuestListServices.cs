using GuestListDL;
using GuestListModel;
using System.Reflection;

namespace GuestListBL
{
    public class GuestListServices
    {
        public List<Guest> GetAllUser()
        {
            GuestListD GuestuserData = new GuestListD();

            return GuestuserData.GetUsers();
        }
        public Guest GetUser(string name)
        {
            Guest foundGuest = new Guest();

            foreach (var user in GetAllUser())
            {
                if (user.name == name)
                {
                    foundGuest = user;
                }
            }
            return foundGuest;
        }
        public Guest GetUser(string name, string nationality, string email, string age)
        {
            Guest foundGuest = new Guest();

            foreach (var user in GetAllUser())
            {
                if (user.name == name && user.nationality == nationality && user.email == email && user.age == age)
                {
                    foundGuest = user;
                }
            }
            return foundGuest;

        }
    }
}


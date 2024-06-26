using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GuestListModel;

namespace GuestListDL
{ 
    public class GuestLog()
{
    public List<Guest> dummyGuest = new List<Guest>();

    public List<Guest> GetDummyGuest()
    {
        dummyGuest.Add(CreateDummyGuest("Liam", "Filipino", "edwards@gmailcom", "31"));
        dummyGuest.Add(CreateDummyGuest("Matthew", "AFAM", "mttwz@gmail.com", "69"));

        return dummyGuest;
    }
    public Guest CreateDummyGuest(string name, string nationality, string email, string age)
    {
        Guest user = new Guest
        {
            name = name,
            nationality = nationality,
            email = email,
            age = age

        };

        return user;
    }
}
}
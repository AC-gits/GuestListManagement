using GuestListModel;
using System.Reflection;

namespace GuestListDL
{
    public class GuestListD
    {

            List<Guest> users;
            GuestDbData sqlData;
            public GuestListD()
            {
                users = new List<Guest>();
                sqlData = new GuestDbData();


            }
            public List<Guest> GetUsers()
            {
                users = sqlData.GetUsers();
                return users;
            }

            public int DeleteGuest(Guest user)
            {
                return sqlData.DeleteGuest(user.name);
            }
            public int AddGuest(Guest user)
            {
                return sqlData.AddGuest(user.name, user.nationality, user.email, user.age);
            }
            public int UpdateGuest(Guest user)
            {
                return sqlData.UpdateGuest(user.name, user.nationality, user.email, user.age);
            }
        }
    }


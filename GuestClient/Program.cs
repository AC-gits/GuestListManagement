
using GuestListBL;

namespace GuestClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            GuestListServices getServices = new GuestListServices();

            var users = getServices.GetAllUser();

            foreach (var item in users)
            {
                Console.WriteLine("Guest name: " + item.name);
                Console.WriteLine("Guest nationality: " + item.nationality);
                Console.WriteLine("Guest Contact email: " + item.email);
                Console.WriteLine("Guest Contact age: " + item.age);
            }
        }
    }
}

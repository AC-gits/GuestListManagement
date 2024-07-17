using Microsoft.AspNetCore.Mvc;
using GuestListBL;

namespace GuestListAPI.Controllers
{
    [ApiController]
    [Route("api/guest")]
    public class GuestController : Controller
    {
        GuestListServices _GetServices;
        GuestListTransaction _GetTransaction;

        public GuestController()
        {
            _GetServices = new GuestListServices();
            _GetTransaction = new GuestListTransaction();  
        }

        [HttpGet]
        public IEnumerable<GuestListAPI.Guest> GetGuest()
        {
            var guest = _GetServices.GetAllUser();

            List<GuestListAPI.Guest> guests = new List<GuestListAPI.Guest>();

            foreach (var item in guest)
            {
                guests.Add(new GuestListAPI.Guest { name = item.name, nationality = item.nationality, email = item.email, age = item.age});

            }
            return guests;
        }

        [HttpPost]
        public JsonResult AddGuest(Guest request)
        {
            var result = _GetTransaction.CreateGuest(request.name, request.nationality, request.email, request.age);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateGuest (Guest request)
        {
            var result = _GetTransaction.UpdateGuest(request.name, request.nationality, request.email, request.age);

            return new JsonResult(result);
        }
    }
}

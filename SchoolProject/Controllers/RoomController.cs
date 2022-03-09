using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }


        [HttpGet]
        public ActionResult index()
        {
            List<Room> room = _roomRepository.GetAllRooms();
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            if (room != null)
            {
                _roomRepository.Create(room);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                _roomRepository.Delete(id);
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        [HttpGet]
        public ActionResult index()
        {
            List<Teacher> teachers = _teacherRepository.GetAllTeachers();
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (teacher != null)
            {
                _teacherRepository.Create(teacher);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                _teacherRepository.Delete(id);
            }
            return View();
        }
    }
}

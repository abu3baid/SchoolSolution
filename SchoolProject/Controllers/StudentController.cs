using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        //List of Students
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> stdLst = _studentRepository.GetAllStudents();
            return View();
        }

        //Render The creation view
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentRepository.Create(student);
            return View();
        }

        public ViewResult Delete(int id)
        {
            _studentRepository.Delete(id);
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int studentId, int courseId)
        {
            _studentRepository.Register(studentId, courseId);
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Models.ViewModels;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public StudentController(IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }



        //List of Students
        [HttpGet]
        public ActionResult Index()
        {
            List<Student> stdLst = _studentRepository.GetAllStudents();
            return View(stdLst);
        }

        //Render The creation view
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if(student != null)
            {
                _studentRepository.Create(student);
            }
            List<Student> stdLst = _studentRepository.GetAllStudents();
            return View("Index", stdLst);
        }

        public ViewResult Delete(int id)
        {
            if(id != 0)
            {
                _studentRepository.Delete(id);
            }
            List<Student> stdLst = _studentRepository.GetAllStudents();
            return View("Index", stdLst);
        }

        [HttpGet]
        public ActionResult Register()
        {
            StudentCourseVM data = new StudentCourseVM();
            data.Courses = _courseRepository.GetAllCourses();
            data.Students = _studentRepository.GetAllStudents();
            return View(data);
        }

        [HttpPost]
        public ActionResult Register(int studentId, int courseId)
        {
            _studentRepository.Register(studentId, courseId);
            return RedirectToAction("Register");
        }
    }
}

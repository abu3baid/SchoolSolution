using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        //List of Students
        [HttpGet]
        public ActionResult Index()
        {
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
            return View();
        }

        public ViewResult Delete(int id)
        {
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
            return View();
        }
    }
}

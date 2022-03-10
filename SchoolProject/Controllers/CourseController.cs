using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        [HttpGet]
        public ActionResult index()
        {
            List<Course> courses = _courseRepository.GetAllCourses();
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (course != null)
            {
                _courseRepository.Create(course);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                _courseRepository.Delete(id);
            }
            return View();
        }
    }
}

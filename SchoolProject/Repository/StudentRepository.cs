using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _myDbConnection;

        public StudentRepository(MyDbContext myDbContext)
        {
            _myDbConnection = myDbContext;
        }


        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdsObj in _myDbConnection.Students
                                          select stdsObj).ToList();
                return students;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Create(Student student)
        { 
            _myDbConnection.Students.Add(student);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int Id)
        {
            Student student = (from stdObj in _myDbConnection.Students
                               where stdObj.StudentId == Id
                               select stdObj).FirstOrDefault();

            string studentName = (from myObj in _myDbConnection.Students
                                  select myObj.StudentName).FirstOrDefault();
            _myDbConnection.Students.Remove(student);
            _myDbConnection.SaveChanges();
        }

        public void Register(int studentId, int courseId)
        {
            StudentCourse obj = new StudentCourse();
            obj.CourseId = courseId;
            obj.StudentId = studentId;
            _myDbConnection.StudentCourses.Add(obj);
            _myDbConnection.SaveChanges();
        }
    }
}

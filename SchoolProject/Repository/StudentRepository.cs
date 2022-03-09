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
            List<Student> students = (from stdsObj in _myDbConnection.Students 
                                      select stdsObj).ToList();
            return students;

        }

        public void Create(Student student)
        {

        }

        public void Delete(int Id)
        {

        }

        public void Register(int studentId, int courseId)
        {

        }
    }
}

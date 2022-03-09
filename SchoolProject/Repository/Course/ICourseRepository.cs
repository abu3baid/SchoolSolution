﻿using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface ICourseRepository
    {
        public List<Course> GetAllCourses();
        public void Create(Course courses);
        public void Delete(int id);
    }
}

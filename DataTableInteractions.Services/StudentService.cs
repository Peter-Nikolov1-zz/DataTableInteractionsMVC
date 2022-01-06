using DataTableInteractions.Data;
using DataTableInteractions.Data.Entities;
using DataTableInteratctions.Models.StudentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInteractions.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Create
        public bool CreateStudent(StudentCreate model)
        {
            Student entity = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                BirthDate = model.BirthDate,
            };

            _context.Students.Add(entity);
            return _context.SaveChanges() == 1;
        }

        // Get ALL
        public List<StudentDetail> GetAllStudents()
        {
            var studentEntities = _context.Students.ToList();
            var studentList = studentEntities.Select(s => new StudentDetail
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Email = s.Email,
                BirthDate = s.BirthDate
            }).ToList();
            return studentList;
        }

        // Get (Details by ID)
        public StudentDetail GetStudentById(int studentId)
        {
            var studentEntity = _context.Students.Find(studentId);
            if (studentEntity == null) 
                return null;

            var studentDetail = new StudentDetail
            {
                Id = studentEntity.Id,
                FirstName = studentEntity.FirstName,
                LastName = studentEntity.LastName,
                Email = studentEntity.Email,
                BirthDate = studentEntity.BirthDate
            };
            return studentDetail;
        }


    }
}

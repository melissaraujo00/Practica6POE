using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class StudentService
    {
        private StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public DataTable GetAllStudent()
        {
            return _studentRepository.GetStudent();
        }

        public void AddStudent(Studen student)
        {
            _studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Studen student)
        {
            _studentRepository.EditStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

    }
}

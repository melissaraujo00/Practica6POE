using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Entities;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class CarrerService
    {
        private CareerRepository _carrerRepository;

        public CarrerService()
        {
            _carrerRepository = new CareerRepository();
        }

        public DataTable GetAllCarrers()
        {
            return _carrerRepository.GetCareers();
        }

        public void AddCareers(Career career)
        {
            _carrerRepository.AddCareer(career);
        }

        public void UpdateCareer(Career career)
        {
            _carrerRepository.EditCareer(career);
        }

        public void DeleteCareer(int id)
        {
            _carrerRepository.DeleteCareer(id);
        }


    }
}

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>

            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 500000, Description = "Mercedes marka,üstü açık, 2020 Model, siyah araba" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2015, DailyPrice = 350000, Description = "Mercedes marka, 2015 Model beyaz araba" },
                new Car { Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2018, DailyPrice = 150000, Description = "TOYOTA marka,2018 model, siyah araba" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 220000, Description = "TOYOTA marka,2020 model,beyaz araba" }
            };

        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = carToUpdate.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}

﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=4,ModelYear=2018,DailyPrice=250,Description="Sanruflu araba"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2022,DailyPrice=500,Description="Uçan araba"},
                new Car{Id=3,BrandId=1,ColorId=7,ModelYear=2010,DailyPrice=100,Description="Eski araba"},
                new Car{Id=4,BrandId=3,ColorId=2,ModelYear=2012,DailyPrice=180,Description="Aile araba"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c=>c.Id==car.Id);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}

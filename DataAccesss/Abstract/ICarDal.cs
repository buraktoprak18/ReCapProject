using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesss.Abstract
{
    public interface ICarDal
    {
        List<Car> All { get; }

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        List<Car> GetByID(int carId);



    }
}

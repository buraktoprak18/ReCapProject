using DataAccesss.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car; //Global 

        public List<Car> All => throw new System.NotImplementedException();

        public InMemoryCarDal() => _car = new List<Car>
            {
                new Car{CarID = 1, BrandID = 1, ColorID = 1, ModelYear = "2016", DailyPrice = 504,  Description = "TOYOTA GT86 200HP 2.0 AUTOMATIC"},
                new Car{CarID = 2, BrandID = 2, ColorID = 1, ModelYear = "1999", DailyPrice = 2500 ,Description = "NISSAN SKYLİNE GTR 220HP 2.0 MANUAL"},
                new Car{CarID = 3, BrandID = 3, ColorID = 2, ModelYear = "2009", DailyPrice = 201 , Description = "RENAULT MEGANE 1.5L 105HP EXCEPTION MANUAL"},
                new Car{CarID = 4, BrandID = 3, ColorID = 5, ModelYear = "2020", DailyPrice = 354 , Description = "RENAULT CLIO 1.0 TCE 100 HP X-TRONIC JOY"},
                new Car{CarID = 5, BrandID = 4, ColorID = 3, ModelYear = "2008", DailyPrice = 867 , Description = "VOLKSWAGEN JETTA 1.6 TDI 85 HP MANUAL"},
                new Car{CarID = 6, BrandID = 5, ColorID = 4, ModelYear = "2019", DailyPrice = 626 , Description = "NISSAN QASHQAI 1.6 DCI SKYPACK XTRONIC"},
            };
        public void Add(Car car)
        {
            _car.Add(car);

        }

        public void Delete(Car car)
        {
            //Program.cs'den gelen Car new'lenerek geliyor farklı bellek nosuna sahip. _car listesinin her elemeanı da new'lendiği için farklı bellek nolarına sahipler.
            //Bu yüzden car silmemeiz için referanslarını eşleştirmemiz gerekiyor. 
            //Bu eşleştirmeyi L
            Car carToDelete = _car.SingleOrDefault(p => p.CarID == car.CarID);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarID == car.CarID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByID(int carId)
        {
            return _car.Where(p => p.CarID == carId).ToList();
        }


    }
}


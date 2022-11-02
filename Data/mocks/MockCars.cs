using Shop.Data.interfaces;
using Shop.Data.mocs;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Fast car",
                        longDesc = "Comfortable, quiet, modern and family car from Tesla",
                        img = "https://elektrowoz.pl/wp-content/uploads/2020/12/Tesla-Model-S-Performance.jpg",
                        price = 50000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.First()
                    },
                    new Car
                    {
                        name = "BMW M4 Competition",
                        shortDesc = "Extreme car",
                        longDesc = "Incredibly beautiful car for real racing fans. As the owner of this car, you will be an authority in your city",
                        img = "https://www.motortrend.com/uploads/sites/5/2021/04/2021-bmw-m4-exterior-01.jpg",
                        price = 85000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Toyota Supra MK4",
                        shortDesc = "Exclusive car",
                        longDesc = "",
                        img = "https://www.auto-motor-i-sport.pl/media/lib/2703/232911_front_3-4_web-499974aefc44fd217c85fecdbe217a85.jpg",
                        price = 70000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavouriteCars { get ; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}

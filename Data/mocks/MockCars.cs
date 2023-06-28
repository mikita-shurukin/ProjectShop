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
                        img = "/img/teslaModelS.jpg",
                        price = 340000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.First()
                    },
                    new Car
                    {
                        name = "BMW M4 Competition",
                        shortDesc = "Extreme car",
                        longDesc = "Incredibly beautiful car for real racing fans. As the owner of this car, you will be an authority in your city",
                        img = "/img/bmwm4.jpg",
                        price = 485000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes c63 w204",
                        shortDesc = "Extreme car",
                        longDesc = "Incredibly beautiful car for real racing fans. As the owner of this car, you will be an authority in your city",
                        img = "/img/merc_c63.jpg",
                        price = 199000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Audi RS6",
                        shortDesc = "Extreme car",
                        longDesc = "Incredibly beautiful car for real racing fans. As the owner of this car, you will be an authority in your city",
                        img = "/img/rs6.jpg",
                        price = 240000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Alfa Romeo Giulia",
                        shortDesc = "Extreme car",
                        longDesc = "Incredibly beautiful car for real racing fans. As the owner of this car, you will be an authority in your city",
                        img = "/img/giulia.jpg",
                        price = 230000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Toyota Supra MK4",
                        shortDesc = "Exclusive car",
                        longDesc = "",
                        img = "/img/supra.jpg",
                        price = 250000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Taycan Turbo S",
                        shortDesc = "Fast car",
                        longDesc = "",
                        img = "/img/taycan.jpg",
                        price = 463000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "BMW iX M60",
                        shortDesc = "Family Car",
                        longDesc = "",
                        img = "/img/ix.jpg",
                        price = 653000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    },
                    new Car
                    {
                        name = "Ford Bronco",
                        shortDesc = "Family Car",
                        longDesc = "",
                        img = "/img/ford.jpg",
                        price = 153000,
                        isFavourite = true,
                        avaible = true,
                        category = _categoryCars.AllCatigories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}

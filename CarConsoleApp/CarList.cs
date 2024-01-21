using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class CarList
    {

        protected List<Car> cars;
        protected List<Car> resultatliste;

        public CarList()
        {
            cars = new List<Car>();
        }

        // Func

        public void AddNewCar(string regno, string model, int hk)
        {
            Car newcar = new Car(regno, model, hk);
            cars.Add(newcar);
        }
        public void AddCurrentCar(Car car)
        {

            if (car.RegNo.Length < 7)
            {
                throw new ArgumentException($"Erorr: Regno has to contain at least 7 char");
            }
            else
            { cars.Add(car); }

        }

        public List<Car> GetCars()
        {
            return cars;
        }

        public Car GetCar( string regno)
        {
            var foundcar = cars.FirstOrDefault(k => k.RegNo == regno);

            if (foundcar != null)
            {
                return foundcar;
            }

            else
            {
                return null;
            }
        }

        public Car GetCar2(string regno)
        {
            var count = true; 
            while (count = true)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].RegNo == regno)
                    {
                        return (cars[i]);
                    }

                }
                count = false;
            }
            return null;
        }


        public List<Car> RemoveCar(string regno)
        {
            var foundCar = cars.FirstOrDefault(k => k.RegNo == regno);

            if(foundCar != null)
            {
                cars.Remove(foundCar);
                Console.WriteLine($"Item was removed: {foundCar}");
            }

            return null;

        }
        

        public List<Car> GetAllCarsRegno(string model)
        {
            List<Car> result = new List<Car>();

            for(int i = 0;i < cars.Count;i++)
            {
                if (cars[i].Model == model)
                {
                    result.Add(cars[i]);
                    Console.WriteLine($"Cars with same model type: {cars[i]}");
                }
            }
            return result;

        }


    }
}

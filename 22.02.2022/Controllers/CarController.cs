using _22._02._2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._2022.Controllers
{
    class CarController
    {
       public List<Car> GetAllCars()
        {
            using (CarsDBEntities ex = new CarsDBEntities())
            {
                return ex.Cars.ToList();
            }
        }
    }
}

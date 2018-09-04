using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.id.server.DbConfig;
using car.id.server.Models;

namespace car.id.server.Repositories
{
    public class CarIdRepository : ICarIdRepository
    {
        private CarIdDataContext CarIdDataContext { get; set; }

        public CarIdRepository()
        {
            CarIdDataContext = new CarIdDataContext();
        }

        public CarInfo GetCarIdByCarNumber(string carNumber)
        {
            return null;
        }

        public void NewCarIdInfo(CarInfo CarInfo)
        {
            CarIdDataContext.Add<CarInfo>(CarInfo);
           
        }

        public void Save()
        {
            CarIdDataContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using car.id.server.DbConfig;
using car.id.server.Models;
using Microsoft.EntityFrameworkCore;

namespace car.id.server.Repositories {
    public class CarIdRepository : ICarIdRepository {
        private CarIdDataContext CarIdDataContext { get; set; }

        public CarIdRepository() {
            CarIdDataContext = new CarIdDataContext();
        }

        public CarInfo GetCarIdByCarNumber(string carNumber) {
            CarInfo carInfo;

            try {
                carInfo = CarIdDataContext.Posts.AsNoTracking().FirstOrDefault(n => n.NRegNew.Contains(carNumber));
            } catch (Exception ex) {
                Debug.WriteLine($"ERROR:{ex}");
                throw;
            }

            return carInfo;
        }

        public Task<List<CarInfo>> GetCarinfoByCarNumberAsync(string carNumber) =>
            Task.Run(() => {
                List<CarInfo> carInfos = new List<CarInfo>();
                try {
                    carInfos = CarIdDataContext.Posts.AsNoTracking().Where(n => n.NRegNew.Contains(carNumber)).ToList();
                } catch (Exception ex) {
                    Debug.WriteLine($"ERROR:{ex}");
                    return new List<CarInfo>();
                }
                return carInfos;
            });

        public void NewCarIdInfo(CarInfo CarInfo) {
            CarIdDataContext.Add<CarInfo>(CarInfo);

        }

        public void Save() {
            CarIdDataContext.SaveChanges();
        }

    }
}

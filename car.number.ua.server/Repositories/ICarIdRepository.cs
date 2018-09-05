using car.id.server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car.id.server.Repositories {
    public interface ICarIdRepository {
        void NewCarIdInfo(CarInfo CarInfo);

        CarInfo GetCarIdByCarNumber(string carNumber);

        Task<List<CarInfo>> GetCarinfoByCarNumberAsync(string carNumber);

        Task<IEnumerable<CarInfo>> SearchForInfoByLicencePlate(string number);

        void Save();
    }
}

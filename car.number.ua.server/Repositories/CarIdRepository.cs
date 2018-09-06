using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using car.id.server.DbConfig;
using car.id.server.Models;
using Dapper;
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
                throw new Exception(ex.Message);
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

        public Task<IEnumerable<CarInfo>> SearchForInfoByLicencePlate(string number) =>
            Task.Run(() => {
                using (IDbConnection connection = new SqlConnection(@"Data Source=192.168.0.13;Initial Catalog=CarIdDb;Integrated Security=False;User ID=ef_migrator;Password=Grimm_jow92;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;")) {

                    return connection.Query<CarInfo>(
                        ";WITH [Search_CTE] " +
                        "AS ( " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2013] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        "UNION ALL " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2014] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        "UNION ALL " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2015] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        "UNION ALL " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2016] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        "UNION ALL " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2017] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        "UNION ALL " +
                        "SELECT ID, Person, RegAddrKoatuu, OperCode, OperName, DReg, DepCode, Dep, Brand, ModelName, MakeYear, Color, Kind, Body, Purpose, Fuel, Capacity, OwnWeight, TotalWeight, NRegNew " +
                        "FROM [Posts2018] " +
                        "WHERE PATINDEX(@Value, NRegNew) > 0 " +
                        ") " +
                        "SELECT * " +
                        "FROM [Search_CTE] ",
                        new { Value = $"%{number.Trim()}%" }
                        );
                }
            });

        public void NewCarIdInfo(CarInfo CarInfo) {
            CarIdDataContext.Add<CarInfo>(CarInfo);

        }

        public void Save() {
            CarIdDataContext.SaveChanges();
        }

    }
}

using car.id.server.Helpers;
using car.id.server.Models;
using car.id.server.Repositories;
using ConsoleApp2;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.id.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarIdController : ControllerBase
    {
        public CarIdController()
        {

        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        
            {
            ICarIdRepository repo = new CarIdRepository();

            try
            {
                var d = DataBuilder.GetData();
                d.ForEach(t =>
                {
                    var CarIdInfo = new CarInfo
                    {
                        Body = t.Body,
                        Brand = t.Brand,
                        Capacity = t.Capacity,
                        Color = t.Color,
                        Dep = t.Dep,
                        DepCode = t.DepCode,
                        DReg = t.DReg,
                        Fuel = t.Fuel,
                        Kind = t.Kind,
                        MakeYear = t.MakeYear,
                        ModelName = t.ModelName,
                        NRegNew = t.NRegNew,
                        OperCode = t.OperCode,
                        OperName = t.OperName,
                        OwnWeight = t.OwnWeight,
                        Person = t.Person,
                        Purpose = t.Purpose,
                        RegAddrKoatuu = t.RegAddrKoatuu,
                        TotalWeight = t.TotalWeight
                    };

                    repo.NewCarIdInfo(CarIdInfo);
                });

                repo.Save();
            }
            catch (Exception exc)
            {
                throw;
            }
            return "value";
        }

        [HttpPost()]
        public IActionResult Post()
        {
            ICarIdRepository repo = new CarIdRepository();

            try
            {
                var d = DataBuilder.GetData();
               
                //repo.NewCarIdInfo(null);
            }
            catch (Exception)
            {

                throw;
            }

            return Ok();
        }
    }
}

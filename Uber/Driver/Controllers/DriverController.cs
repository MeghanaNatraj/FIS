using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        //// GET: api/<DriverController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        static List<Driver> driverList = new List<Driver>
        {
            new Driver(){DriverId = 01, DriverName="Rajesh",DriverPhone=265653},
            new Driver(){DriverId = 02, DriverName="Sohan",DriverPhone=267663}
        };
        public IEnumerable<Driver> Get()
        {  
              return driverList;
        }
        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            return driverList.Find(x=>x.DriverId==id);
        }

        // POST api/<DriverController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
        [HttpPost]
        public IEnumerable<Driver> Post([FromBody] Driver driver)
        {
            driverList.Add(driver);
            return driverList;
        }
        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public IEnumerable<Driver> Put(int id, [FromBody] Driver driver)
        {
            int i = driverList.FindIndex(x => x.DriverId == id);
            driverList[i] = driver;
            return driverList;
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

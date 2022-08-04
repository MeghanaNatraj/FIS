using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Uber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        // GET: api/<PassengerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        static List<Passenger> passengerList = new List<Passenger>
        {
            new Passenger(){PassengerId = 01, PassengerName="Rajesh",PhoneNumber=265653, Adresss="Basaveswaranagar Bangalore"},
            new Passenger(){PassengerId = 02, PassengerName="Sohan",PhoneNumber=267765, Adresss="Rajajinagar Bangalore"}
        };
        public IEnumerable<Passenger> Get()
        {
            return passengerList;

        }

        // GET api/<PassengerController>/5
        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            return passengerList.Find(x => x.PassengerId == id);
        }

        // POST api/<PassengerController>
        [HttpPost]
        public IEnumerable<Passenger> Post([FromBody] Passenger passenger)
        {
            passengerList.Add(passenger);
            return passengerList;
        }

        // PUT api/<PassengerController>/5
        [HttpPut("{id}")]
        public IEnumerable<Passenger> Put(int id, [FromBody] Passenger passenger)
        {
            int i = passengerList.FindIndex(x => x.PassengerId == id);
            passengerList[i] = passenger;
            return passengerList;
        }

        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

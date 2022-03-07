using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opgave4.Models;
using opgave4.Managers;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace opgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarManager _manager = new CarManager();
        // GET: api/<CarController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            IEnumerable<Car> carList = _manager.GetAll();
            return Ok(carList);
        }

        // GET api/<CarController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _manager.GetById(id);
        }

        // GET api/<CarController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("Price/{price}")]
        public IEnumerable<Car> Get(double price)
        {
            return _manager.GetByPrice(price);
        }

        // POST api/<CarController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        public Car Post([FromBody] Car newCar)
        {
            return _manager.AddCar(newCar);
        }

        // DELETE api/<CarController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public Car Delete(int id)
        {
            return _manager.RemoveCar(id);
        }
    }
}

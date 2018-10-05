using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Manafort.Models;
using Manafort.DataAccess;

namespace Manafort.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncarceratedController : ControllerBase
    {

        // field
        private readonly InmateStorage storage;


        public IncarceratedController()
        {
            storage = new InmateStorage();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Incarcerated>> GetAll()
        {          
            var allPrisoners = storage.GetAll();
            return Ok(allPrisoners);
        }

        [HttpPost]
        public IActionResult AddaPrisoner(Incarcerated incarcerated)
        {
            storage.Add(incarcerated);
            return Ok();
        }
    }
}


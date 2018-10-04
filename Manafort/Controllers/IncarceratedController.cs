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
<<<<<<< HEAD
        private readonly InmateStorage _storage;
=======
        // field
        private readonly InmateStorage storage;
>>>>>>> 9e20048cbfe481901fa20fcb74b7f62a556cb205

        public IncarceratedController()
        {
            storage = new InmateStorage();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Incarcerated>> GetAll()
        {
<<<<<<< HEAD
            return _storage;
=======
            
            var allPrisoners = storage.GetAll();
            return Ok(allPrisoners);
            
>>>>>>> 9e20048cbfe481901fa20fcb74b7f62a556cb205
        }

        [HttpPost]
        public IActionResult AddaPrisoner(Incarcerated incarcerated)
        {
            storage.Add(incarcerated);
            return Ok();
        }
    }
}


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
        private readonly InmateStorage _storage;

        public IncarceratedController()
        {
            _storage = new InmateStorage();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Incarcerated>> GetAll()
        {
            return _storage;
        }

        [HttpPost]
        public IActionResult AddAPrisoner (Incarcerated incarcerated)
        {
            _storage.Add(incarcerated);
            return Ok();
        }
    }
}
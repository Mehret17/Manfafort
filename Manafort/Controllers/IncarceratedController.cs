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

        [HttpGet("{interests}")]
        public ActionResult<IEnumerable<Incarcerated>> GetInterests(string interests)
        {
            var allPrisoners = storage.GetAll();
            var findInterests = allPrisoners.Where(inmate => inmate.Interests.ToLower() == interests.ToLower());
            return Ok(findInterests);
        }

        [HttpGet("{prisonerNo}/services")]
        public ActionResult<IEnumerable<Incarcerated>> GetServices(int prisonerNo, Services services)
        {
            var prisonerId = storage.GetById(prisonerNo);
            var prisonerService = prisonerId.services;
            return Ok(prisonerService);

        }

        [HttpPost]
        public IActionResult AddaPrisoner(Incarcerated incarcerated)
        {
            storage.Add(incarcerated);
            return Ok();
        }
    }
}

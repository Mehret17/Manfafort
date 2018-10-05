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

        [HttpGet("murder")]
        public ActionResult<IEnumerable<Incarcerated>> GetMurders()
        {
            var allPrisoners = storage.GetAll();
            var murderPrisoners = allPrisoners.Where(inmate => inmate.Interests.ToLower() == "murder");
            return Ok(murderPrisoners);
        }

        [HttpGet("fraud")]
        public ActionResult<IEnumerable<Incarcerated>> GetFrauders()
        {
            var allPrisoners = storage.GetAll();
            var fraudPrisoners = allPrisoners.Where(inmate => inmate.Interests.ToLower() == "fraud");
            return Ok(fraudPrisoners);
        }

        [HttpGet("stealing")]
        public ActionResult<IEnumerable<Incarcerated>> GetStealers()
        {
            var allPrisoners = storage.GetAll();
            var stealingPrisoners = allPrisoners.Where(inmate => inmate.Interests.ToLower() == "stealing");
            return Ok(stealingPrisoners);
        }

        [HttpGet("chess")]
        public ActionResult<IEnumerable<Incarcerated>> GetChessers()
        {
            var allPrisoners = storage.GetAll();
            var chessPrisoners = allPrisoners.Where(inmate => inmate.Interests.ToLower() == "chess");
            return Ok(chessPrisoners);
        }

        [HttpPost]
        public IActionResult AddaPrisoner(Incarcerated incarcerated)
        {
            storage.Add(incarcerated);
            return Ok();
        }
    }
}


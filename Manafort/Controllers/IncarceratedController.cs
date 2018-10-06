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
        public ActionResult<IEnumerable<Incarcerated>> GetServices(int prisonerNo)
        {
            var prisonerId = storage.GetById(prisonerNo);
            var prisonerService = prisonerId.Services;
            return Ok(prisonerService);
        }

        [HttpGet("{prisonerNo}/friends")]
        public ActionResult<IEnumerable<Incarcerated>> GetFriends(int prisonerNo)
        {
            var prisonerId = storage.GetById(prisonerNo);
            storage.AddFriends(prisonerId);
            var prisonerFriends = prisonerId.Friends;
            return Ok(prisonerFriends);
        }

        [HttpGet("{prisonerNo}/enemies")]
        public ActionResult<IEnumerable<Incarcerated>> GetEnemies(int prisonerNo)
        {
            var prisonerId = storage.GetById(prisonerNo);
            storage.Enemies(prisonerId);
            var prisonerEnemies = prisonerId.Enemies;
            return Ok(prisonerEnemies);
        }

        [HttpPost]
        //public IActionResult AddFrinends(Incarcerated incarcerated)
        //{
        //    var prisonerId = storage.GetById
        //    return Ok();
        //}

        [HttpPost]
        public IActionResult AddaPrisoner(Incarcerated incarcerated)
        {
            storage.Add(incarcerated);
            return Ok();
        }
    }
}

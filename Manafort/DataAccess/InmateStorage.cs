using Manafort.Controllers;
using Manafort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manafort.DataAccess
{
    public class InmateStorage
    {
        static List<Incarcerated> _cellBlock = new List<Incarcerated>();
       // private List<Incarcerated> allSeedData;

        static InmateStorage()
        {
            List<Incarcerated> SeedPrisoners = new List<Incarcerated>
            {
                new Incarcerated {
                    Name = "Paul Manafort",
                    PrisonerNo = 1,
                    Interests = "Fraud",
                    Gender = Gender.Male,
                    ActuallyGuilty = true,
                    EducationalLevel = EducationalLevel.GradSchool,
                    TypeofCrime = "Fraud",
                    Weapon = "Snakes",
                    services = new List<Services>
                    {
                        new Services() {ServiceNames = "CellPhone", Amount = 10},
                        new Services() {ServiceNames = "BodyGuard", Amount = 12},
                        new Services() {ServiceNames = "Smuggling", Amount = 15},
                        new Services() {ServiceNames = "Riot", Amount = 200},
                        new Services() {ServiceNames = "Hits", Amount = 250},
                        new Services() {ServiceNames = "Haircut", Amount = 10}
                    }
                },
                new Incarcerated {
                    Name = "Michael Flynn",
                    PrisonerNo = 2,
                    Interests = "Fraud",
                    Gender = Gender.Male,
                    ActuallyGuilty = true,
                    EducationalLevel = EducationalLevel.GradSchool,
                    TypeofCrime = "Lying",
                    Weapon = "Mouth",
                    services = new List<Services>
                    {
                        new Services() {ServiceNames = "CellPhone", Amount = 10},
                        new Services() {ServiceNames = "BodyGuard", Amount = 12},
                        new Services() {ServiceNames = "Smuggling", Amount = 15},
                        new Services() {ServiceNames = "Riot", Amount = 200},
                        new Services() {ServiceNames = "Hits", Amount = 250},
                        new Services() {ServiceNames = "Haircut", Amount = 10}
                    }
                },
                new Incarcerated {
                    Name = "George Papadopulous",
                    PrisonerNo = 4,
                    Interests = "Murder",
                    Gender = Gender.Male, ActuallyGuilty = true,
                    EducationalLevel = EducationalLevel.College,
                    TypeofCrime = "Conspiracy",
                    Weapon = "Blow Torch",
                    services = new List<Services>
                    {
                        new Services() {ServiceNames = "CellPhone", Amount = 10},
                        new Services() {ServiceNames = "BodyGuard", Amount = 12},
                        new Services() {ServiceNames = "Smuggling", Amount = 15},
                        new Services() {ServiceNames = "Riot", Amount = 200},
                        new Services() {ServiceNames = "Hits", Amount = 250},
                        new Services() {ServiceNames = "Haircut", Amount = 10}
                    }
                },
                new Incarcerated {
                    Name = "Michael Cohen ",
                    PrisonerNo = 3,
                    Interests = "Murder",
                    Gender = Gender.Male,
                    ActuallyGuilty = true,
                    EducationalLevel = EducationalLevel.GradSchool,
                    TypeofCrime = "Lying",
                    Weapon ="Manuiplation",
                    services = new List<Services>
                    {
                        new Services() {ServiceNames = "CellPhone", Amount = 10},
                        new Services() {ServiceNames = "BodyGuard", Amount = 12},
                        new Services() {ServiceNames = "Smuggling", Amount = 15},
                        new Services() {ServiceNames = "Riot", Amount = 200},
                        new Services() {ServiceNames = "Hits", Amount = 250},
                        new Services() {ServiceNames = "Haircut", Amount = 10}
                    }
                },
                new Incarcerated {
                    Name = "Omarosa Manigault Newman ",
                    PrisonerNo = 5,
                    Interests = "Stealing",
                    Gender = Gender.Female,
                    ActuallyGuilty = false,
                    EducationalLevel = EducationalLevel.GradSchool,
                    TypeofCrime = "Breach of Cotract",
                    Weapon ="Breathe Fire",
                    services = new List<Services>
                    { 
                        new Services() {ServiceNames = "CellPhone", Amount = 10},
                        new Services() {ServiceNames = "BodyGuard", Amount = 12},
                        new Services() {ServiceNames = "Smuggling", Amount = 15},
                        new Services() {ServiceNames = "Riot", Amount = 200},
                        new Services() {ServiceNames = "Hits", Amount = 250},
                        new Services() {ServiceNames = "Haircut", Amount = 10}
                    }
                },
            };

           _cellBlock.AddRange(SeedPrisoners);
        }
        public IEnumerable<Incarcerated> GetAll()
        {
            return _cellBlock;
        }

        internal void Add(Incarcerated incarcerated)
        {
            incarcerated.PrisonerNo = _cellBlock.Any() ? _cellBlock.Max(i => i.PrisonerNo) + 1 : 1;
            _cellBlock.Add(incarcerated);
        }

        public Incarcerated GetById(int PrisonerNo)
        {
            return _cellBlock.First(inmate => inmate.PrisonerNo == PrisonerNo);
        }
    }
}
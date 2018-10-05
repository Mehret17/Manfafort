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
            List<Incarcerated>SeedPrisoners = new List<Incarcerated>
            {
                new Incarcerated {Name = "Paul Manafort", PrisonerNo = 1, Interests = "Fraud", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = PreferredVice.Cigarettes, TypeofCrime = "Fraud", Weapon = "Snakes" },
                new Incarcerated {Name = "Michael Flynn", PrisonerNo = 2, Interests = "Fraud", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = PreferredVice.Alcohol, TypeofCrime = "Lying", Weapon = "Mouth"},
                new Incarcerated {Name = "George Papadopulous", PrisonerNo = 4, Interests = "Murder", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.College, PrefferedVice = PreferredVice.Alcohol, TypeofCrime = "Conspiracy", Weapon = "Blow Torch"},
                new Incarcerated {Name = "Michael Cohen", PrisonerNo = 3,  Interests = "Murder", Gender = Gender.Male, ActuallyGuilty = true, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = PreferredVice.Cigarettes, TypeofCrime = "Lying", Weapon ="Manuiplation"},
                new Incarcerated {Name = "Omarosa Manigault Newman", PrisonerNo = 5, Interests = "Stealing", Gender = Gender.Female, ActuallyGuilty = false, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = PreferredVice.Hookers, TypeofCrime = "Breach of Cotract", Weapon ="Breathe Fire"},
                new Incarcerated {Name = "Frank Abagnale Jr.", PrisonerNo = 6, Interests = "Chess", Gender = Gender.Male, ActuallyGuilty = false, EducationalLevel = EducationalLevel.GradSchool, PrefferedVice = PreferredVice.Cigarettes, TypeofCrime = "Bank Fraud", Weapon ="Wit"},
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
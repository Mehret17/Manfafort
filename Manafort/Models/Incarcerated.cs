using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manafort.Models
{
    public class Incarcerated
    {
        public string Name { get; set; }
        public int PrisonerNo { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Race { get; set; }
        public int Weight { get; set; }
        public string State { get; set; }
        public EducationalLevel EducationalLevel { get; set; }
        public string FavoriteAnimal { get; set; }
        public string FavoriteFood { get; set; }
        public string PrefferedVice { get; set; }
        public string FavoriteMovie { get; set; }
        public string Weapon { get; set; }
        public DateTime DateofOffense { get; set; }
        public string TypeofCrime { get; set; }
        public bool CapitalPunishement { get; set; }
        public bool ActuallyGuilty { get; set; }
        public string Interests { get; set; }

    }
}

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
        public EducationalLevel EducationalLevel { get; set; }
        public PreferredVice PrefferedVice { get; set; }
        public string Weapon { get; set; }
        public string TypeofCrime { get; set; }
        public bool ActuallyGuilty { get; set; }
        public string Interests { get; set; }
    }
}

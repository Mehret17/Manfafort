using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manafort.Models
{
    public class Services
    {
        public ServiceNames ServiceNames { get; set; }
        public int Amount { get; set; }
        public PaymentType PaymentType { get; set; }
    }

    public enum ServiceNames
    {
        CellPhones,
        BodyGuard,
        Smuggling,
        Riot,
        Hits
    }

    public enum PaymentType
    {
        Liquor,
        Cigarettes,
        Favors,
        Ramen,
        Steak,
        MemoryFoamMattress
    }
}

using System.Collections.Generic;
using ContestOfChampions.Models.EntityModels;

namespace ContestOfChampions.Models.ViewModels.Alliance
{
    public class AllianceViewModel
    {
        public string Name { get; set; }
            
        public Treasury Treasury { get; set; }

        public virtual ICollection<EntityModels.Summoner> Members { get; set; }
    }
}
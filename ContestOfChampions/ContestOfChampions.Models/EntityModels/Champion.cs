using System.Collections.Generic;
using ContestOfChampions.Models.Enums;

namespace ContestOfChampions.Models.EntityModels
{
    public class Champion
    {
        public Champion()
        {
            this.Owners = new HashSet<Summoner>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int StarLevel { get; set; }

        public Class Class { get; set; }

        public string SkinUrl { get; set; }

        public virtual Stats Stats { get; set; }

        public ICollection<Summoner> Owners { get; set; }
    }
}
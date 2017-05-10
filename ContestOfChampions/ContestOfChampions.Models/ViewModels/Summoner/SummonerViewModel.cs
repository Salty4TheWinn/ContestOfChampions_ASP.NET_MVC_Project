using System.Collections.Generic;
using ContestOfChampions.Models.EntityModels;

namespace ContestOfChampions.Models.ViewModels.Summoner
{
    public class SummonerViewModel
    {
        public string Username { get; set; }

        public string Title { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual EntityModels.Alliance Alliance { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}
using System.Collections.Generic;

namespace ContestOfChampions.Models.EntityModels
{
    public class Summoner
    {
        public Summoner()
        {
            this.Champions = new HashSet<Champion>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Title { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Alliance Alliance { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}
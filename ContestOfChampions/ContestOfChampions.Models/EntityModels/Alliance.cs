using System.Collections.Generic;

namespace ContestOfChampions.Models.EntityModels
{
    public class Alliance
    {
        public Alliance()
        {
            this.Members = new HashSet<Summoner>();
        }

        public int Id { get; set; }

        public string Name { get; set; }    

        public Treasury Treasury { get; set; }

        public virtual ICollection<Summoner> Members { get; set; }
    }
}
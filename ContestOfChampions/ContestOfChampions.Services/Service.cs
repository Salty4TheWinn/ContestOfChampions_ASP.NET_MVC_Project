using ContestOfChampions.Data;

namespace ContestOfChampions.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = new ContestOfChampionsContext();
        }

        protected ContestOfChampionsContext Context { get; }
    }
}
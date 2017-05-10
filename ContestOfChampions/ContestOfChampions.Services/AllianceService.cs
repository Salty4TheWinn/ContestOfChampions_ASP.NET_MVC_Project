using System.Collections.Generic;
using System.Linq;
using ContestOfChampions.Models.EntityModels;
using ContestOfChampions.Models.ViewModels.Alliance;

namespace ContestOfChampions.Services
{
    public class AllianceService : Service
    {
        public List<AllianceViewModel> GetAllAlliances()
        {
            List<Alliance> alliances = this.Context.Alliances.ToList();

            List<AllianceViewModel> allianceVm = new List<AllianceViewModel>();

            foreach (var alliance in alliances)
            {
                allianceVm.Add(new AllianceViewModel()
                {
                    Name = alliance.Name,
                    Treasury = alliance.Treasury,
                    Members = alliance.Members
                });
            }

            return allianceVm;
        }
    }
}
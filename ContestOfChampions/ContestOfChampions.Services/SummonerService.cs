using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ContestOfChampions.Models.EntityModels;
using ContestOfChampions.Models.ViewModels.Summoner;

namespace ContestOfChampions.Services
{
    public class SummonerService : Service
    {
        public List<SummonerViewModel> GetAllSummoners()
        {
            var summoners = this.Context.Summoners.OrderBy(x => x.Username).ToList();

            List<SummonerViewModel> vmList = new List<SummonerViewModel>();

            foreach (var summoner in summoners)
            {
                vmList.Add(new SummonerViewModel()
                {
                    Alliance = summoner.Alliance,
                    Champions = summoner.Champions,
                    Resources = summoner.Resources,
                    Title = summoner.Title,
                    Username = summoner.Username
                });
            }
            //var summVm = Mapper.Map<List<Summoner>, List<SummonerViewModel>>(summoners);

            return vmList;
        }

        public SummonerViewModel getDesiredSummoner(string username)
        {
            var summoner = this.Context.Summoners.FirstOrDefault(s => s.Username == username);
            SummonerViewModel summonerVm = Mapper.Map<Summoner, SummonerViewModel>(summoner);
            return summonerVm;
        }
    }
}
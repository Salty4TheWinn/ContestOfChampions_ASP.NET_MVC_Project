using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using ContestOfChampions.Models.EntityModels;
using ContestOfChampions.Models.ViewModels.Summoner;

namespace ContestOfChampions.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfiureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        private void ConfiureMappings()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Summoner, SummonerViewModel>();
                //    .ForMember(x=> x.Alliance,y=>y.MapFrom(z=>z.Alliance))
                //    .ForMember(x=> x.Resources,y=>y.MapFrom(z=>z.Resources))
                //    .ForMember(x=> x.Champions,y=>y.MapFrom(z=>z.Champions));
                expression.CreateMap<List<Summoner>, List<SummonerViewModel>>();
                //.ForMember(z => z.Select(x=>x.Champions),m=>m.MapFrom(x=>x.Select(y=>y.Champions)));
            });
        }
    }
}

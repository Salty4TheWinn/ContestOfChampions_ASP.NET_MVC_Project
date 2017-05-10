using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ContestOfChampions.Services;
using ContestOfChampions.Web.Attributes;

namespace ContestOfChampions.Web.Controllers
{
    [RoutePrefix("summoner")]
    public class SummonerController : Controller
    {
        private SummonerService service;

        public SummonerController()
        {
            this.service = new SummonerService();
        }

        [Route("index")]
        [WorthyEnough(Roles = "User")]
        public ActionResult Index()
        {
            var summoners = service.GetAllSummoners();

            return View(summoners);
        }

        [Route("getsummoner/{id}")]
        [WorthyEnough(Roles = "User")]
        public ActionResult GetSummonerProfile(string id)
        {
            var summoner = service.getDesiredSummoner(id);
            return View(summoner);
        }
    }
}
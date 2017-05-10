using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContestOfChampions.Services;

namespace ContestOfChampions.Web.Areas.Alliance.Controllers
{
    [RouteArea("Alliance")]
    public class AllianceController : Controller
    {
        private AllianceService service;

        public AllianceController()
        {
            this.service = new AllianceService();
        }

        [Route("alliance/index")]
        public ActionResult Index()
        {
            var alliances = this.service.GetAllAlliances();

            return View(alliances);
        }
    }
}
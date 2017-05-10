using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContestOfChampions.Models.BindingModels;
using ContestOfChampions.Web.Attributes;

namespace ContestOfChampions.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return this.View();
        }

        [Route("{id}")]
        public ActionResult Index(string id)
        {
            TestBm choice = new TestBm()
            {
                Choice = id
            };

            return this.View(choice);
        }



        ////[WorthyEnough(Roles = "Admin")]
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
        

        //[ChildActionOnly]
        //public ActionResult Gallery()
        //{
        //    return this.PartialView("_GenerateGallery");
        //}

    }
}
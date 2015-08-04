using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using PaintSurvey.DAL;
using PaintSurvey.Models;

namespace PaintSurvey.Controllers
{
    public class HomeController : Controller
    {
        private PaintSurveyContext db = new PaintSurveyContext();
        public ActionResult Index()
        {
            //Test add project
            db.Projects.Add(new Project { title = "NEW2", username = "SOME USER2", dateCreated = DateTime.Now });
            db.SaveChanges();

            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(db.Paints.ToList());
            ViewBag.Message = db.Paints.ToList().Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaintSurvey.DAL;
using PaintSurvey.Models;

namespace PaintSurvey.Controllers
{
    public class AdminController : Controller
    {
        private PaintSurveyContext db = new PaintSurveyContext();
        
        //
        // GET: /Admin/
                
        public ActionResult Index()
        {
            DataInitializer.initData();
            return View();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SkillController : Controller
    {
        
        Context db = new Context();

        public ActionResult Index()
        {
            List<Skill> skills = db.Skills.ToList();
            List<Language> languages = db.Languages.ToList();

            var model = new Tuple<List<Skill>, List<Language>>(skills, languages);
            return View(model);
        }
    }
}
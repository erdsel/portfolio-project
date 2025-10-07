using Microsoft.Ajax.Utilities;
using portfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        blogdbEntities context = new blogdbEntities();
        public ActionResult ExperienceList()
        {
            var values = context.Experience.ToList();
            return View(values);
            
        }
        [HttpGet]

        public ActionResult CreateExperience()
        {
           

            return View();
        }

        [HttpPost]

        public ActionResult CreateExperience(Experience experience)
        {
            context.Experience.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        
        public ActionResult DeleteExperience(int id)
        {
            var value = context.Experience.Find(id);
            context.Experience.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpPost]

        public ActionResult UpdateExperience(int id) { 
            var value=context.Experience.Find(id);
            return View(value);

        }

        [HttpPost]

        public ActionResult UpdateExperience(Experience experience)
        {
            var value = context.Experience.Find(experience);
            value.Title = experience.Title;
            value.Subtitle = experience.Subtitle;
            value.Description = experience.Description;
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
    }
}
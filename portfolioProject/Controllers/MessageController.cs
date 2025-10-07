using portfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolioProject.Controllers
{
    public class MessageController : Controller
    {
        blogdbEntities context = new blogdbEntities();
        public ActionResult Inbox()
        {
            var values = context.Contact.ToList();
            return View(values);
        }
        public ActionResult ChangeMessageStatus(int id)
        {
            var value = context.Contact.Find(id);
            if (value.isRead == true)
            {
                value.isRead = false;
            }
            else
            {
                value.isRead = true;
            }
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

    }
}
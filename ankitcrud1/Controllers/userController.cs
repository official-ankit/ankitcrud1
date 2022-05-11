using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ankitcrud1.Models;

namespace ankitcrud1.Controllers
{
    public class userController : Controller
    {
        // GET: user

        public ActionResult Create() {
            return View(); 
        
        }
        [HttpPost]
        public ActionResult Create(string i)
        {
            string Name=Request.Form["name"];
            string Adress=Request.Form["Adress"];
            string Contact=Request.Form["Contact"];
            Employee ob=new Employee();
            ob.Name = Name;
            ob.Adress = Adress;
            ob.Contact = Contact;
            db.Acer.Add(ob);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        DataConnection db=new DataConnection();
        public ActionResult Index()
        {
            var data=db.Acer.ToList();
            return View(data);



        }
    }
}
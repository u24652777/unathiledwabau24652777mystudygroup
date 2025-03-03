using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unathiledwabau24652777mystudygroup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult ListStudents()
        {
            List<Models.myClass> people = new List<Models.myClass>();

            people.Add(new Models.myClass { StudentNumber = "u24652777", Name = "Unathi", Surname = "Ledwaba" ,Email ="u24652777@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24829839", Name = "Ntsika", Surname = "Mazamisa" , Email= "u24829839@tuks.co.za"});
            people.Add(new Models.myClass { StudentNumber = "u24687406", Name = "Nandipha", Surname = "Makama", Email = "u24687406@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24735427", Name = "Lesedi", Surname = "Magondo", Email = "u24735427@tuks.co.za" });
            people.Add(new Models.myClass { StudentNumber = "u24974553", Name = "Aviwe", Surname = "Mahlukane", Email = "u24974553@tuks.co.za" });
            return View(people);
        }
    }
}
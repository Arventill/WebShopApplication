using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private CakesContext db = new CakesContext();
        public ActionResult Index()
        {
            // za każdym razem jak odpalisz stronę to będzie robiło insert :)

            /*Category category = new Category
            {
                CategoryName = "Urodzinowe",
                IconFileName = "sth.png",
                CategoryDescription = "It's tasty and easy!"
            };
            db.Categories.Add(category);
            db.SaveChanges();

            using (CakesContext db2 = new CakesContext())
            {
                Category kat = db2.Categories.Where
                    (k => k.CategoryName == "Urodzinowe").FirstOrDefault();
                if (kat != null && !String.IsNullOrWhiteSpace(kat.CategoryName))
                {

                }
                else
                {
                    Category category = new Category
                    {
                        CategoryName = "Urodzinowe",
                        IconFileName = "sth.png",
                        CategoryDescription = "It's tasty and easy!"
                    };
                    db2.Categories.Add(category);
                    db2.SaveChanges();
                }
            }
            var catList = db.Categories.ToList();*/

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
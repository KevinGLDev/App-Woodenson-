using Microsoft.AspNetCore.Mvc;
using Woodenson.Models;

namespace Woodenson.Controllers
{
    public class WoodensonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel contacto)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DataBaseContext())
                {


                    db.Add(contacto);
                    db.SaveChanges();

                }
                return Redirect("/Woodenson");
            }

            return View();
                
        }

        public ActionResult Us()
        {
            return View();
        }

        
    }
}

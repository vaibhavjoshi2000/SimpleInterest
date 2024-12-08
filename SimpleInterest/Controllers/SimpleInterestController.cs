using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInterest.Models;
namespace SimpleInterest.Controllers
{
    public class SimpleInterestController : Controller
    {
        // GET: SimpleInterest
        public ActionResult DisplaySimpleInterest()
        {
           SimpleInterestModel obj = new SimpleInterestModel();
           return View(obj);
          
        }

        [HttpPost]
        public ActionResult CalculateSimpleInterest(SimpleInterestModel model)
        {
            // Validate the model
            if (!ModelState.IsValid)//It is used to validate Data & handle the errors which is inside Models class.
            {
                // Return the same view with validation errors
                return View("DisplaySimpleInterest", model);
            }

            //Calculate Simple Interst
            model.SimpleInterest = (model.Principal * model.Amount * model.Year) / 100;
            return View("DisplaySimpleInterest", model);//"DisplaySimpleInterest": This explicitly tells ASP.NET MVC which Razor view to render, irrespective of the action method name & in this case it will render DisplaySimpleInterest view.
        }
    }
}
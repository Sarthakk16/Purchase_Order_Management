using Microsoft.AspNetCore.Mvc;

namespace POM_trial.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(Order order) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("OrderConfirmation");

            }
            return View(order);  
        
        }

        public ActionResult OrderConfirmation() 
        {
            return View();  
        }
    }
}

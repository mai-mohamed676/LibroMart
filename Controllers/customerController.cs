using coursewepapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace coursewepapi.Controllers
{
    public class customerController : Controller
    {
        itiEntity context = new itiEntity();
        customersampledata sampledata = new customersampledata();
        //all customers
        public IActionResult Index()
        {
            List<customer> customerlistModel = sampledata.getall();
            return View("customerlist",customerlistModel);
        }
        //customer/details/1
        public IActionResult Details(int id)
        {
            //model
            customersampledata sampledata = new customersampledata();
            customer customermodel = sampledata.getbyid(id);
            //send view
            return View("customerdetails", customermodel);
        }
        [HttpGet]
        public IActionResult NEW()
        {
            return View(new customer());
        }

        //submit button
        //customer/savenew (post)
        [HttpPost]
        public IActionResult SAVENEW(customer CUST)
        {
            if(CUST.Name != null)
            {
                context.customers.Add(CUST);
                context.SaveChanges();
                //index
                

                return RedirectToAction("index");
            }
            else
            {
                return View("NEW",CUST);
            }
           
        }
       
    }
}

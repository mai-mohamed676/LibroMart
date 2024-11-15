using coursewepapi.Models;
using Microsoft.AspNetCore.Mvc;
using coursewepapi.ViewModel;
namespace coursewepapi.Controllers
{
    public class passdataController : Controller
    {
        itiEntity context = new itiEntity();
        //passdata/testviewdata/1
        public IActionResult testviewdata()
        {
            customer custmodel = context.customers.FirstOrDefault();
       
            string msg = "hello";
            List<string>branches=new List<string>();
            branches.Add("alex");
            branches.Add("bani");
            branches.Add("egypt");
            ViewData["brch"] = branches;
            int temp = 41;
            ViewData["message"] = msg;
            ViewData["Temp"] = temp;
            // return View(custmodel);
            return View(custmodel);
        }
        public IActionResult testviewmodel()
        {
            customer custmodel = context.customers.FirstOrDefault();

            string msg = "hello";
            List<string> branches = new List<string>();
            branches.Add("alex");
            branches.Add("bani");
            branches.Add("egypt");
            int temp = 41;
            //declare viewmodel
            customerwithmessageandbranchlistviewmodel custviewmodel = new customerwithmessageandbranchlistviewmodel();
            custviewmodel.message = msg;
            custviewmodel.branches = branches;
            custviewmodel.temp = temp;
            custviewmodel.custname = custmodel.Name;
            return View(custviewmodel);
        }
    }
}
/*<h2>@Model.Name</h2>
<h3>message:@ViewData["message"]</h3>
<select class="form-control">
    @foreach(var item in(List<string>)ViewData["brch"] ){
        <option>@item</option>
        }
</select>
@((int)ViewData["Temp"]+10)*/
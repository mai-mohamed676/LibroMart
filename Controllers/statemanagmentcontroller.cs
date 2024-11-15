using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coursewepapi.Controllers
{
    public class statemanagmentcontroller : Controller
    {
        public IActionResult setTempData()
        {
            TempData["msg"] = "msg set hello";
            return Content("datasaved");
        }
        public IActionResult get1()
        {
            //read from temp
            string message = TempData["msg"].ToString();
                 return Content("get1"+message);
        }
        public IActionResult setsession()
        {
            HttpContext.Session.SetString("name", "mai");
            HttpContext.Session.SetInt32("age", 12);
            return Content("session data saved");
        }
        public IActionResult getsession()
        {
          string name=  HttpContext.Session.GetString("name");
            int age = (int)HttpContext.Session.GetInt32("age");
            return Content($"name={name} age={age}");

        }
        public IActionResult Setcookie()
        {
            Response.Cookies.Append("name", "mai");
            Response.Cookies.Append("age", "12");
            return Content("cookie data saved");
        }
        
        public IActionResult Getcookie()
        {
            string name = Request.Cookies["name"];
            int age = int.Parse(Request.Cookies["age"]);
            return Content($"{name}{age}");
        }






    }

}

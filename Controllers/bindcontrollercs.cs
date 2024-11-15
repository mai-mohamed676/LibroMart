using Microsoft.AspNetCore.Mvc;

namespace coursewepapi.Controllers
{
    public class bindcontrollercs : Controller
    {
        //bind/testprimitivetype?id=1&name=mai
        public IActionResult testprimitivetype(int id,string name)
        {
            return Content($"name={name},id={id}");
        }
        //bind/TESTDICTIONARY?name=SD&phones[MOHAMED]=123&phones[KHALED]=456
        public IActionResult TESTDICTIONARY(Dictionary<string,int> phones,string name)
        {
            return Content($"name={name}");
        }

    }
}

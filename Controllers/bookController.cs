using coursewepapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace coursewepapi.Controllers
{
    public class bookController : Controller
    {
        booksampledata sampledata = new booksampledata();
        //all books
        public IActionResult index()
        {
          List<book>booklistModel=  sampledata.getall();
            return View("booklist",booklistModel);
        }
        //book/Showmsg
        public string Showmsg()
        {
            return "your request is made";
        }
        public ContentResult showmsg2()
        {
            ContentResult result = new ContentResult();
            result.Content = "thanks";
            return result;
        }
        //book/show view
        public ViewResult showview()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "v1";
            return result;
        }
        //book/details/1
        public IActionResult Details(int id)
        {
        //model
        booksampledata sampledata=new booksampledata();
           book bookmodel = sampledata.getbyid(id);
            //send view
            return View("bookdetails",bookmodel);
        }

    }
}

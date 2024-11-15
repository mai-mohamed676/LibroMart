namespace coursewepapi.Models
{
    public class booksampledata
    {
        List<book> books;
        public booksampledata()
        {
            books = new List<book>();
            books.Add(new book() { Id = 1,Name="rulesoflove",image= "1.jpg", Price=500,Description="book is very good with relations" }) ;
            books.Add(new book() { Id = 2, Name = "rulesofthink", image = "2.jpg", Price = 400, Description = "book is very good with relations" });
            books.Add(new book() { Id = 3, Name = "rules", image = "3.jpg", Price = 100, Description = "book is very good to you" });
        }
      public  List<book> getall()
        {
            return books;
        }
        public book getbyid(int id)
        {
            return books.FirstOrDefault(b => b.Id== id);
        }
    }
}

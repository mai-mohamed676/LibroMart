namespace coursewepapi.Models
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int book_id { get; set; }
        public int salary { get; set; }
        public virtual List<book>? books { get; set; }
    }
}

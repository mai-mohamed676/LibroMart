using System.ComponentModel.DataAnnotations.Schema;

namespace coursewepapi.Models
{
    public class book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        [ForeignKey("customer")]
        public int cust_id { get; set; }
        public virtual customer? Customer { get; set; }
    }
}

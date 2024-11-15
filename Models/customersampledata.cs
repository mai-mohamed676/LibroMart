namespace coursewepapi.Models
{
    public class customersampledata
    {
        List<customer> customers;
        public customersampledata()
        {
           customers = new List<customer>();
           customers.Add(new customer() { Id = 1, Name = "rulesoflove", salary = 100,  });
            customers.Add(new customer() { Id = 2, Name = "rulesofthink", salary = 100,  });
         customers.Add(new customer() { Id = 3, Name = "rules",  salary = 100,  });
        }
        public List<customer> getall()
        {
            return customers;
        }
        public customer getbyid(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}

namespace FullStackAPI.Models
{
    public class Cars
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        
        public string Model { get; set; }

        public int  Year { get; set; }

        public decimal price { get; set; }  

        public bool New { get; set; } 


    }
}

namespace OnlineStore
{
    public class Product
    {
        static int counter = 1;
        public int Id { get; }
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Id = counter++;
        }

        public override string ToString()
        {
            return $"{Name} {Price}";
        }


    }
}

  
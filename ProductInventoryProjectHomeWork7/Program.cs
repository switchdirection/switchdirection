namespace ProductInventoryProjectHomeWork7
{
    internal abstract class Product
    {
        private double _price;
        private int _id;
        private uint _amount;

        public double Price{ get { return _price; } set { _price = value; } }             
        public int Id { get { return _id; } private set { _id = value; } }             
        public uint Amount{ get { return _amount; } set { _amount = value; } }       
        
        public Product()
        {
            Price = 100;
            Id = new Random().Next();
            Amount = 10;
        }

        public Product(double price) 
        {
            Price = price;
            Id = new Random().Next();
            Amount = 10;
        }

        public Product(double price, int id) 
        {
            Price = price;
            Id = id;
            Amount = 10;
        }

        public Product(double price, int id, uint amount)
        {
            Price = price;
            Id = id;
            Amount = amount;
        }
    }

    internal class Table : Product
    {
        public Table() : base()
        {
            
        }

        public Table(double price) : base(price)
        {

        }

        public Table(double price, int id) : base(price, id)
        {

        }

        public Table(double price, int id, uint amount) : base(price, id, amount)
        {

        }
    }

    internal class Chair : Product
    {
        public Chair() : base()
        {

        }

        public Chair(double price) : base(price)
        {

        }

        public Chair(double price, int id) : base(price, id)
        {

        }

        public Chair(double price, int id, uint amount) : base(price, id, amount)
        {

        }
    }

    internal class Door : Product
    {
        public Door() : base()
        {

        }

        public Door(double price) : base(price)
        {

        }

        public Door(double price, int id) : base(price, id)
        {

        }

        public Door(double price, int id, uint amount) : base(price, id, amount)
        {

        }
    }

    internal class Inventory
    {
        List<Product> _products;

        public List<Product> Products { get { return _products; } set { _products = value; } }

        public Inventory(List<Product> products) 
        {
            Products = products;
        }

        public double getPriceOfAllProducts()
        {
            double price = 0;
            foreach(Product product in Products)
            {
                price += product.Price * product.Amount;
            }
            return price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Table(200)); //2000
            products.Add(new Chair(70, 8591743, 80)); // 5600
            products.Add(new Door(700, 5819475, 160)); // 112000
            Inventory inventory = new Inventory(products);
            double result = inventory.getPriceOfAllProducts();
            Console.WriteLine("Стоимость всех продуктов в инвенторе: " + result + " BYN");
        }
    }
}

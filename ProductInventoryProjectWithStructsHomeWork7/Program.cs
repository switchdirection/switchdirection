namespace ProductInventoryProjectWithStructsHomeWork7
{


    /*
     * По поводу этого варианта, мне просто интересно считается ли этот вариант валидным при таком использовании структур, здесь по сути каждая структура просто создаёт
     * новый экземпляр Product просто от имени другой структуры, по факту тоже самое и с классами, и по факту очень даже не плохо выглядит при таком использовании структур
     * 
        internal struct Product
        {
            private double _price;
            private int _id;
            private uint _amount;

            public double Price { get { return _price; } set { _price = value; } }
            public int Id { get { return _id; } private set { _id = value; } }
            public uint Amount { get { return _amount; } set { _amount = value; } }

            // Конструктор без параметров
            public Product(double price = 100, int id = 0, uint amount = 10)
            {
                _price = price;
                _id = id == 0 ? new Random().Next() : id;
                _amount = amount;
            }
        }

        internal struct Table
        {
            public Product Product { get; }

            public Table(double price = 100, int id = 0, uint amount = 10)
            {
                Product = new Product(price, id, amount);
            }
        }

        internal struct Chair
        {
            public Product Product { get; }

            public Chair(double price = 100, int id = 0, uint amount = 10)
            {
                Product = new Product(price, id, amount);
            }
        }

        internal struct Door
        {
            public Product Product { get; }

            public Door(double price = 100, int id = 0, uint amount = 10)
            {
                Product = new Product(price, id, amount);
            }
        }

        internal struct Inventory
        {
            private List<Product> _products;

            public List<Product> Products { get { return _products; } set { _products = value; } }

            public Inventory(List<Product> products)
            {
                _products = products;
            }

            public double GetPriceOfAllProducts()
            {
                double price = 0;
                foreach (var product in _products)
                {
                    price += product.Price * product.Amount;
                }
                return price;
            }
        }
     */


    struct Table
    {
        private double _price;
        private int _id;
        private uint _amount;

        public double Price { get { return _price; } set { _price = value; } }
        public int Id { get { return _id; } private set { _id = value; } }
        public uint Amount { get { return _amount; } set { _amount = value; } }

        public Table()
        {
            Price = 100;
            Id = new Random().Next();
            Amount = 10;
        }

        public Table(double price)
        {
            Price = price;
            Id = new Random().Next();
            Amount = 10;
        }

        public Table(double price, int id)
        {
            Price = price;
            Id = id;
            Amount = 10;
        }

        public Table(double price, int id, uint amount)
        {
            Price = price;
            Id = id;
            Amount = amount;
        }
    }

    struct Chair
    {
        private double _price;
        private int _id;
        private uint _amount;

        public double Price { get { return _price; } set { _price = value; } }
        public int Id { get { return _id; } private set { _id = value; } }
        public uint Amount { get { return _amount; } set { _amount = value; } }

        public Chair()
        {
            Price = 100;
            Id = new Random().Next();
            Amount = 10;
        }

        public Chair(double price)
        {
            Price = price;
            Id = new Random().Next();
            Amount = 10;
        }

        public Chair(double price, int id)
        {
            Price = price;
            Id = id;
            Amount = 10;
        }

        public Chair(double price, int id, uint amount)
        {
            Price = price;
            Id = id;
            Amount = amount;
        }
    }

    struct  Door
    {
        private double _price;
        private int _id;
        private uint _amount;

        public double Price { get { return _price; } set { _price = value; } }
        public int Id { get { return _id; } private set { _id = value; } }
        public uint Amount { get { return _amount; } set { _amount = value; } }

        public Door()
        {
            Price = 100;
            Id = new Random().Next();
            Amount = 10;
        }

        public Door(double price)
        {
            Price = price;
            Id = new Random().Next();
            Amount = 10;
        }

        public Door(double price, int id)
        {
            Price = price;
            Id = id;
            Amount = 10;
        }

        public Door(double price, int id, uint amount)
        {
            Price = price;
            Id = id;
            Amount = amount;
        }
    }

    struct Inventory
    {
        private List<Table> _tables = new List<Table>();
        private List<Chair> _chairs = new List<Chair>();
        private List<Door> _doors = new List<Door>();
        public List<Table> Tables { get { return _tables; } set { _tables = value; }  }
        public List<Chair> Chairs { get { return _chairs; } set { _chairs = value; }  }
        public List<Door> Doors { get { return _doors; } set { _doors = value; }  }

        public Inventory(List<Table> tables, List<Chair> chairs, List<Door> doors)
        {
            Tables = tables;
            Chairs = chairs;
            Doors = doors;
        }

        public double getPriceOfAllProducts()
        {
            double price = 0;
            foreach (Table table in Tables)
            {
                price += table.Price * table.Amount;
            }
            foreach (Chair chair in Chairs)
            {
                price += chair.Price * chair.Amount;
            }
            foreach (Door door in Doors)
            {
                price += door.Price * door.Amount;
            }
            return price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>();
            List<Chair> chairs = new List<Chair>();
            List<Door> doors = new List<Door>();
            tables.Add(new Table());
            tables.Add(new Table());
            tables.Add(new Table());
            chairs.Add(new Chair());
            chairs.Add(new Chair());
            chairs.Add(new Chair());
            doors.Add(new Door());
            doors.Add(new Door());
            Inventory inventory = new Inventory(tables, chairs, doors);
            double result = inventory.getPriceOfAllProducts();
            Console.WriteLine("Стоимость всех продуктов в инвенторе: " + result + " BYN");
        }
    }
}

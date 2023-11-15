
namespace Product
{
    abstract class Hierarchy
    {
        public string Id = "";
        public string Name = "";
        public decimal Price;
        public int QuantityInStock;
        public void UpdateQuantityInStock(int quantity)
        {
            QuantityInStock = quantity;
        }
    }

    class Book : Hierarchy
    {
        public string Author = "";
        public string Genre = "";

        public Book(string id, string name, decimal price, int quantity, string author, string genre)
        {
            Id = id;
            Name = name;
            Price = price;
            QuantityInStock = quantity;
            Author = author;
            Genre = genre;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + Id + " - " + Name);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity in Stock: " + QuantityInStock);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre + "\n");
        }
    }

    class Electronic : Hierarchy
    {
        public string Manufacturer = "";
        public int WarrantyPeriod;

        public Electronic(string id, string name, decimal price, int quantity, string manufacturer, int Wperiod)
        {
            Id = id;
            Name = name;
            Price = price;
            QuantityInStock = quantity;
            Manufacturer = manufacturer;
            WarrantyPeriod = Wperiod;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + Id + " - " + Name);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity in Stock: " + QuantityInStock);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Warranty Period: " + WarrantyPeriod + "\n");
        }
    }

    class Clothing : Hierarchy
    {
        public string Size = "";
        public string Color = "";

        public Clothing(string id, string name, decimal price, int quantity, string size, string color)
        {
            Id = id;
            Name = name;
            Price = price;
            QuantityInStock = quantity;
            Size = size;
            Color = color;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product: " + Id + " - " + Name);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity in Stock: " + QuantityInStock);
            Console.WriteLine("Size: " + Size);
            Console.WriteLine("Color: " + Color + "\n");
        }
    }
}
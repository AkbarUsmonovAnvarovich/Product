using Product;


class Program{
    static void Main(){
        // Creating book object
        Book book = new Book("B001", "The Great Gatsby", 12.99m, 10, "F. Scott Fitzgerald", "Classic");

        // Creating electronic object
        Electronic electronic = new Electronic("E001", "Smartphone", 799.99m, 5, "Apple", 12);

        // Creating clothing object
        Clothing clothing = new Clothing("C001", "T-Shirt", 19.99m, 20, "M", "Blue");

        // Displaying product information
        book.DisplayProduct();
        electronic.DisplayProduct();
        clothing.DisplayProduct();

        // Updating quantity of a product
        book.UpdateQuantityInStock(5);
        clothing.UpdateQuantityInStock(10);

        // Displaying updated quantity
        book.DisplayProduct();
        clothing.DisplayProduct();
        
    }
}
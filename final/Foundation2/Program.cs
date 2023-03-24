using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4 Calle la Naranjal, Casa 258", "Trujillo", "Trujillo", "13001", "Venezuela");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Converse","514235",40.52,2);
        Product product2 = new Product("Videogame","123335",40.52,1);
        Product product3 = new Product("Notebook","23655",19.99,3);

        List<Product> products1 = new List<Product>()
        {
            product1,
            product2,
            product3
        };

        Address address2 = new Address("495 Grove Street, Apartment #20", "New York", "NY", "10014", "USA");
        Customer customer2 = new Customer("Monica Geller", address2);

        Product product4 = new Product("Shampoo","543615",13.52,2);
        Product product5 = new Product("Soap","542635",2.52,5);
        Product product6 = new Product("Toilet Paper","142655",18.99,2);

        List<Product> products2 = new List<Product>()
        {
            product4,
            product5,
            product6
        };

        Address address3 = new Address("Churchill-laan 266/III", "AMSTERDAM", "GA", "1078", "Netherlands");
        Customer customer3 = new Customer("Robert Robertson", address3);

        Product product7 = new Product("Penguin Toy","512315",20.52,3);
        Product product8 = new Product("Tooth Brush","332335",5.52,1);
        Product product9 = new Product("Cereal","343355",14.89,2);

        List<Product> products3 = new List<Product>()
        {
            product7,
            product8,
            product9
        };

        Order order1 = new Order(customer1,products1);
        Order order2 = new Order(customer2,products2);
        Order order3 = new Order(customer3,products3);

        List<Order> orders = new List<Order>(){
            order1,
            order2,
            order3
        };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.getShippingLablel());
            Console.WriteLine();
            Console.WriteLine(order.getPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.getPriceString());
            Console.WriteLine();
            Console.WriteLine(new string('*', 100));
        }

    }
}
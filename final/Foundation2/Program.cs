using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("45 Neverland St.", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Jerry Smith", address1);
        Product product1 = new Product("RedBull", "R2342345", 12.99, 2);
        Product product2 = new Product("Hair Gel", "G423556", 5.99, 3);
        Order order1 = new Order(customer1, new Product[] { product1, product2 });

        Address address2 = new Address("15342 Galaxy Dr.", "TissueVille", "NY", "Canada");
        Customer customer2 = new Customer("Morty Smith", address2);
        Product product3 = new Product("Plumbus", "D789883", 7.99, 4);
        Order order2 = new Order(customer2, new Product[] { product3 });

       
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine(order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine(order2.CalculateTotalCost());
    }
}
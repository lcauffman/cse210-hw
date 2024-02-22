class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.IsUsaCustomer() ? 5 : 35;
        return totalCost + shippingCost;
    }
// to string .2 
    public string GetPackingLabel()
    {
        return string.Join("\n", Array.ConvertAll(products, product => product.GetProductInfo()));
    }

    public string GetShippingLabel()
    {
        
        return $"{customer.Name}\n{customer.GetCustomerAddress()}";
    }
}
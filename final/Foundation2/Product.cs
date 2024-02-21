//Initializes a product with an ID, name, price, and quantity. It calculates total cost and returns a formatted string.

class Product
{
    private string name;
    private string productId;
    float  price;
    private int quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetProductInfo()
    {
        return $"{name} (ID: {productId})";
    }
}
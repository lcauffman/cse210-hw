//This initializes a customer, with address and name. It then associates with the flag to see if they are in the USA.
class Customer
{
    private string name;
    private Address address;

    public string Name { get => name; set => name = value; }

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsUsaCustomer()
    {
        return address.IsUsa();
    }

    public string GetCustomerAddress()
    {
        return address.GetAddressString();
    }
}
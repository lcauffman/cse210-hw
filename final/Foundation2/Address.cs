//The function of address is to initialize and address, check to make sure its in the USA, and then format and return it.

using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUsa()
    {
        return _country == "USA";
    }

    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
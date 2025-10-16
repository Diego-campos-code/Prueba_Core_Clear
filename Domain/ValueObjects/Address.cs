namespace Domain.ValueObjects;

public partial record Address
{
    public Address(string country, string Line1, string Line2, string city, string state, string zipCode)
    {
        Country = country;
        Line_1 = Line1;
        Line_2 = Line2;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public string Country { get; init; }
    public string Line_1 { get; init; }
    public string Line_2 { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string ZipCode { get; init; }

    public static Address? Create(string country, string Line1, string Line2, string city, string state, string zipCode)
    {
        if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(Line1) ||
        string.IsNullOrEmpty(Line2) || string.IsNullOrEmpty(city) ||
        string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode))
        {
            return null;
        }
        return new Address(country, Line1, Line2, city, state, zipCode);
    }
}
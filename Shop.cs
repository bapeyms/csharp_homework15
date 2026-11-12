namespace csharp_homework15;

public enum ShopType
{
    Grocery,
    Hardware,
    Clothing,
    Footwear
}

public class Shop : IDisposable
{
    private string _name;
    private string _address;
    private ShopType _shopType;
    private bool _disposed = false;

    public Shop(string name, string address, ShopType shopType)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Address cannot be null or empty");
        if (!Enum.IsDefined(shopType))
            throw new ArgumentException("ShopType must be defined");
        _name = name;
        _address = address;
        _shopType = shopType;
    }
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be null or empty");
            _name = value;
        }
    }
    public string Address
    {
        get => _address;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Address cannot be null or empty");
            _address = value;
        }
    }
    public ShopType ShopType
    {
        get => _shopType;
        set
        {
            if (!Enum.IsDefined(value))
                throw new ArgumentException("ShopType must be defined");
            _shopType = value;
        }
    }

    public void Print()
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(Shop), "Object is disposed!");
        Console.WriteLine($"-- SHOP --");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Type: {_shopType}\n");
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            Console.WriteLine($"[DISPOSED] Shop {Name} disposed!");
            _disposed = true;
        }
    }
    ~Shop() => Console.WriteLine($"[FINALISATION]: Shop \"{Name}\" is deleted!");
}
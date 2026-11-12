namespace csharp_homework15;

public class Play: IDisposable
{
    private string _name;
    private string _author;
    private string _genre;
    private int _year;
    private bool _disposed = false;
    
    public Play(string name, string author, string genre, int year)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be null or empty");
        if (string.IsNullOrWhiteSpace(genre))
            throw new ArgumentException("Genre cannot be null or empty");
        if (year <= 0)
            throw new ArgumentException("Year must be greater than zero");
        
        _name = name;
        _author = author;
        _genre = genre;
        _year = year;
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
    public string Author
    {
        get => _author;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Author cannot be null or empty");
            _author = value;
        }
    }
    public string Genre
    {
        get => _genre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Genre cannot be null or empty");
            _genre = value;
        }
    }

    public int Year
    {
        get => _year;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Year cannot be null or empty");
            _year = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"-- PLAY --");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Year: {Year}\n");
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            Console.WriteLine($"[DISPOSED] Play {Name} disposed!");
            _disposed = true;
        }
    }
    ~Play() => Console.WriteLine($"[FINALISATION]: Play \"{Name}\" is deleted!");
}
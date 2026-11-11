namespace csharp_homework15;

public class Play
{
    private string _name;
    private string _author;
    private string _genre;
    private int _year;
    
    public Play(string name, string author, string genre, int year)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty");
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be null or empty");
        if (string.IsNullOrWhiteSpace(genre))
            throw new ArgumentException("Genre cannot be null or empty");
        if (year <= 0)
            throw new ArgumentException("Year cannot be negative");
        
        _name = name;
        _author = author;
        _genre = genre;
        _year = year;
    }

    public string Name
    {
        get => _name;
        set =>  _name = value;
    }
    public string Author
    {
        get => _author;
        set =>  _author = value;
    }
    public string Genre
    {
        get => _genre;
        set =>  _genre = value;
    }

    public int Year
    {
        get => _year;
        set =>  _year = value;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Year: {Year}\n");
    }
    ~Play() => Console.WriteLine($"[FINALISATION]: Play \"{Name}\" is deleted!");
}
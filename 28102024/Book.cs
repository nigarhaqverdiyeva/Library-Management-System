namespace _28102024;
public class Book : LibraryItem
{
    private BookGenre art;
    private LibraryLocation libraryLocation;

    public BookGenre Genre { get; set; }
    public LibraryLocation Location { get; set; }

    public Book(int id,string title, int publicationYear, BookGenre genre, LibraryLocation location) : base(title, publicationYear)
    {
        
        Genre = genre;
        Location = location;
    }

    public Book(string title, int publicationYear, BookGenre art, LibraryLocation libraryLocation) : base(title, publicationYear)
    {
        this.art = art;
        this.libraryLocation = libraryLocation;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book- {Title}, Year-{PublicationYear},Genre-{Genre},Location Aisle -{Location.Aisle}, Shelf - {Location.Shelf}");
    }
}

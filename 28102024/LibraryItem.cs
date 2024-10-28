namespace _28102024;
public abstract class LibraryItem
{
    public string Title { get;  set; }
    public int PublicationYear { get;  set; }

    public LibraryItem(string title, int publicationYear)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Invalid Value");
        Title = title;
        PublicationYear = publicationYear;
    }
    public abstract void DisplayInfo();
}

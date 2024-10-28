namespace _28102024;
public class Magazine : LibraryItem
{
    public Magazine(string title, int publicationYear) : base(title, publicationYear)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Magazine- {Title}, Year-{PublicationYear}");
    }
}

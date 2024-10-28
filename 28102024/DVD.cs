namespace _28102024;
public class DVD : LibraryItem
{
    public DVD(string title, int publicationYear) : base(title, publicationYear)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"DVD- {Title}, Year-{PublicationYear}");
    }
}

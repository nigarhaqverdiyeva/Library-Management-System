namespace _28102024;
internal class Program
{
  static void Main(string[] args)
    {
        Book book = new("Yeddi gozel", 1995, BookGenre.Art, new LibraryLocation(4,5));
        Book book1 = new("Tarix", 1989, BookGenre.Art, new LibraryLocation(2, 4));
        DVD dvd = new("1001 gece", 1998);
        Magazine magazine = new("Koroglu", 1968);
        book.DisplayInfo();
        book1.DisplayInfo();
        dvd.DisplayInfo();
        magazine.DisplayInfo();
        Console.WriteLine(magazine.CalculateAge());
    }

}


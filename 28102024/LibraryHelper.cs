namespace _28102024;
public static class LibraryHelper
{
    public static int CalculateAge(this LibraryItem item)
    {
        if (item == null) 
            throw new ArgumentNullException("item");
        return DateTime.Now.Year-item.PublicationYear;
    }
    public static string ToTitleCase(this LibraryItem item)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Title.ToLower());
    }
}


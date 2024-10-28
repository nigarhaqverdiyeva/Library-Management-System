namespace _28102024;
public class LibraryCatalog
{
    public Book[] books;

    public Book this[int index]
    { 
        get
        {
            if (!books.Contains(books[index]))
            {
                throw new CustomBookError();
            }
            return books[index];
        }
        set{ books[index] = value; }
    }
}

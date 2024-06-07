using Homework;

public class Library
{
    public Library(string name, List<Book> books, List<Reader> readers, float rating)
    {
        this.Name = name;
        this.Books = books;
        this.Readers = readers;
        this.Rating = rating;
    }

    private string Name { get; set; }
    private List<Book> Books { get; set; }
    public List<Reader> Readers { get; set; }
    private float Rating { get; set; }
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void RegisterReader(string name, List<Book> borrowedBooks)
    {
        var reader = new Reader(name, borrowedBooks);
        Readers.Add(reader);
    }

    public override string ToString()
    {
        string booksList = string.Join("\n", Books);
        string readersList = string.Join("\n", Readers);
        return $"Library name: {Name}\nBooks:\n{booksList}\nReaders:\n{readersList}\nRating:{Rating}";
    }
}
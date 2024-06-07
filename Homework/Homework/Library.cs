public class Library
{
    public Library(string name, List<Book> books, List<Reader> readers)
    {
        Name = name;
        Books = books;
        Readers = readers;
    }

    private string Name { get; set; }
    private List<Book> Books { get; set; }
    public List<Reader> Readers { get; set; }

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
        var booksList = string.Join("\n", Books);
        var readersList = string.Join("\n", Readers);
        return $"Library name: {Name}\nBooks:\n{booksList}\nReaders:\n{readersList}";
    }
}
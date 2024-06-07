namespace Homework;

public class Reader
{
    private string Name { get; set; }
    private List<Book> BorrowedBooks { get; set; }
    
    public Reader(string name, List<Book> borrowedBooks)
    {
        this.Name = name;
        this.BorrowedBooks = borrowedBooks;
    }

    public void BorrowBook(Book book, Library library)
    {
        BorrowedBooks.Add(book);
        library.RemoveBook(book);
    }

    public void ReturnBook(Book book, Library library)
    {
        BorrowedBooks.Remove(book);
        library.AddBook(book);
    }

    public override string ToString()
    {
        var borrowedBooksList = string.Join("\n", BorrowedBooks);
        return $"Reader name: {Name}\nBorrowed books:\n{borrowedBooksList}";
    }
}
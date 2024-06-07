namespace Homework;

public class Program
{
    public static void Main(string[] args)
    {   
        Book book1 = new Book("1984", "George Orwell", 1949, 123456789, 328);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 987654321, 281);
        Book book3 = new Book("Brave New World", "Aldous Huxley", 1932, 1122334455, 311);
        Book book4 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 2233445566, 191);
        Book book5 = new Book("Moby Dick", "Herman Melville", 1851, 3344556677, 635);
        List<Reader> initialReaders = new List<Reader>();
        Random rnd = new Random();
        float rating = rnd.Next(0, 101) < 85 ? rnd.Next(4, 6) : rnd.Next(0, 4);
        Library library = new Library("City Library", [book1, book2, book3, book4, book5], initialReaders, rating);
        Console.WriteLine("Initial library state:");
        Console.WriteLine(library.ToString());
        library.RegisterReader("John Doe", [book1]);
        library.RegisterReader("Jane Doe", [book2, book3]);
        var reader1 = library.Readers[0];
        var reader2 = library.Readers[1];
        Console.WriteLine("\nLibrary state after registering readers:");
        Console.WriteLine(library.ToString());
        Console.WriteLine("\nReader 1's state:");
        Console.WriteLine(reader1.ToString());
        Console.WriteLine("\nReader 2's state:");
        Console.WriteLine(reader2.ToString());
        reader1.BorrowBook(book4, library);
        Console.WriteLine("\nLibrary state after reader 1 borrows another book:");
        Console.WriteLine(library.ToString());
        Console.WriteLine("\nReader 1's state after borrowing another book:");
        Console.WriteLine(reader1.ToString());
        reader2.ReturnBook(book2, library);
        Console.WriteLine("\nLibrary state after reader 2 returns a book:");
        Console.WriteLine(library.ToString());
        Console.WriteLine("\nReader 2's state after returning a book:");
        Console.WriteLine(reader2.ToString());
    }
}
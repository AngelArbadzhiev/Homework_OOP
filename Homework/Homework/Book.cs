public class Book
{
    public Book(string title, string author, int yearPublished, uint isbn)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
        ISBN = isbn;
    }

    private string Title { get; set; }
    private string Author { get; set; }
    private int YearPublished { get; set; }
    private uint ISBN { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year published: {YearPublished}, ISBN: {ISBN}";
    }
}
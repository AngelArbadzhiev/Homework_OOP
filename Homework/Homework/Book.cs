public class Book
{
    public Book(string title, string author, int yearPublished, uint isbn, int pages)
    {
        this.Title = title;
        this.Author = author;
        this.YearPublished = yearPublished;
        this.ISBN = isbn;
        this.Pages = pages;
    }

    private string Title { get; set; }
    private string Author { get; set; }
    private int YearPublished { get; set; }
    private uint ISBN { get; set; }
    private int Pages { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Year published: {YearPublished}, ISBN: {ISBN}, Pages: {Pages}";
    }
}
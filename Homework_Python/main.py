class Book:
    def __init__(self, title, author, year_published, isbn):
        self.title = title
        self.author = author
        self.year_published = year_published
        self.isbn = isbn

    def __str__(self):
        return f"Title: {self.title}, Author: {self.author}, Year published: {self.year_published}, ISBN: {self.isbn}"


class Library:
    def __init__(self, name, books, readers):
        self.name = name
        self.books = books
        self.readers = readers

    def add_book(self, book):
        self.books.append(book)

    def remove_book(self, book):
        self.books.remove(book)

    def register_reader(self, name, borrowed_books):
        reader = Reader(name, borrowed_books)
        self.readers.append(reader)

    def __str__(self):
        books_list = "\n".join(str(book) for book in self.books)
        readers_list = "\n".join(str(reader) for reader in self.readers)
        return f"Library name: {self.name}\nBooks:\n{books_list}\nReaders:\n{readers_list}"


class Reader:
    def __init__(self, name, borrowed_books):
        self.name = name
        self.borrowed_books = borrowed_books

    def borrow_book(self, book, library):
        self.borrowed_books.append(book)
        library.remove_book(book)

    def return_book(self, book, library):
        self.borrowed_books.remove(book)
        library.add_book(book)

    def __str__(self):
        borrowed_books_list = "\n".join(str(book) for book in self.borrowed_books)
        return f"Reader name: {self.name}\nBorrowed books:\n{borrowed_books_list}"


if __name__ == "__main__":
    book1 = Book("1984", "George Orwell", 1949, 123456789)
    book2 = Book("To Kill a Mockingbird", "Harper Lee", 1960, 987654321)
    book3 = Book("Brave New World", "Aldous Huxley", 1932, 1122334455)
    book4 = Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 2233445566)
    book5 = Book("Moby Dick", "Herman Melville", 1851, 3344556677)
    initial_readers = []
    library = Library("City Library", [book1, book2, book3, book4, book5], initial_readers)
    print("Initial library state:")
    print(library)
    library.register_reader("John Doe", [book1])
    library.register_reader("Jane Doe", [book2, book3])
    reader1 = library.readers[0]
    reader2 = library.readers[1]
    print("\nLibrary state after registering readers:")
    print(library)
    print("\nReader 1's state:")
    print(reader1)
    print("\nReader 2's state:")
    print(reader2)
    reader1.borrow_book(book4, library)
    print("\nLibrary state after reader 1 borrows another book:")
    print(library)
    print("\nReader 1's state after borrowing another book:")
    print(reader1)
    reader2.return_book(book2, library)
    print("\nLibrary state after reader 2 returns a book:")
    print(library)
    print("\nReader 2's state after returning a book:")
    print(reader2)



using System;
using Library.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Repositories;
using Library.Data;


namespace Library
{
    class Program
    {
        IAuthorRepository _authorRepository = new AuthorRepository();

        IBookRepository _bookRepository = new BookRepository();
        static void Main(string[] args)
        {
            Program current = new Program();

            //current.AddAuthor();
            //current.EditAuthor();
            //current.GetAuthorById();
            //current.DeleteAuthor();
            //current.GetAllAuthors();

            //current.AddBook();
            //current.EditBook();
            //current.GetBookById();
            //current.DeleteBook();
            current.GetAllBooks();
        }

        private void GetAllAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            foreach (var author in authors)
            {
                Console.WriteLine($"Author FirstName: {author.FirstName}, Author LastName : {author.LastName}");
            }
            Console.ReadLine();
        }

        private void DeleteAuthor()
        {
            Console.WriteLine("Enter id of Author: ");
            var authorId = int.Parse(Console.ReadLine());

            _authorRepository.DeleteAuthor(authorId);
            Console.WriteLine("Author successfully deleted");
        }

        private void GetAuthorById()
        {
            Console.WriteLine("Enter id of Author: ");
            var authorId = int.Parse(Console.ReadLine());

            var result = _authorRepository.GetAuthorById(authorId);

            Console.WriteLine($"FirstName: {result.FirstName}, LastName: {result.LastName}");
        }

        //public void EditAuthor()
        //{
        //    Console.WriteLine("Enter id of Author: ");
        //    var authorId = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter firstname of Author: ");
        //    var authorFName = Console.ReadLine();
        //    Console.WriteLine("Enter lastname of Author: ");
        //    var authorLName = Console.ReadLine();

        //    Author newAuthor = new Author();
        //    newAuthor.ID = authorId;
        //    newAuthor.FirstName = authorFName;
        //    newAuthor.LastName = authorLName;

        //    _authorRepository.EditAuthor(newAuthor);

        //    Console.WriteLine("Author successfully edited");
        //}

        //private void AddAuthor()
        //{
        //    Console.WriteLine("Enter firstname of Author: ");
        //    var authorFName = Console.ReadLine();
        //    Console.WriteLine("Enter lastname of Author: ");
        //    var authorLName = Console.ReadLine();

        //    Author newAuthor = new Author();
        //    newAuthor.FirstName = authorFName;
        //    newAuthor.LastName = authorLName;

        //    _authorRepository.AddAuthor(newAuthor);

        //    Console.WriteLine("Author successfully added");
        //}

        private void GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"Book Title: {book.Title}, Book Genre : {book.Genre}");
            }
            Console.ReadLine();
        }

        private void DeleteBook()
        {
            Console.WriteLine("Enter id of Book: ");
            var bookId = int.Parse(Console.ReadLine());

            _bookRepository.DeleteBook(bookId);
            Console.WriteLine("Book successfully deleted");
        }

        private void GetBookById()
        {
            Console.WriteLine("Enter id of Book: ");
            var bookId = int.Parse(Console.ReadLine());

            var result = _bookRepository.GetBookById(bookId);

            Console.WriteLine($"Title: {result.Title}, Genre: {result.Genre}");
        }

        //private void EditBook()
        //{
        //    Console.WriteLine("Enter id of Book: ");
        //    var bookId = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter title of Book: ");
        //    var bookTitle = Console.ReadLine();
        //    Console.WriteLine("Enter genre of Book: ");
        //    var bookGenre = Console.ReadLine();

        //    Book newBook = new Book();
        //    newBook.ID = bookId;
        //    newBook.Title = bookTitle;
        //    newBook.Genre = bookGenre;

        //    _bookRepository.EditBook(newBook);

        //    Console.WriteLine("Book successfully edited");
        //}

        //private void AddBook()
        //{
        //    Console.WriteLine("Enter title of Book: ");
        //    var bookTitle = Console.ReadLine();
        //    Console.WriteLine("Enter genre of Book: ");
        //    var bookGenre = Console.ReadLine();

        //    Book newBook = new Book();
        //    newBook.Title = bookTitle;
        //    newBook.Genre = bookGenre;

        //    _bookRepository.AddBook(newBook);

        //    Console.WriteLine("Book successfully added");
        //}
    }
}
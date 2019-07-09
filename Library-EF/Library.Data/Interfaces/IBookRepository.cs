using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void AddBook(Book book);
        void EditBook(Book book);
        void DeleteBook(int id);
    }
}
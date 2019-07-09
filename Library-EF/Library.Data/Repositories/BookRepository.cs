using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            using (AdoNetDBEntities context = new AdoNetDBEntities())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            using (AdoNetDBEntities context = new AdoNetDBEntities())
            {
                var book = context.Books.FirstOrDefault(b => b.ID == id);
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public void EditBook(Book book)
        {
            using (AdoNetDBEntities context = new AdoNetDBEntities())
            {
                var matched = context.Books.FirstOrDefault(b => b.ID == book.ID);
                matched.Title = book.Title;
                matched.Genre = book.Genre;
                context.SaveChanges();
            }
        }

        public List<Book> GetAllBooks()
        {
            using (AdoNetDBEntities context = new AdoNetDBEntities())
            {
                return context.Books.ToList();
            }
        }

        public Book GetBookById(int bookId)
        {
            using (AdoNetDBEntities context = new AdoNetDBEntities())
            {
                return context.Books.FirstOrDefault(b => b.ID == bookId);
            }
        }
    }
}
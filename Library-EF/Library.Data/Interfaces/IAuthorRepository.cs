using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int authorId);
        void AddAuthor(Author author);
        void EditAuthor(Author author);
        void DeleteAuthor(int id);
    }
}

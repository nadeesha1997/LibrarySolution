using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public interface IBookService
    {
        public List<Book> GetAll();
        public Book Get(int id);
        public void Add(Book newBook);
        public void Update(int id, Book book);
        public void Delete(int id);
    }
}

using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public class BookService:IBookService
    {
        static List<Book> Database = loadDB();

        public static List<Book> loadDB()
        {
            List<Book> temp = new List<Book>();
            temp.Add(new Book { id = 1, Name = "Book1", Auther = "Auther1" });
            temp.Add(new Book { id = 2, Name = "Book2", Auther = "Auther2" });
            return temp;
        }

        public List<Book> GetAll()
        {
            return Database;
        }

        public Book Get(int id)
        {
            return Database.Find(book => book.id == id);
        }

        public void Add(Book newBook)
        {
            Database.Add(newBook);
        }

        public void Update(int id, Book book)
        {
            Database.Remove(Database.Find(book => book.id == id));
            book.id = id;
            Database.Add(book);
        }

        public void Delete(int id)
        {
            Database.Remove(Database.Find(book => book.id == id));
        }
    }
}

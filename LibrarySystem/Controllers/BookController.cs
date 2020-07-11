using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibrarySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static List<Book> Database = loadDB();

        public static List<Book> loadDB()
        {
            List<Book> temp = new List<Book>();
            temp.Add(new Book { id=1, Name = "Book1", Auther = "Auther1" });
            temp.Add(new Book { id = 2, Name = "Book2", Auther = "Auther2" });
            return temp;
        }
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Database;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return Database.Find(book => book.id == id);

        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book newBook)
        {
            Database.Add(newBook);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            Database.Remove(Database.Find(book => book.id == id));
            book.id = id;
            Database.Add(book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Database.Remove(Database.Find(book => book.id == id));
        }
    }
}

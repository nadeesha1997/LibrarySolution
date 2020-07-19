using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Models;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibrarySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetAll();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookService.Get(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book newBook)
        {
            _bookService.Add(newBook);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            _bookService.Update(id, book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookService.Delete(id);
        }
    }
}

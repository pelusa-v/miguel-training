using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private List<Book> books;

    public BooksController()
    {
        books = new List<Book>()
        {
            new Book() { Title = "titulo 1", Name = "name 1", Author = "author1"},
            new Book() { Title = "titulo 2", Name = "name 2", Author = "author2"},
            new Book() { Title = "titulo 3", Name = "name 3", Author = "author3"},
            new Book() { Title = "titulo 4", Name = "name 4", Author = "author4"},
            new Book() { Title = "titulo 5", Name = "name 5", Author = "author5"},
        };
    }

    [HttpGet("hello")]  // host/api/books/hello
    public ActionResult SayHello()
    {
        return Ok("Hello!!!!");
    }

    [HttpGet("list")]  // host/api/books/list
    public ActionResult ListBooks()
    {
        return Ok(books);
    }

    [HttpPost("add")]  // host/api/books/add
    public ActionResult InsertBook()
    {
        // AGREGAR PARA INSERTAR UN NUEVO BOOK A LA DB
        return null;
    }
}
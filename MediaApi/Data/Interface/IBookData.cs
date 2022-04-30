using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IBookData
    {
        List<Book> GetBooks();

        Book GetBook(Guid id);

        Book AddBook(Book book);

        Book UpdateBook(Book book);

        Boolean DeleteBook(Guid id);

    }
}

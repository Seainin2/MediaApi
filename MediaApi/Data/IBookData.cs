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

        List<Book> GetBooksBySeriesId(Guid id);

        List<Book> GetBooksByCreatingPropertyId(Guid id);
    }
}

using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlBookData : IBookData
    {
        public AllContext _allContext;

        public SqlBookData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Book AddBook(Book book)
        {
            _allContext.Books.Add(book);
            _allContext.SaveChanges();
            return book;
        }

        public Book GetBook(Guid id)
        {
            return _allContext.Books.Find(id);
        }

        public List<Book> GetBooks()
        {
            return _allContext.Books.ToList();
        }

        public List<Book> getBooksByCreatingPropertyId(Guid id)
        {
            return _allContext.Books.Where(x => x.CreatingPropertyId ==id).ToList();
        }

        public List<Book> GetBooksBySeriesId(Guid id)
        {
            return _allContext.Books.Where(x => x.SeriesId == id).ToList();
        }
    }
}

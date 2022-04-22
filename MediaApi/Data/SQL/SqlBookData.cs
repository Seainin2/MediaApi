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

        public bool DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid id)
        {
            return _allContext.Books.Find(id);
        }

        public List<Book> GetBooks()
        {
            return _allContext.Books.ToList();
        }

        public Book UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

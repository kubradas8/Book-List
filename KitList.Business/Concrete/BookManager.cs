using KitList.Business.Abstract;
using KitList.DataAccess.Abstract;
using KitList.DataAccess.Concrete.EntityFramework;
using KitList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitList.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(int id)
        {
            _bookDal.Delete(new Book { Id = id });
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(p => p.Id == id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}

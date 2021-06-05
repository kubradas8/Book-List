using KitList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitList.Business.Abstract
{
   public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
        Book GetById(int id);
    }
}

using KitList.Core.DataAccess.EntityFramework;
using KitList.DataAccess.Abstract;
using KitList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitList.DataAccess.Concrete.EntityFramework
{
   public class EfBookDal : EfEntityRepositoryBase<Book, BookContext>, IBookDal
    {

    }
}

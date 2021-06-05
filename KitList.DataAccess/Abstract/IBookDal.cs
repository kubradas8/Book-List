using KitList.Core.DataAccess;
using KitList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitList.DataAccess.Abstract
{
   public interface IBookDal : IEntityRepository<Book>
    {

    }
}

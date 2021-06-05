using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitList.Entities.Concrete;

namespace KitList.WebUI.Models
{
    public class BookListViewModel
    {
        public List<Book> Books { get; internal set; }
    }
}

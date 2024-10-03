using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class Book
    {
        public string name;
        public string author;
        public int ID;
        public int pages;

        public int currentPage = 1;

        public Book(string n, string a, int iden, int page)
        {
            name = n;
            author = a;
            ID = iden;
            pages = page;
        }
    }
}

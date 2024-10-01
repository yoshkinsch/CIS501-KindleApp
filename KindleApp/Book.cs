using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class Book
    {
        private string name;
        private string author;
        private int ID;
        private int pages;

        public int currentPage = 1;

        public Book(string n, string a, int iden)
        {
            name = n;
            author = a;
            ID = iden;
        }
    }
}

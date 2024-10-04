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
        public List<string> wordsOnPages;

        private int _currentPage = 1;

        public int currentPage
        {
            get { return _currentPage; }
            set
            {
                if (value < 1)
                {
                    _currentPage = 1;
                }
                else if(value > pages)
                {
                    _currentPage = pages;
                }
                else
                {
                    _currentPage = value;
                }
            }
        }

        public Book(string n, string a, int iden, int page)
        {
            name = n;
            author = a;
            ID = iden;
            pages = page;
            wordsOnPages = new List<string>();
        }
    }
}

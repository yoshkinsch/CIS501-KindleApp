using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class ControllerForBook
    {
        private Book model;
        private int[] bookmarks = new int[5];
        private UpdateBookView updateBook;

        public ControllerForBook(Book m, int[] marks, UpdateBookView h)
        {
            model = m;
            bookmarks = marks;
            updateBook = h;
        }

        public void PageChanged(int p)
        {
            //Implement PageChanged

        }

        public void ReturnToReader()
        {
            //Implement ReturnToReader

        }
    }
}

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
        
        public ControllerForBook(Book m, int[] marks)
        {
            model = m;
            bookmarks = marks;
        }

        public void SetDelegate(UpdateBookView h)
        {
            updateBook = h;
        }
        public void handleBookChange(State s, int pageNum, int bookmarkIndex)
        {
            switch (s)
            {
                case State.GoToPage:

                    PageChanged(pageNum);

                    break;
                case State.SetBookmark:

                    bookmarks[bookmarkIndex] = pageNum;

                    MessageBox.Show("Bookmark Added!");

                    break;
                case State.RemoveBookmark:
                    //bool bookMarkRemoved = false;

                    for (int i = 0; i < bookmarks.Length; i++)
                    {
                        if (bookmarks[i] == pageNum)
                        {
                            bookmarks[i] = 1;
                            break;
                        }
                    }
                    
                    MessageBox.Show("Bookmark removed!");
                    break;
            }
        }

        public void PageChanged(int p)
        {
            model.currentPage = p;
            updateBook(State.UpdateBookView);
        }
    }
}

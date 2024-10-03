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
        private int currentBookmarkCount = 0;
        
        public ControllerForBook(Book m, int[] marks)
        {
            model = m;
            
        }

        public void SetDelegate(UpdateBookView h)
        {
            updateBook = h;
        }
        public void handleBookChange(State s, int pageNum)
        {
            switch (s)
            {
                case State.GoToPage:

                    PageChanged(pageNum);

                    break;
                case State.SetBookmark:

                    if (currentBookmarkCount >= 5)
                    {
                        MessageBox.Show("Max limit of bookmarks reached:\nYou may have only have up to 5 bookmarks");
                    }
                    else if (bookmarks.Contains(pageNum))
                    {
                        MessageBox.Show("Bookmark already exists!\nCannot add a bookmark that already exists.");
                    }
                    else
                    {
                        int indexOfEmpty = Array.IndexOf(bookmarks, 0); //finds a place for the bookmark to be stored in the array

                        //If there was a spot open, then we can store the pageNum of the bookmark there
                        // (There should be because we checked that currentBookmarkCount was >= 5)
                        if (indexOfEmpty != -1)
                        {
                            bookmarks[currentBookmarkCount] = pageNum;
                            currentBookmarkCount++;
                            MessageBox.Show("Bookmark has been added!");
                        }
                    }
                    break;
                case State.RemoveBookmark:
                    bool bookMarkRemoved = false;

                    for (int i = 0; i < bookmarks.Length; i++)
                    {
                        if (bookmarks[i] == pageNum)
                        {
                            currentBookmarkCount--;
                            bookmarks[i] = 0;
                            bookMarkRemoved = true;
                            break;
                        }
                    }

                    //Compacting array from (example) [1,23,0,50,0] to [1,23,50,0,0] OR [0,2,3,4,5] to [2,3,4,5,0]
                    if (bookMarkRemoved)
                    {
                        List<int> compactBookmarks = new List<int>();

                        //Adding non-zero to compact list
                        for (int i = 0; i < bookmarks.Length; i++)
                        {
                            if (bookmarks[i] != 0) { compactBookmarks.Add(bookmarks[i]); }
                        }

                        //Replacing values in original bookmarks and replacing with zeros
                        for (int i = 0; i < bookmarks.Length; i++)
                        {
                            if (i < compactBookmarks.Count) { bookmarks[i] = compactBookmarks[i]; }
                            else { bookmarks[i] = 0; }
                        }

                        MessageBox.Show("Bookmark removed!");
                    }

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

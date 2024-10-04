using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class MiniKindle
    {
        public Dictionary<int, Book> _books;
        public Dictionary<int, int[]> _bookmarks;
        public Library _library = new Library();

        public MiniKindle()
        {
            _books = new Dictionary<int, Book>();
            _bookmarks = new Dictionary<int, int[]>();
            Book JorgeSuperFunny = new Book("Jorge Super Funny", "jorge the best", 12345678, 999);
            Book JorgeClassAwesome = new Book("Jorge Class The Best", "jorge the best", 1234, 55);
            _books.Add(JorgeClassAwesome.ID,JorgeClassAwesome);
            _books.Add(JorgeSuperFunny.ID, JorgeSuperFunny);
            _bookmarks.Add(JorgeClassAwesome.ID, new int[] { 1, 2, 3, 4, 5 });
            _bookmarks.Add(JorgeSuperFunny.ID, new int[] { 1, 2, 3, 4, 5 });
        }

        

        


        
        public void UpdateLib()
        {
            int[] marks = { 1, 2, 3, 4, 5 };

            foreach (KeyValuePair<int,Book> kvp in _library)
            {
                _books.Add(kvp);
            }
        }
    }
}

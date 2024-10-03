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
        }

        Book JorgeVERYfunny = new Book("JorgeVERYfunny","Jorge",1,500);
        Book JorgeMAYBEfunny = new Book("JorgeMAYBEfunny", "Jorge 2", 2, 320);
        Book JorgeNOTfunny = new Book("JorgeNOTfunny", "Jorge 3", 3, 420);

        


        
        public void UpdateLib()
        {
            int[] mark = new int[] { 1,2,3,4,5};
            _books.Add(JorgeVERYfunny.ID,JorgeVERYfunny);
            _books.Add(JorgeMAYBEfunny.ID,JorgeMAYBEfunny);
            _books.Add(JorgeNOTfunny.ID,JorgeNOTfunny);
            _bookmarks.Add(JorgeVERYfunny.ID, mark);
            _bookmarks.Add(JorgeMAYBEfunny.ID, mark);
            _bookmarks.Add(JorgeNOTfunny.ID,mark);



        }
    }
}

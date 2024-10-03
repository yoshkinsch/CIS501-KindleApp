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

        new Book JorgeVERYfunny = new Book("JorgeVERYfunny","Jorge",1,500);
        new Book JorgeMAYBEfunny = new Book("JorgeMAYBEfunny", "Jorge 2", 2, 320);
        new Book JorgeNOTfunny = new Book("JorgeNOTfunny", "Jorge 3", 3, 420);



        public void UpdateLib()
        {
            _books.Add(JorgeVERYfunny.ID,JorgeVERYfunny);
            _books.Add(JorgeMAYBEfunny.ID,JorgeMAYBEfunny);
            _books.Add(JorgeNOTfunny.ID,JorgeNOTfunny); 


        }
    }
}

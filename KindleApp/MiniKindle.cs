using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class MiniKindle
    {
        private Dictionary<int, Book> _books;
        private Dictionary<int, int[]> _bookmarks;

        public MiniKindle()
        {
            _books = new Dictionary<int, Book>();
            _bookmarks = new Dictionary<int, int[]>();
        }

        public void UpdateLib(List<Book> books)
        {
            //Implement UpdateLib

        }
    }
}

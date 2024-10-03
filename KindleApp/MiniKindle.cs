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

        public MiniKindle()
        {
            _books = new Dictionary<int, Book>();
            _bookmarks = new Dictionary<int, int[]>();
        }

        public void UpdateLib()
        {
            //Implement UpdateLib

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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

            readBooks();
        }

        private void readBooks()
        {
            if(File.Exists("books.txt"))
            {
                using(StreamReader sr = new StreamReader("books.txt"))
                {
                    string line = sr.ReadLine();
                    while(line != null)
                    {
                        string[] strings = SplitBookInfo(line);

                        if(strings.Length == 4)
                        {
                            Book b = new Book(strings[0], strings[1], int.Parse(strings[2]), int.Parse(strings[3]));
                            line = sr.ReadLine();
                            strings = SplitText(line);

                            foreach(string s in strings)
                            {
                                b.wordsOnPages.Add(s);
                            }

                            _books.Add(b.ID, b);
                            _bookmarks.Add(b.ID, new int[] { 1, 2, 3, 4, 5 });
                        }

                        line = sr.ReadLine();
                    }
                }
            }
        }

        private string[] SplitBookInfo(string line)
        {
            if(line == null)
            {
                throw new ArgumentNullException("line");
            }

            string[] strings = line.Split('~');
            if(strings.Length != 4)
            {
                throw new ArgumentException("Incorrect number of values for the book");
            }

            return strings;
        }

        private string[] SplitText(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException("line");
            }

            string[] strings = line.Split('~');

            return strings;
        }

        public void UpdateLib()
        {
            int[] mark = new int[] { 1,1,1,1,1};

            foreach (KeyValuePair<int,Book> kvp in _library.cloudBooks)
            {
                if(!_books.ContainsKey(kvp.Key))
                {
                    _books.Add(kvp.Key, kvp.Value);
                    _bookmarks.Add(kvp.Key, mark);
                }
            }
        }
    }
}

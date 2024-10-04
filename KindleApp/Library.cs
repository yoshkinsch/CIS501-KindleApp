using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class Library
    {
        public Library()
        {
            Book JorgeVERYfunny = new Book("JorgeVERYfunny", "Jorge", 1, 500);
            Book JorgeMAYBEfunny = new Book("JorgeMAYBEfunny", "Jorge 2", 2, 320);
            Book JorgeNOTfunny = new Book("JorgeNOTfunny", "Jorge 3", 3, 420);
            cloudBooks.Add(JorgeVERYfunny.ID, JorgeVERYfunny);
            cloudBooks.Add(JorgeMAYBEfunny.ID, JorgeMAYBEfunny);
            cloudBooks.Add(JorgeNOTfunny.ID, JorgeNOTfunny);
            Book JorgeSuperFunny = new Book("Jorge Super Funny", "jorge the best", 12345678, 999);
            Book JorgeClassAwesome = new Book("Jorge Class The Best", "jorge the best", 1234, 55);
            cloudBooks.Add(JorgeClassAwesome.ID, JorgeClassAwesome);
            cloudBooks.Add(JorgeSuperFunny.ID, JorgeSuperFunny);
        }

        private Dictionary<int, Book> cloudBooks = new Dictionary<int, Book>();
    }
}

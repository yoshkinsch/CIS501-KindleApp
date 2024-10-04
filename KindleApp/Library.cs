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
            Book JorgeVERYfunny = new Book("JorgeVERYfunny", "Jorge", 1, 5);
            Book JorgeMAYBEfunny = new Book("JorgeMAYBEfunny", "Jorge 2", 2, 5);
            Book JorgeNOTfunny = new Book("JorgeNOTfunny", "Jorge 3", 3, 5);
            JorgeVERYfunny.wordsOnPages.Add("Jorge VERY funny");
            JorgeVERYfunny.wordsOnPages.Add("Jorge VERY funny");
            JorgeVERYfunny.wordsOnPages.Add("Jorge VERY funny");
            JorgeVERYfunny.wordsOnPages.Add("Jorge VERY funny");
            JorgeVERYfunny.wordsOnPages.Add("Jorge VERY funny");
            JorgeMAYBEfunny.wordsOnPages.Add("Jorge MAYBE funny");
            JorgeMAYBEfunny.wordsOnPages.Add("Jorge MAYBE funny");
            JorgeMAYBEfunny.wordsOnPages.Add("Jorge MAYBE funny");
            JorgeMAYBEfunny.wordsOnPages.Add("Jorge MAYBE funny");
            JorgeMAYBEfunny.wordsOnPages.Add("Jorge MAYBE funny");
            JorgeNOTfunny.wordsOnPages.Add("Jorge NOT funny");
            JorgeNOTfunny.wordsOnPages.Add("Jorge NOT funny");
            JorgeNOTfunny.wordsOnPages.Add("Jorge NOT funny");
            JorgeNOTfunny.wordsOnPages.Add("Jorge NOT funny");
            JorgeNOTfunny.wordsOnPages.Add("Jorge NOT funny");

            cloudBooks.Add(JorgeVERYfunny.ID, JorgeVERYfunny);
            cloudBooks.Add(JorgeMAYBEfunny.ID, JorgeMAYBEfunny);
            cloudBooks.Add(JorgeNOTfunny.ID, JorgeNOTfunny);
            Book JorgeSuperFunny = new Book("Jorge Super Funny", "jorge the best", 12345678, 5);
            Book JorgeClassAwesome = new Book("Jorge Class The Best", "jorge the best", 1234, 5);

            JorgeSuperFunny.wordsOnPages.Add("Jorge super funny");
            JorgeSuperFunny.wordsOnPages.Add("Jorge super funny");
            JorgeSuperFunny.wordsOnPages.Add("Jorge super funny");
            JorgeSuperFunny.wordsOnPages.Add("Jorge super funny");
            JorgeSuperFunny.wordsOnPages.Add("Jorge super funny");
            JorgeClassAwesome.wordsOnPages.Add("Jorge's class is awesome");
            JorgeClassAwesome.wordsOnPages.Add("Jorge's class is awesome");
            JorgeClassAwesome.wordsOnPages.Add("Jorge's class is awesome");
            JorgeClassAwesome.wordsOnPages.Add("Jorge's class is awesome");
            JorgeClassAwesome.wordsOnPages.Add("Jorge's class is awesome");

            cloudBooks.Add(JorgeClassAwesome.ID, JorgeClassAwesome);
            cloudBooks.Add(JorgeSuperFunny.ID, JorgeSuperFunny);
        }

        public Dictionary<int, Book> cloudBooks = new Dictionary<int, Book>();

    }
}

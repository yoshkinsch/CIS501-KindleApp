using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class ControllerForKindle
    {
        private MiniKindle model;
        private UpdateKindleView updateHand;

        public ControllerForKindle(MiniKindle m)
        {
            model = m;
            
        }

        public void setupDel(UpdateKindleView up)
        {
            updateHand = up;
        }

        public void buttonclicked(State s, int id)
        {
            switch (s)
            {
                case (State.SyncLibrary):
                    SyncHandler();
                    updateHand(State.UpdateKindleView);
                    break;
                case (State.SelectBook):

                    OpenBookHandler(id);
                    break;
            }




        }

        private Book getbook_fromid(int id)
        {
            foreach (KeyValuePair<int, Book> k in model._books)
            {
                int idcheck = k.Key;
                if (id == idcheck)
                {
                    return k.Value;
                }
            }
            return null;
        }

        private int[] getBookmarks(int id)
        {
            foreach (KeyValuePair<int, int[]> k in model._bookmarks)
            {
                int idcheck = k.Key;
                if (id == idcheck)
                {
                    return k.Value;
                }
            }
            return null;
        }


        private void SyncHandler()
        {

            model.UpdateLib();


        }

        private void OpenBookHandler(int id)
        {
            Book b = getbook_fromid(id);
            int[] marks = getBookmarks(id);
            /// Need to create book view and book controller 
            //Implement OopenBookHandler
            ControllerForBook cb = new ControllerForBook( b,marks);
             BookView bv = new BookView( b, cb.handleBookChange,marks);
             cb.SetDelegate(bv.Update);
            Application.Run(bv);


        }
    }
}

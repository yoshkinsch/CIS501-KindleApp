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

        public ControllerForKindle(MiniKindle m, UpdateKindleView h)
        {
            model = m;
            updateHand = h;
        }

        public void SyncHandler(State s)
        {
            //Implement SyncHandler

        }

        public void OpenBookHandler(State s, int id)
        {
            //Implement OpenBookHandler

        }
    }
}

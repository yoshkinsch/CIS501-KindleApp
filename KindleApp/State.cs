using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public enum State
    {
        SyncLibrary,
        GoToPage,
        SelectBook,
        CloseBook,
        UpdateBookView,
        UpdateKindleView,
        SetBookmark,
        RemoveBookmark
    }
}

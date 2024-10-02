using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleApp
{
    public partial class BookView : Form
    {
        private Book data;
        public bookInputDel bookInput;

        public BookView(Book data, bookInputDel bookInput)
        {
            this.data = data;
            this.bookInput = bookInput;
            InitializeComponent();
        }

        #region buttons

        private void AddBookmarkButton_Click(object sender, EventArgs e)
        {
            //Implement

        }

        private void RemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            //Implement

        }

        private void CloseBookButton_Click(object sender, EventArgs e)
        {
            //Implement

        }

        private void FlipBackwardButton_Click(object sender, EventArgs e)
        {
            //Implement

        }

        private void FlipForwardButton_Click(object sender, EventArgs e)
        {
            //Implement

        }

        private void PageNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoToBookmarkButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

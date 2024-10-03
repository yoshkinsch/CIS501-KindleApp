namespace KindleApp
{
    public partial class BookView : Form
    {
        private Book data;
        public bookInputDel bookInput;
        private int[] bookmarks;

        public BookView(Book data, bookInputDel bookInput, int[] bm)
        {
            this.data = data;
            this.bookInput = bookInput;
            bookmarks = bm;
            InitializeComponent();
            LoadBookmarkComboBox();
            LoadLabel();
        }

        private void LoadBookmarkComboBox()
        {
            int i = 1;
            foreach (int bm in bookmarks)
            {
                BookmarkComboBox.Items.Add(new KeyValuePair<string, int>($"Bookmark {i}", bm));
                i++;
            }
            BookmarkComboBox.DisplayMember = "Key";
            BookmarkComboBox.ValueMember = "Value";
        }

        private void LoadLabel()
        {
            PageNumberLabel.Text = $"Jorge is only 'sometimes' funny \n {data.currentPage}";
            PageNumberTextBox.Text = data.currentPage.ToString();
        }

        public void Update(State s)
        {
            switch (s)
            {
                case State.UpdateBookView:
                    LoadLabel();
                    LoadBookmarkComboBox();
                    break;
            }
        }

        #region buttons

        private void AddBookmarkButton_Click(object sender, EventArgs e)
        {
            bookInput(State.SetBookmark, data.currentPage);

        }

        private void RemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            bool bookmarkExits = false;
            foreach (int bm in bookmarks) 
            {
                if (data.currentPage == bm)
                {
                    bookmarkExits = true;
                }
            }
            if (bookmarkExits)
            {
                bookInput(State.RemoveBookmark, data.currentPage);
            }
            else { MessageBox.Show("Please go to a bookmarked page to remove the bookmark"); }

        }

        private void CloseBookButton_Click(object sender, EventArgs e)
        {
            bookInput(State.CloseBook, data.currentPage);

        }

        private void FlipBackwardButton_Click(object sender, EventArgs e)
        {
            bookInput(State.GoToPage, data.currentPage--);

        }

        private void FlipForwardButton_Click(object sender, EventArgs e)
        {
            bookInput(State.GoToPage, data.currentPage++);

        }

        private void PageNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            bookInput(State.GoToPage, int.Parse(PageNumberTextBox.Text));
        }

        private void GoToBookmarkButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, int> selectedBookmark = (KeyValuePair<string, int>)BookmarkComboBox.SelectedItem;
            bookInput(State.GoToPage, selectedBookmark.Value);
        }
        #endregion
    }
}

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
            this.Text = data.name;
            LoadBookmarkComboBox();
            LoadLabel();

        }

        private void LoadBookmarkComboBox()
        {
            BookmarkComboBox.Items.Clear();
            int i = 1;
            foreach (int bm in bookmarks)
            {
                BookmarkComboBox.Items.Add(new KeyValuePair<string, int>($"Bookmark {i}", bm));
                i++;
            }
            BookmarkComboBox.DisplayMember = "Key";
            BookmarkComboBox.ValueMember = "Value";
            BookmarkComboBox.SelectedIndex = 0;
        }

        private void LoadLabel()
        {
            PageNumberLabel.Text = data.wordsOnPages[data.currentPage-1] + "\n" + data.currentPage;
            PageNumberTextBox.Text = data.currentPage.ToString();
            BookmarkComboBox.Text = "";
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
            bookInput(State.SetBookmark, data.currentPage, BookmarkComboBox.SelectedIndex);

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
                bookInput(State.RemoveBookmark, data.currentPage, -1);
            }
            else { MessageBox.Show("Please go to a bookmarked page to remove the bookmark"); }

        }

        private void CloseBookButton_Click(object sender, EventArgs e)
        {
            //bookInput(State.CloseBook, data.currentPage);
            Close();
        }

        private void FlipBackwardButton_Click(object sender, EventArgs e)
        {
            int temp = data.currentPage - 1;
            bookInput(State.GoToPage, temp, -1);

        }

        private void FlipForwardButton_Click(object sender, EventArgs e)
        {
            int temp = data.currentPage + 1;
            bookInput(State.GoToPage, temp, -1);

        }

        private void GoToBookmarkButton_Click(object sender, EventArgs e)
        {
            if(BookmarkComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a bookmark to go to");
            }
            else
            {
            KeyValuePair<string, int> selectedBookmark = (KeyValuePair<string, int>)BookmarkComboBox.SelectedItem;
            bookInput(State.GoToPage, selectedBookmark.Value, -1);

            }
        }
        #endregion

        private void GoToPageButton_Click(object sender, EventArgs e)
        {
            bookInput(State.GoToPage, int.Parse(PageNumberTextBox.Text), -1);
        }
    }
}

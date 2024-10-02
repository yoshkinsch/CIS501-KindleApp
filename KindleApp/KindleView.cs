namespace KindleApp
{
    public partial class KindleView : Form
    {
        private MiniKindle data;
        private handleButtonClicked buttonClicked;

        public KindleView(MiniKindle data, handleButtonClicked buttonClicked)
        {
            InitializeComponent();
            this.data = data;
            this.buttonClicked = buttonClicked;
            LoadListView();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            buttonClicked(State.SyncLibrary, -1);

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count > 1) { MessageBox.Show("Please Only Select One Book At a Time"); }
            else if (BookListView.SelectedItems.Count == 0) { MessageBox.Show("Please Select A Book To Open"); }
            else
            {
                buttonClicked(State.SelectBook, GetIdOfSelectedBook());
            }
        }

        private int GetIdOfSelectedBook()
        {
            ListViewItem item = BookListView.SelectedItems[0];
            Book book = (Book)item.Tag;
            return book.ID;
        }

        public void Update(State s)//implement later
        {
            
        }

        private void LoadListView()
        {
            BookListView.Clear();

            foreach (KeyValuePair<int,Book> kvp in data._books)
            {
                ListViewItem book = new ListViewItem(kvp.Value.name);
                book.SubItems.Add(kvp.Value.author);
                book.SubItems.Add(kvp.Value.pages.ToString());
                BookListView.Items.Add(book);
                book.Tag = kvp.Value;
            }
            BookListView.FullRowSelect = true;
            BookListView.View = View.Details;
            BookListView.Columns.Add("Book", -2);
            BookListView.Columns.Add("Author", -2);
            BookListView.Columns.Add("Pages", -2);

        }
    }
}

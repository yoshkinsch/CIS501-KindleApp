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
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            buttonClicked(State.SyncLibrary, GetIdOfSelectedBook());

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            buttonClicked(State.SelectBook, GetIdOfSelectedBook());
        }

        private int GetIdOfSelectedBook()
        {

        }

        public void Update(State s)
        {

        }

        private void LoadListView()
        {
            BookListView.Clear();

            foreach (KeyValuePair<int,Book> kvp in data._books)
            {
                ListViewItem book = new ListViewItem(kvp.Value.);
            }

        }
    }
}

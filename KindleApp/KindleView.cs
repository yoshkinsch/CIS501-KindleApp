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
            //Implement Sync Button

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Implement open Button
        }
    }
}

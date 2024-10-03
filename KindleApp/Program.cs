namespace KindleApp
{
    public delegate void handleButtonClicked(State s, int id);
    public delegate void UpdateKindleView(State s);
    public delegate void bookInputDel(State s, int pageNum);
    public delegate void UpdateBookView(State s);

    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            MiniKindle model = new MiniKindle();
            ControllerForKindle controllerK = new ControllerForKindle(model);
            KindleView viewK = new KindleView(model, controllerK.buttonclicked);
            controllerK.setupDel(viewK.Update);
            Application.Run(viewK);
        }
    }
}
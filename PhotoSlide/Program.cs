namespace PhotoSlide
{
    static class Program 
    {
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ParseSettings.CargaSetting(args[0]);
            ApplicationConfiguration.Initialize();
            var frm = new FrmInicio();
            frm.Show();
            Application.Run();
        }
    }
}
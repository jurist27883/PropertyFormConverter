namespace PropertyFormConverter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        //static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var resultText = "";
            if (args.Length > 0)
                resultText = args[0];

            MainForm mainForm = new MainForm(resultText);

            Application.Run(mainForm);
            
            //Application.Run(new MainForm());
            
        }
    }
}
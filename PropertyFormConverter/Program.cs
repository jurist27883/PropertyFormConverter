namespace PropertyFormConverter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var resultText = (args.Length > 0) ? args[0] : "";
            var checkedRadioButtonName = (args.Length > 1) ? args[1] : "";
            var checkBoxState = (args.Length > 2) ? args[2] : "true";

            Application.Run(new MainForm(resultText,checkedRadioButtonName,checkBoxState));

        }
    }
}
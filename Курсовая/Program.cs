namespace Курсовая
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создание экземпляра класса Customer
            //Customer customer = new Customer();
            // Создание экземпляра класса MainPresenter и передача аргументов
            
            // Создание экземпляра класса MainForm и передача аргумента presenter
            MainForm mainForm = new MainForm();

            Application.Run(mainForm);
        }
    }
}
using DatabaseCatalog;
using AppContext = DatabaseCatalog.ApplicationContext;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (AppContext dbContext = new AppContext())
            {
#if DEBUG
                DbInitializer initializer = new DbInitializer(dbContext);
                initializer.Initialize();
#endif
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}
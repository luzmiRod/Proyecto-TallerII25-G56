namespace Proyecto_TallerII25_G56
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new UsersList());
            //Application.Run(new UserPanel());
            //Application.Run(new NewProveedor());
            //Application.Run(new ProductsList());
            Application.Run(new Login());
        }
    }
}
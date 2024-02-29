using Attendence_Manngment_System.PAL.Forms;

namespace AdminForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static bool ChangedArabic = false;
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm loginform = new LoginForm();
            loginform.Show();
            Application.Run();
            
              
            

        }
    }
}
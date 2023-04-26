using MyResume.Models;

namespace MyResume
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //引入数据模型并从数据固化层（文件）获取数据，如果暂时没有数据固化层，就只先引入数据模型
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new DemonstrateForm());
        }
    }
}
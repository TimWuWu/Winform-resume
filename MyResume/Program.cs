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
            //��������ģ�Ͳ������ݹ̻��㣨�ļ�����ȡ���ݣ������ʱû�����ݹ̻��㣬��ֻ����������ģ��
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new DemonstrateForm());
        }
    }
}
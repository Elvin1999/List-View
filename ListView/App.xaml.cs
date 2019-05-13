using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.IO;
namespace ListView
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            DB = new DataAccessLayer("STHQ0116-06", "GroupDb", "admin", "admin");
        }
        public static DataAccessLayer DB;
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {

            Exception e = (Exception)args.ExceptionObject;          
            string content = e.Message;
            using (var streamWriter = new StreamWriter("exception.txt", true))
            {
                streamWriter.WriteLine(e.Message);
            }
        }
    }
}

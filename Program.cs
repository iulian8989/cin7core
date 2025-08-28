using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Appender;
using log4net.Config;
namespace CIN7Core_MFT_EDI
{
    internal static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize log4net
            var logRepository = LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            SetLogFilePath();
            log.Info("Application Starting...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            log.Info("Application Closing...");
        }
        private static void SetLogFilePath()
        {
            // Get the directory for logs from settings
            string logDirectoryPath = Properties.Settings.Default.LogFilePath;
            if (!Directory.Exists(logDirectoryPath))
            {
                Directory.CreateDirectory(logDirectoryPath); // Ensure the directory exists
            }

            // Get the assembly name
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string logFileName = $"{assemblyName}_";

            // Find the RollingFileAppender and set its file path and log file name format
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            var appender = logRepository.GetAppenders().OfType<RollingFileAppender>().FirstOrDefault();
            if (appender != null)
            {
                // Set the log file path to the directory and use the assembly name as part of the file name
                appender.File = Path.Combine(logDirectoryPath, logFileName); // Only the directory and base name
                appender.ActivateOptions(); // Apply changes
            }
        }
    }
}

using System;
using System.IO;
using System.Web;
namespace MPRTSearch.Logger
{
    public class FileLogger
    {
        public void LogException(Exception e)
        {
            //string path=System.Web.HttpRequest.PhysicalApplicationPath;
            string path=System.Configuration.ConfigurationManager.AppSettings["LogSavePath"];
            File.WriteAllLines(path + "\\" + DateTime.Now.ToString("dd-MM-yyyy mm hh ss") + ".txt",
                new string[]
                {
                    "Message:"+e.Message,
                    "StackTrace:"+e.StackTrace
                });
        }
    }
}
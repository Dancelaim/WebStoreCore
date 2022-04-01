//using Microsoft.Extensions.Logging;

//namespace Admin.Logger
//{
//    public class FileLoggerProvider : ILoggerProvider
//    {
//        private string path;
//        public FileLoggerProvider(string _path)
//        {
//            path = _path;
//        }
//        public ILogger CreateLogger(string categoryName)
//        {
//            return new MyLogger(path);
//        }

//        public void Dispose()
//        {
//        }
//    }
//}
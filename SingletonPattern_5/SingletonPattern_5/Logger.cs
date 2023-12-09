using System;
using System.IO;

namespace SingletonPattern_5
{
    public class Logger
    {
        private static Logger? instance_;
        private static readonly object lock_ = new object();
        private StreamWriter _streamWriter;

        private Logger()
        {
            try
            {
                _streamWriter = new StreamWriter("application.log", true);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Logger initialization failed: {ex.Message}");
            }
        }

        public static Logger Inst
        {
            get
            {
                lock (lock_)
                {
                    if (instance_ == null)
                    {
                        instance_ = new Logger();
                    }
                    return instance_;
                }
            }
        }

        public void Log(string message)
        {
            try
            {
                _streamWriter.WriteLine($"{DateTime.Now}: {message}");
                _streamWriter.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log: {ex.Message}");
            }
        }

        public void Dispose()
        {
            _streamWriter?.Close();
        }
    }
}

using System;

namespace exercise5
{
    public class MyClass
    {
        public delegate void LogHandler(string message);

        class MyLogger
        {
            public void Logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        public void process(LogHandler logHandler)
        {
            if(logHandler!= null)
            {
                logHandler("begin");
            }
            if(logHandler!= null)
            {
                logHandler("End");
            }
        }
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyLogger f1 = new MyLogger();
            MyClass myClass = new MyClass();
            MyClass.LogHandler myLogger = null;
            myLogger += new MyClass.LogHandler(Logger);
            myLogger += new MyClass.LogHandler(f1.Logger);
            myClass.process(myLogger);
            return;
        }
    }
}

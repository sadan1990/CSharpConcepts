using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpConcepts
{
    //Delegates are useful when implementing Callbacks
    class Delegates
    {
        public delegate void ReportProgress (string x);

        public void LongRunningTask(ReportProgress reportProgress)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(500);
                //Here delegate acts as calllback , as post this it will trigger LogMessage and log the details
                reportProgress(string.Format("Completion Percentage is {0}",i));
            }
        }

        public void LogMessage(string data)
        {
            Console.WriteLine(data);
        }

    }
}

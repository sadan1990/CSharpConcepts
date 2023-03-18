using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ParallelAsyncTasks
    {
        public async Task<string> GetName()
        {
            Console.WriteLine("GetName Started");
            Thread.Sleep(1000);
            Console.WriteLine("GetName Intermediate");
            return "a";
            
        }

        public async Task<string> GetName1()
        {
            Console.WriteLine("GetName1 Started");
            Thread.Sleep(1000);
            Console.WriteLine("GetName1 Intermediate");
            return "b";
        }

        public async Task GetAllName()
        {
            Console.WriteLine("GetAllName Started");
            var task1 = GetName();
            var task2 = GetName1();
            Console.WriteLine("GetAllName Intermediate");

            //Next line ensures that task1,task2 will run in parallel and it will wait for it to end.
            //And retuns the data set 
            var data = await Task.WhenAll(task1, task2);

            //We also have Wait All which does same thing but its blocking method/thread
            Task.WaitAll(task1, task2);

            Console.WriteLine(string.Format("GetAllName Completed with Data- {0} and {1}"), data[0], data[1]);

        }
    }
}

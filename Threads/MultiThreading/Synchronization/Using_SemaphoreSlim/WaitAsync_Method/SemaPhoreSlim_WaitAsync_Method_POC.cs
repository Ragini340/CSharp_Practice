using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_SemaphoreSlim.WaitAsync_Method
{
    public class SemaPhoreSlim_WaitAsync_Method_POC
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(2, 2);
        public static async Task RunAsync()
        {
            Task[] tasks = new Task[5];

            for (int i = 1; i <= 5; i++)
            {
                int taskId = i;
                tasks[i - 1] = ProcessTask(taskId);
            }

            await Task.WhenAll(tasks);

            Console.WriteLine("All tasks completed.");
        }

        public static async Task ProcessTask(int taskId)
        {
            Console.WriteLine($"Task {taskId} waiting...");
            await semaphore.WaitAsync();

            try
            {
                Console.WriteLine($"Task {taskId} entered");
                await Task.Delay(3000);
                Console.WriteLine($"Task {taskId} leaving");
            }
            finally
            {
                semaphore.Release();
            }
        }

        public static async Task Main(string[] args)
        {
            await RunAsync();
        }

    }
}
namespace CSharp_Practice.CodingQuestions.MultiThreading
{
    /*
     Program to print odd and even number using multithreading
    */
    public class EvenAndOddNumsUsingMultiThreading
    {
        public static void PrintEvenNumbers()
        {
            Console.WriteLine("List of even numbers are: ");
            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.Write(i + " ");
            }
        }

        public static void PrintOddNumbers()
        {
            Console.WriteLine("\nList of odd numbers are: ");
            for (int i = 1; i <= 10; i = i + 2)
            {
                Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            Thread evenThread = new Thread(PrintEvenNumbers);
            Thread oddThread = new Thread(PrintOddNumbers);

            evenThread.Start(); //By using evenThread.Start() means evenThread has been scheduled for execution. 

            evenThread.Join(); //Thread.Join(): The Join method of the Thread class waits for the thread to complete its execution
                               //before continuing with the execution of the calling thread. This method blocks the calling thread
                               //until the target thread has completed its execution.

            oddThread.Start(); //By using oddThread.Start() means oddThread has been scheduled for execution. 
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Finalize_Dispose
{
    public class UseOfFinalizeAndDispose : IDisposable
    {
        // To track whether Dispose has been called.
        private bool _disposed = false;

        public UseOfFinalizeAndDispose()
        {
            // Allocate or initialize an unmanaged resource.
            Console.WriteLine("Unmanaged resource allocated.");
        }

        // Implementing Dispose method from IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent finalizer from being called.
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free any other managed objects here.
                    Console.WriteLine("Free other managed objects");
                }
                // Free unmanaged resources here.
                Console.WriteLine("Unmanaged resource released.");
                _disposed = true;
            }
        }

        // Finalizer is nothing but the destructor
        ~UseOfFinalizeAndDispose()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called.");
        }

        public static void Main(string[] args)
        {
            // Using the class(UseOfFinalizeAndDispose) with using statement
            using (var useOfFinalizeAndDispose = new UseOfFinalizeAndDispose())
            {
                // Use the resource.
            }
            // Dispose is called automatically when exiting the using block.
            // If not using 'using', dispose should be called manually.
            var useFinalizeAndDispose = new UseOfFinalizeAndDispose();
            // Use the resource.
            useFinalizeAndDispose.Dispose();
            // Without calling Dispose, finalizer will be called by GC at some point.
            var resourceHolder = new UseOfFinalizeAndDispose();
            // Use the resource.
        }
    }
}
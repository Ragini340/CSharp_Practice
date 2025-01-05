using System.Reflection;

namespace CSharp_Practice.Delegate_POC
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public delegate void CallbackMethodHandler(string message);
    public delegate void DoSomeMethodHandler(string message);

    public class DelegateExample
    {
        public static void Main(string[] args)
        {
            WorkPerformedHandler workPerformedHandler = new WorkPerformedHandler(Manager_WorkPerformed);
            workPerformedHandler(5, WorkType.Golf);

            DelegateExample delegateExample = new DelegateExample();
            CallbackMethodHandler callbackMethodHandler = new CallbackMethodHandler(delegateExample.CallbackMethod);
            DoSomework(callbackMethodHandler);

            //Example to understand Delegate class important properties and method 
            Delegates delegates = new Delegates();
            DoSomeMethodHandler doSomeMethodHandler = new DoSomeMethodHandler(delegates.DoSomework);
            MethodInfo method = doSomeMethodHandler.Method;
            object target = doSomeMethodHandler.Target;
            Delegate[] invocationList = doSomeMethodHandler.GetInvocationList();
            Console.WriteLine($"Method property: {method}");
            Console.WriteLine($"Target property: {target}");

            foreach (var item in invocationList)
            {
                Console.WriteLine($"InvocationList:- {item}");
            }
        }

        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work performed by EventHandler");
            Console.WriteLine($"Work hours:- {workHours}, Work type:- {wType}");
        }
        public static void DoSomework(CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some task");
            del("Ragini");
        }
        public void CallbackMethod(string message)
        {
            Console.WriteLine("CallbackMethod executed");
            Console.WriteLine($"Hello: {message}, Good Morning!!");
        }
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports,
    }

}
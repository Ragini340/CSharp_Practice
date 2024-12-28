using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            //In this case we have written same method Add in parent class without using virtual keyword and in child class without using
            //override keyword, so in this case there are two points:-
            //1.Created reference and object of parent class, so ideally parent class should execute.
            //2. Created reference of parent class and created object of child class, so as per override child class method should
            //execute but  
            //in point 1 and 2 in both cases , it has called parent class method because we have not used virtual keyword in base class
            //method and oevrride keyword in child class method.
            //So, this is not the overriding but this is overloading concept. 

            MethodOverloadingParent methodOverloadingParent = new MethodOverloadingParent();  //Parent class method will execute
            methodOverloadingParent.Add(10);

            MethodOverloadingParent methodOverloadingParents = new MethodOverloadingChild(); //Parent class method will execute because
                                                                                             //that is not overriding concept without
                                                                                             //use of virtual and override keyword in
                                                                                             //parent and child class method.
            methodOverloadingParents.Add(20);
            MethodOverloadingChild methodOverloadingChild = new MethodOverloadingChild();  //Child class method will execute
            methodOverloadingChild.Add(10);

            //Overriding here 
            methodOverloadingParent.Subtract(10); //Parent class subtract method
            methodOverloadingParents.Subtract(20); //Child class subtract method
            methodOverloadingChild.Subtract(20); //Child class subtract method
        }
    }
}
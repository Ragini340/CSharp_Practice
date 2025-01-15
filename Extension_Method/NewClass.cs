namespace CSharp_Practice.Extension_Method
{
    public static class NewClass
    {
        public static void Test3(this OldClass obj)
        {
            Console.WriteLine("Method three");
        }
        public static void Test4(this OldClass obj, int x)
        {
            Console.WriteLine("Method four: " + x);
        }
        public static void Test5(this OldClass obj)
        {
            Console.WriteLine("Method five: " + obj.x);
        }
    }
}
/*
Extension methods must be defined only under the static class. 

As an extension method is defined under a static class, it means the extension method should be created as a static method whereas 
once the method is bound with another class, the method changes into non-static. 

Now, if you check the methods in NewClass, then you will see that all three methods are declared as static only.
The first parameter of an extension method is known as the binding parameter which should be the name of the class to which the
method has to be bound and the binding parameter should be prefixed with this as here we are creating these extension methods to 
extend the functionality of OldClass, so, you can check the first parameter of all these methods are going to be OldClass which is 
also prefixed with this keyword.

An extension method can have only one binding parameter and that should be defined in the first place on the parameter list.
If required, an extension method can be defined with normal parameters also starting from the second place of the parameter list.
If you check the Test3 method, we have passed the second parameter as int and while calling this method we also need to pass one 
integer value.
 */
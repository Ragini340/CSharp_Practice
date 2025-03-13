namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Prototype_Design_Pattern
{
    /*
     The Prototype design pattern is used when we want to create a duplicate or cloned object from an existing object to enhance the
     application’s performance. That means we need to use the Prototype design pattern when creating an object is time-consuming, 
     costly, and complex. 
    */
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
}
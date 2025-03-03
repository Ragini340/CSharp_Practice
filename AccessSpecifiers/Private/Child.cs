namespace CSharp_Practice.AccessSpecifiers.Private
{
    public class Child : PrivateAccessSpecifiersPOC
    {
        public void ShowValue()
        {
            //Trying to access data inside a derived class
            //Error: 'member' is inaccessible due to its protection level
            //Console.WriteLine("Value = " + data);
        }
    }
}
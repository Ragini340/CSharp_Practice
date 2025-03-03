namespace CSharp_Practice.AccessSpecifiers.Protected_Internal
{
    /*
     protected internal access modifier combines the features of protected and internal. It allows members to be accessed within the
     same assembly as well as in derived classes, regardless of whether they are in the same assembly or not.
     */
    public class Protected_InternalPOC
    {
        protected internal int value;
    }
}
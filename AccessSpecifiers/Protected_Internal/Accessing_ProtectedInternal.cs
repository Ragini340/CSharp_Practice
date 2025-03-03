namespace CSharp_Practice.AccessSpecifiers.Protected_Internal
{
    public class Accessing_ProtectedInternal
    {
        /*
         Note: This program is in the same folder and the member value of Protected_InternalPOC is protected internal and we can 
         access it in the derived class with Protected_InternalPOC class’s instance.
         */
        public void TestAccess()
        {
            Protected_InternalPOC protected_Internal = new Protected_InternalPOC();
            protected_Internal.value = 12;
        }
    }
}
namespace CSharp_Practice.AccessSpecifiers.Protected_Private
{
    /*
     protected private access is only granted to the containing class. Any other class inside the current or another assembly is not
     granted access to these members. 
     */
    public class Protected_PrivateModifier_POC
    {
        private protected int value;
        public void SetValue(int v)
        {
            value = v;
        }
        public int GetValue()
        {
            return value;
        }

    }
}
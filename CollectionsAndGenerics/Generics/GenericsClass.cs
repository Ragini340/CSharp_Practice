using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CollectionsAndGenerics.Generics
{
    public class GenericsClass<T>
    {
        private T GenericMemberVariable;

        public GenericsClass(T value)
        {
            GenericMemberVariable = value;
        }

        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
            return GenericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }
}

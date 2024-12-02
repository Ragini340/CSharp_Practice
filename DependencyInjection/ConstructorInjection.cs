using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.DependencyInjection
{
    public interface Text
    {
        void Print();
    }

    public class ConstructorInjection
    {
        private Text _text;
        public ConstructorInjection(Text text1)
        {
            this._text = text1;
        }
        public void Print()
        {
            _text.Print();
        }
    }

    public class Format : Text
    {
        public void Print()
        {
            Console.WriteLine("Text Format");
        }
    }

    public class Constructor
    {
        public static void Main(string[] args)
        {
            ConstructorInjection constructorInjection = new ConstructorInjection(new Format());
            constructorInjection.Print();
            Console.ReadKey();
        }
    }

}

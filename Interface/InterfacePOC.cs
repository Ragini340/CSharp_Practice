using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Interface
{
    public interface InterfacePOC
    {
        public void Display();
        abstract void ChangeGear(int g);
        abstract void SpeedUp(int s);
        abstract void ApplyBrake(int b);
    }

}

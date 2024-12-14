using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Loose_Couple
{
    public class Remote
    {
        IRemote remote;

        public Remote(IRemote remote)  // Loosely coupled , Here we are not sure which object will pass . It can be Laptop , Television or Refrigerator beacuse we passing here refrence of Iremote which has implemnted multiples class .
                                       //It is injection other object so It called depndecny injection //and here we are injceting in constructor so It called countror dependecny injection
                                       // Here we could have televsion object but Itwill be useful only for Televesion so that is not correct designing , Here  we are any object , Televesion , Laptop or Refrigerator
        {                             
            this.remote = remote;
        }

        public void Run()
        {
            remote.Run();
        }
    }
}

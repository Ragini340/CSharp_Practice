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

        public Remote(IRemote remote)  //Loosely coupled, here we are not sure which object will pass. It can be Laptop, Television, or Refrigerator because we are passing here reference of IRemote iterface which has implemented multiple classes.
                                       //It is injecting other object, so it is called Dependency Injection.
                                       //Here we are injecting in constructor, so it called Constructor Dependecny Injection.
                                       //Here we could have Television object but it will be useful only for Television so that it is not correct designing. Here can be any object Televesion, Laptop or Refrigerator.
        {                             
            this.remote = remote;
        }

        public void Run()
        {
            remote.Run();
        }
    }
}

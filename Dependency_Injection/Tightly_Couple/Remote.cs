using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Dependency_Injection.Tightly_Couple
{
    /*Disadvantages of Tight coupling: 
    Television without a remote control does not work.
    */
    public class Remote
    {
        private Television television;
        static Remote remoteController;

        public Remote()
        {
            television = new Television();
        }

        static Remote()
        {
            remoteController = new Remote();
        }

        public static Remote Control
        {
            get
            {
                return remoteController;
            }
        }

        public void RunTelevision()  //Here remote is tightly coupled with Television. This remote is only for Television.
        {
            television.Run();  //Here the Control can only control the Television, cannot control other devices. 
        }
    }
}

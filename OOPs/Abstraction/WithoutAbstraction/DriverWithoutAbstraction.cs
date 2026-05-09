using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.WithoutAbstraction
{
    public class DriverWithoutAbstraction
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SBI banking system");
            SBI sBI = new SBI();
            sBI.WithDrawMoney();
            sBI.DepositMoney();
            sBI.CheckBalance();
            sBI.MiniStatement();
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the AXIS banking system");
            AXIS aXIS = new AXIS();
            aXIS.WithDrawMoney();
            aXIS.DepositMoney();
            aXIS.CheckBalance();
            aXIS.MiniStatement();
        }
    }
}
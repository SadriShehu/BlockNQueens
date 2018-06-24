using System;

namespace Problemi8Mbretereshat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Sheno numrin e mbretereshave : ");
            int n = int.Parse(Console.ReadLine());

            
            Mbreteresha objMbreteresha = new Mbreteresha(n);
            if (objMbreteresha.Zgjidhja(0))
            {
                objMbreteresha.ShfaqNeEkran();
            }
            else
            {
                Console.WriteLine("Ka ndodhur nje gabim!");
            }
            

            Console.ReadLine();
        }
    }
}

using System;

namespace Problemi8MbretereshatFCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sheno numrin e mbretereshave : ");
            int n = int.Parse(Console.ReadLine());


            MbretereshaFCH objMbreteresha = new MbretereshaFCH(n);
            if (objMbreteresha.Zgjidhja(0, n))
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
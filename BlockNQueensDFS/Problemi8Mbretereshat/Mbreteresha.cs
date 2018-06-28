using System;
using System.Collections.Generic;
using System.Text;

namespace Problemi8Mbretereshat
{
    class Mbreteresha
    {
        public int N;
        public int[,] Tabela;

        public Mbreteresha(int _N)
        {
            N = _N;
            Tabela = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    Tabela[i, j] = 0;
            // Vendet ku do te bllokohen shenohen me numrin -1
            Random pozitaBllokuar = new Random();

            int l = pozitaBllokuar.Next(1, 5);

            for (int k = 0; k < l; k++)
            {
                int i = pozitaBllokuar.Next(0, N);
                int j = pozitaBllokuar.Next(0, N);
                Tabela[i, j] = -1;
            }
        }
        
        public bool Sigurt(int rreshti, int kolona)
        {
            int i, j;

            for (i = 0; i < kolona; i++)  //sulmi ne rreshtin e njejt
                if (Tabela[rreshti, i] == 1)
                    return false;

            for (i = rreshti,j = kolona; i >= 0 && j >= 0; i--,j--) //sulmi ne diagonale
                if (Tabela[i, j] == 1)
                    return false;

            for (i = rreshti, j = kolona; i < N && j >= 0; i++, j--) // sulmi ne diagonale ne anen tjeter  
                if (Tabela[i, j] == 1)
                    return false;
            return true;
        }


        public bool Zgjidhja(int k)
        {

           // Console.WriteLine("--------------------------");
           // ShfaqNeEkran();
           // Console.WriteLine("--------------------------");
            if (k >= N)
            {
                return true;
            }
            for(int r = 0; r < N; r++)
            {
                if (Sigurt(r, k))
                {
                    if (Tabela[r, k] != -1)
                    {
                        Tabela[r, k] = 1;
                        if (Zgjidhja(k + 1))
                        {
                            return true;
                        }
                    }
                    
                 
                }

            }
            return false;
        }

        public void ShfaqNeEkran()
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(Tabela[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

    }
}

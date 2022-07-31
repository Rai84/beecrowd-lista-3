using System;

namespace BEE_1080
{
    class Program
    {
        static void Main(string[] args)
        {

            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;
 
            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}

using System;

namespace BEE_1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";
            string senhauser;

            do
            {
                senhauser = Console.ReadLine();

                if (senha != senhauser)
                {

                    Console.WriteLine("Senha Invalida");
                }

            } while (senha != senhauser);

            Console.WriteLine("Acesso Permitido");
        }
    }
}

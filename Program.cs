using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0, resultado;


            string nome;

            Console.WriteLine("DIGITE O VALOR QUE DESEJA FAZER A TABUADA");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = i * x;
                Console.WriteLine(i + " x " + x + " = " + resultado);
            }
            Console.ReadLine();

        }
    }
}

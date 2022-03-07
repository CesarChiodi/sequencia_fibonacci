using System;

namespace sequencia_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parada, aux, numero = 0, numero2 = 1;

            Console.WriteLine("escreva a parada");
            parada = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("0\n1");

            for (int i = 0; i < parada; i++)
            {
                aux = numero;
                numero = numero2;
                numero2 = numero + aux;
                Console.WriteLine(numero2);
            }
            Console.ReadKey();
        }
    }
}
 
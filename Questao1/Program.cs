using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da escada: ");
            int n = int.Parse(Console.ReadLine());
            var arr = new string[n];

            for (int i = 0; i < n; i++)
            {   
                arr[i] = "*";
                Console.WriteLine(PrintarEscada(n, arr));
            }
        }

        public static string PrintarEscada(int n, string[] arr)
        {
            return $"{string.Join("", arr).PadLeft(n)}";
        }
    }
}

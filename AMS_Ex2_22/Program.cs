using System;

namespace AMS_Ex2_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro = 5.13;
            double qtdEuro = 750;
            double real = (qtdEuro * euro);

            Console.WriteLine("");
            Console.WriteLine($"O valor dessa quantia em euro convertida para o real é de: {real} reais");
            Console.WriteLine("");
        }
    }
}
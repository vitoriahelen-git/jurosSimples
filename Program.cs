using System;

namespace jurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital; 
            double juros; 
            double tempo; 
            double resultadojuros;
            double montante; 

            Console.WriteLine("Valores: \n");
            Console.Write("Capital: ");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Juros: ");
            juros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tempo: ");
            tempo = Convert.ToDouble(Console.ReadLine());
            resultadojuros = capital * (juros/100) * tempo;
            Console.Write($"\nJuros: {resultadojuros:N2}\n");
            montante = capital + resultadojuros; 
            Console.Write($"Montante: {montante:N2}");


        }
    }
}

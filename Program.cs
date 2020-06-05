using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Mostrar a data e hora do sistema");
            DateTime HoraSistema = DateTime.Now;
            Console.WriteLine($"Hora do sistema: {HoraSistema}");
        }
    }
}

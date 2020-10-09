using System;
using Figgle;
using Humanizer;


namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Figgle: HoraSistema Com Pacotes!");
            Console.WriteLine(FiggleFonts.Standard.Render("Bom Dia"));
            Console.ReadKey();
            
            
            Console.WriteLine("--- Pelo Horario De Brasília Agora São:");
            DateTime horaSistema = DateTime.Now;
            Console.WriteLine($"Exatamente: {horaSistema}");



        }
    }
}

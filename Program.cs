using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string Writingconverter1;
            string Writingconverter2;
            string Writingconverter3;
            string Writingconverter4;
            decimal nota1, nota2, nota3, nota4, resultado;
            bool Validnumber1;
            bool Validnumber2;
            bool Validnumber3;
            bool Validnumber4;

            Console.WriteLine("-- Média --\n");

            Console.WriteLine("Digite as suas notas abaixo.");

            Console.Write("\nNota 1: ");  
            Writingconverter1 = Console.ReadLine();
            Validnumber1 = Decimal.TryParse(Writingconverter1, out nota1);

            Console.Write("Nota 2: ");
            Writingconverter2 = Console.ReadLine();
            Validnumber2 = Decimal.TryParse(Writingconverter2, out nota2);

            Console.Write("Nota 3: ");
            Writingconverter3 = Console.ReadLine();
            Validnumber3 = Decimal.TryParse(Writingconverter3, out nota3);

            Console.Write("Nota 4: ");
            Writingconverter4 = Console.ReadLine();
            Validnumber4 = Decimal.TryParse(Writingconverter4, out nota4);

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;
            
            if (!Validnumber1 || !Validnumber2 || !Validnumber3 || !Validnumber4)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nERROR: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Entre com Números Por Gentileza.");
            }
            else if (nota1 <0 || nota1>10 || nota2 <0 || nota2 >10 || nota3 <0 || nota3 >10 || nota4 <0 || nota4 >10) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nERROR: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite somente notas entre 0 e 10.");
            }
            else 
            {
                Console.WriteLine($"\nresultado {resultado:N1}");
            }
            Console.ResetColor();
        }
    }
}

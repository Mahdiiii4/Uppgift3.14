using System;
namespace uppgift3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har då gåt genom gymnasiet? Svara J för Ja eller N för Nej");
            string svar = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (svar.ToLower() == "j" && ålder <= 22)
                Console.WriteLine("Vi vill gärna inställa dig");
            else Console.Write("Vi letar tyvärr efter annan personal just nu.");
        }
    }
}
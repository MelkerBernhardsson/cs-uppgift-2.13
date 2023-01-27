using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" skriv in lönen för en av dina anställda i antal tusen kr");
            int lön1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" skriv in lönen för en till av dina anställda i antal tusen kr");
            int lön2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" skriv in lönen för en tredje av dina anställda i antal tusen kr per månad");
            int lön3 = int.Parse(Console.ReadLine());
            int medellön = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("medellönen för dina tre anställda är " + medellön + " kronor per månad");
        }
    }
}

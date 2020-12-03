using System;
using System.Collections.Generic;
using System.Text;

namespace TestRepo
{
    class TestowaKlasa
    {
        public void a()
        {
            Console.WriteLine("Dupa");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"linia: {i+1}");
            }
        }
    }
}

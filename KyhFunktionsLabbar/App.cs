using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhFunktionsLabbar
{
    internal class App
    {
        public string GetMessage()
        {
            return "Hello world";
        }
        public void Lab1()
        {
            string message = GetMessage();
            Console.WriteLine(message);
            //Console.WriteLine(GetMessage());
        }

        public void Lab2()
        {
            int i = 12;
            double pi = 3.1415927;
            float f = 3.1415927f;
            decimal d = 12.1234m;


            //
        }

        public int GetLargestNumber(int tal1, int tal2, int tal3)
        {
            if (tal1 > tal2 && tal1 > tal3)
                return tal1;
            if (tal2 > tal1 && tal2 > tal3)
                return tal2;
            return tal3;
        }

        public bool IsCool(string name)
        {
            if (name == "Stefan") return true;
            return false;
        }

        public void Run()
        {
            bool isCool = IsCool("Stefan");
            if (isCool)
            {
                Console.WriteLine("Yes jättecool");
            }

            Console.WriteLine("Nu startar det");

            int talet = Convert.ToInt32( Console.ReadLine() );
            int talet2 = Convert.ToInt32(Console.ReadLine());
            int talet3 = Convert.ToInt32(Console.ReadLine());
            int largest = GetLargestNumber(talet2, talet3, talet);
            Console.WriteLine($"Största är {largest} ");

            Console.WriteLine("Nu slutar det");

            // WHY -  STRUKTUR
            //        UPPDELNING
            // HUR ?   Kodblock fast med ett namn
            while (true)
            {
                string s = Console.ReadLine();
                Console.WriteLine(s);
            }
            Lab2();
            //Lab1();
        }

    }
}

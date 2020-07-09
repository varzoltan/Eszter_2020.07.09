using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._07._09
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Készítsünk programot, amely bekér két egész számot, majd a nagyobb számból vonja ki a kisebbet, 
            //valamint a nagyobb számot ossza el a kisebbel!
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > szam2)
            {
                int kulonbseg = szam1 - szam2;
                double osztas = szam1 / szam2;
                int osztas1 = szam1 / szam2;
                Console.WriteLine($"\nKülönbség:{kulonbseg}, Osztás (nem egész):{osztas}, Osztás (egész):{osztas1}");
            }
            else
            {
                int kulonbseg = szam2 - szam1;
                double osztas = szam2 / szam1;
                int osztas1 = szam2 / szam1;
                Console.WriteLine($"\nKülönbség:{kulonbseg}, Osztás (nem egész):{osztas}, Osztás (egész):{osztas1}");
            }

            //2. Készítsünk programot, amely bekér a felhasználótól két számot. 
            //A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám. 
            //Amennyiben igen, írja ki az osztás eredményét is.
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik egész számot: ");
            int szam4 = int.Parse(Console.ReadLine());
            if (szam3 % szam4 == 0)
            {
                int osztas = szam3 / szam4;
                Console.WriteLine($"Az osztás eredménye: {osztas}");
            }
            else
            {
                Console.WriteLine($"A {szam4} nem osztólya a {szam3} számnak!");
            }

            //3. Készítsünk programot, mely eldönti egy háromszög három oldala alapján, 
            //hogy az adott háromszög szerkeszthető-e.
            Console.Write("Kérem adjon meg egy egész számot: ");
            int oldal1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik egész számot: ");
            int oldal2 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy harmadik egész számot: ");
            int oldal3 = int.Parse(Console.ReadLine());
            if ( (oldal1 + oldal2)>oldal3 && (oldal2 + oldal3)>oldal1 && (oldal1 + oldal3)>oldal2 )
            {
                Console.WriteLine("A háromszög megszerkeszthető.");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető meg.");
            }

            //4 .Készítsünk programot, amely bekér egy N számot és kiírja a számokat 1-től N-ig.
            Console.Write("Kérem adjon meg egy egész számot: ");
            int Nszam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Nszam; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}

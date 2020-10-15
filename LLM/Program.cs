using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, x=1, y=0, z=0;
            Console.WriteLine("De cate ori mai mare sa fie puterea de calcul al procesorului?: ");

            string line = Console.ReadLine();
            n = int.Parse(line);
            while (x < n) 
            { 
                x = x * 2;
                y = y + 18;
            }
            while (y >= 12)
            {
                z++;
                y = y - 12;
            }
            if(y!=0)
            Console.WriteLine($"Puterea de calcul a procesorului va fi de {n} ori mai mare dupa {z} ani si {y} luni, la acelasi pret.");
            else
            Console.WriteLine($"Puterea de calcul a procesorului va fi de {n} ori mai mare dupa {z} ani, la acelasi pret.");    
        }
    }
}

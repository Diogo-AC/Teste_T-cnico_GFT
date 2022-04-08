using System;
using static System.Console;

namespace Exercício_GFT_1
{
    class Program
    {
        static void Main(string[] args)
        {
        double a, b, c;
        Console.WriteLine("Digite três números consecutivamente e aperte entre:");
        a= double.Parse(Console.ReadLine());
        b= double.Parse(Console.ReadLine());
        c= double.Parse(Console.ReadLine());


        if (a >= b && a >= c && b >= c){
            Console.WriteLine($"A ordem crescente é {c} , {b} e {a}");
            Console.WriteLine($"A ordem decrescente é {a} , {b} e {c}");
        }
        if (a >= b && a >=c && c >= b){
            Console.WriteLine($"A ordem crescente é {b} , {c} e {a}");
            Console.WriteLine($"A ordem decrescente é {a} , {c} e {b}");
        }    
        if (b >= a && b >= c && a >= c){
            Console.WriteLine($"A ordem crescente é {c} , {a} e {b}");
            Console.WriteLine($"A ordem decrescente é {b} , {a} e {c}");
        }    
        if (b >= a && b >= c && c >= a){
            Console.WriteLine($"A ordem crescente é {a} , {c} e {b}");
            Console.WriteLine($"A ordem decrescente é {b} , {c} e {a}");
        }
        if(c >= a && c >= b && a >=b){
           Console.WriteLine($"A ordem crescente é {b} , {a} e {c}");
           Console.WriteLine($"A ordem decrescente é {c} , {a} e {b}");
        }
        if (c >= a && c >= b && b >= a){
            Console.WriteLine($"A ordem crescente é {a} , {b} e {c}");
            Console.WriteLine($"A ordem decrescente é {c} , {b} e {a}");
        } 
        }
    }
}

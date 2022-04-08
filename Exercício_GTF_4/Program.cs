using System;
using static System.Console;

namespace Exercício_GTF_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, acumulado;
            float valor;
            i = 1;
            acumulado = 0;

            while (i < 6){
            WriteLine("Digite o valor de compra do cliente "+ (i));
            valor = float.Parse(Console.ReadLine());
            i += 1;
            acumulado = (int)(acumulado + valor);
            }

            if (acumulado > 54000)
            WriteLine($"Superou o valor de compra em R$:  {(acumulado -54000).ToString("F2")}" );
            else
            
            WriteLine("Valor de compra não superado");
            }
    }
}

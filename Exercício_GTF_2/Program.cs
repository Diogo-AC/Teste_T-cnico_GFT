using System;
using static System.Console;

namespace Exercício_GTF_2
{
    class Program
    {
        static void Main(string[] args)
        {
        double nota1, nota2 , nota3, media, freq;
        WriteLine ("Digite a 1ª nota do aluno:");
        nota1 = double.Parse(ReadLine());
        WriteLine ("Digite a 2ª nota do aluno:");
        nota2 = double.Parse(ReadLine());
        WriteLine ("Digite a 3ª nota do aluno:");
        nota3 = double.Parse(ReadLine());
        WriteLine ("Digite a frequência do aluno:");
        freq = double.Parse(ReadLine());
        
        media = ((nota1 + nota2 + nota3)/ 3);
        
        WriteLine ($"A média do aluno foi: {media.ToString("F2")} e frequência de {freq}%");

        if (media < 7 && freq <=50)
        {
            WriteLine ($"O aluno está reprovado como a nota {media.ToString("F2")}e frequência de {freq}%");
        }
               
        if (media >= 7 && freq > 50)
        {
            WriteLine ($"O aluno está aprovado como a nota {media.ToString("F2")}e frequência de {freq}%");
        }

}
}
}


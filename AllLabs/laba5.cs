namespace AllLabs;
using System.Collections.Generic;


public class laba5
{
    /*Определить, есть ли среди заданной последовательности
   комплексных чисел два с равными модулями. Сравнение производить с
   точностью 10e-8 с помощью собственного класса сравнения.*/
    public void Main()
    {
        var lst = new List<string>()
        {
            "20+24i", "13+10i", "4+5i", "6+1i", "10+13i", "10+13i", "20+24i"
        };
        var lst_complex = lst.Select(x => new Complex(x)).ToArray();
        for (var i = 0; i < lst_complex.Count(); i++)
        {
            for (var j = i + 1; j < lst_complex.Count(); j++)
                if ((lst_complex[i].Abs() - lst_complex[j].Abs()) < 1e8)
                    Console.WriteLine($"{lst_complex[i]} равен по модулю {lst_complex[j]}");
        }

        for (var j = 0; j < lst_complex.Count(); j++)
            Console.WriteLine($"{lst_complex[j]} модуль {lst_complex[j].Abs()}");
        
    }
}
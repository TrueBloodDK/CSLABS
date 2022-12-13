﻿namespace AllLabs;
using System;
using System.Numerics;

public class laba1
{
    public void Main()
    {  Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_1,
            [2] = work_2,
            [3] = work_3,
            [4] = work_4,
        };
        Console.WriteLine("Какое задание делаем? (1 - 4)");
        int key = int.Parse(Console.ReadLine() ?? string.Empty);
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Нет такого задания");
    }

    static void work_1()
    {
        Console.WriteLine("Напиши чему равен X:");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Ответ: ");
        Console.Write((2 * (1 / Math.Tan(3 * x))) * (-1 * Math.Sqrt(x))
                      - 1 / (12 * (Math.Pow(x, 2)) + (7 * x) - 5));
    }

    static void work_2()
    {
        /*
         Корни при значениях ABC 
         4 корня - (1; -5; 6)
         2 корня - (1; -4; 4)
         нет корней - (1; 0; 10)
         */
        Console.WriteLine("Нужно узнать числа a, b, c \nчему равно a?");
        double a = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("чему равно b?");
        double b = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("чему равно c?");
        double c = double.Parse(Console.ReadLine() ?? string.Empty);
        double d = Math.Pow(b, 2) - 4 * a * c;

        if (d > 0)
        {
            double t1 = (-b - Math.Sqrt(d)) / (2 * a);
            double t2 = (-b + Math.Sqrt(d)) / (2 * a);
                if (t1 > t2) (t1, t2) = (t2, t1);
                Console.WriteLine("Корни: ");
                if (t1 >= 0)
                {

                    double x1 = Math.Sqrt(t1);
                    double x2 = -Math.Sqrt(t1);
                    Console.Write($"X1 = {x1} X2 = {x2} \n");
                }

                if (t2 >= 0)
                {
                    double x3 = Math.Sqrt(t2);
                    double x4 = -Math.Sqrt(t2);
                    Console.Write($"X3 = {x3} X4 = {x4} ");
                }
        }
        else if (d == 0)
        {
            double x1 = Math.Sqrt(-b / 2 * a);
            double x2 = -Math.Sqrt(-b / 2 * a);
            Console.WriteLine($"Корни:\nX1 = {x1} X2 = {x2}");
        }
        else Console.WriteLine("Корней нет!");
    }


    /*Написать программу, которая по вводимому числу от 1 до 
    11 (номеру класса) выдает соответствующее сообщение «Привет, 
    k-классник». Например, если k = 1, «Привет, первоклассник»; если 
    k = 4, «Привет, четвероклассник». */
    static void work_3()
    {
        Console.WriteLine("Напиши, в каком классе ты учишься?");
        string? str = null;
        switch (int.Parse(Console.ReadLine() ?? string.Empty))
        {
            case 1: str = "перво"; break;
            case 2: str = "второ"; break;
            case 3: str = "третье"; break;
            case 4: str = "четверо"; break;
            case 5: str = "пяти"; break;
            case 6: str = "шести"; break;
            case 7: str = "семи"; break;
            case 8: str = "восьми"; break;
            case 9: str = "девяти"; break;
            case 10: str = "десяти"; break;
            case 11: str = "одинадцати"; break;
            default: Console.WriteLine("Такого класса нет"); break;
        }
        if (str != null) Console.WriteLine($"Привет, {str}классник");
    }
    
    static BigInteger ToDegree(BigInteger num, int degree)
    {
        BigInteger date = num;
        for (int i = 1; i < degree; i++) num *= date;
        return num;
    }
    
    /*Показать, что для всех n = l, 2, 3, N
    15+25+…+n5+ 17+ 27+…+n7= 2(1+2+…n)4.*/
    static void work_4()
    {
        Console.WriteLine("Напиши значения числа n");
        int num = int.Parse(Console.ReadLine() ?? string.Empty);

        BigInteger sum1 = 0;
        BigInteger sum2 = 0;
        BigInteger sum3 = 0;

        for (int i = 1; i <= num; i++)
            sum1 += ToDegree(i, 5);

        for (int i = 1; i <= num; i++)
            sum2 += ToDegree(i, 7);

        for (int i = 1; i <= num; i++)
            sum3 += i;

        sum3 = ToDegree(sum3, 4);

        Console.WriteLine("Сумма левой части  = " + (sum1 + sum2));
        Console.WriteLine("Сумма правой части = " + 2 * sum3);
    }
}
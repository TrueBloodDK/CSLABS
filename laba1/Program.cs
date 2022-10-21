﻿using System.Numerics;


///////////////////////////////////////////////
///////////////////////////////////////////////


    BigInteger ToDegree(BigInteger num, int degree)
    {
        BigInteger date = num;

        for (int i = 1; i < degree; i++)
        {
            num *= date;
        }
        
        return num;
    }

    int ToInt(string str)
    {
        try
        {
            return Convert.ToInt32(str);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"This char is not a integer number! {e}");
            throw;
        }
    }

    double ToDouble(string str)
    {
        try
        {
            return Convert.ToDouble(str);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"This char is not a number! {e}");
            throw;
        }
    }


///////////////////////////////////////////////
//////////////////////////////////////////////
    
    /*Вычислите заданные формулы, все переменные вводятся с клавиатуры,
     результат печатается на экран. Для вычисления математических
      функций используются статические методы класса Math:*/
void work_1()
{
    Console.WriteLine("Напиши чему равен X:");
    var num = Console.ReadLine();
    int x = Convert.ToInt32(num);
    Console.WriteLine("Ответ: ");
    Console.Write((2 * (1 / System.Math.Tan(3 * x))) * (-1 * System.Math.Sqrt(x))
                  - 1 / (12 * (System.Math.Pow(x, 2)) + (7 * x) - 5));
}

    /* Даны действительные числа а, b, c (а > 0). Полностью исследовать
     биквадратное уравнение ax4+bx2+c=0*/
void work_2()
{
    Console.WriteLine("Нужно узнать числа a, b, c \nчему равно a?");
    double a = ToDouble(Console.ReadLine());
    Console.WriteLine("чему равно b?");
    double b = ToDouble(Console.ReadLine());
    Console.WriteLine("чему равно c?");
    double c = ToDouble(Console.ReadLine());

    double d = System.Math.Sqrt(b) - 4 * a * c;

    double x1=1 , x2=1 , x3=1 , x4=1 ;
    
    if (d>0)
    {
        double t1 = (-b - System.Math.Sqrt(d)) / (2 * a);
        double t2 = (-b + System.Math.Sqrt(d)) / (2 * a);

        if (t1 > t2) (t1, t2) = (t2, t1);
        if (t1>=0)
        { 
            x1 = System.Math.Sqrt(t1);
            x2 = -System.Math.Sqrt(t1);

        }
        
        if (t2>=0)
        {
            x3 = System.Math.Sqrt(t2);
            x4 = -System.Math.Sqrt(t2);
        }
        Console.WriteLine("Корни - " + x1 + " " + x2 + " " + x3 + " " + x4);
    }
    
    else if (d==0)
    {
        double t = -b / 2 * a;
        x1 = System.Math.Sqrt(-b/2*a);
        x2 = -System.Math.Sqrt(-b/2*a);
        Console.WriteLine("Корни - " + x1 + " " + x2);
    }

    else 
    {
        Console.WriteLine("Корней нет!");
    }
}

    /*Написать программу, которая по вводимому числу от 1 до 
    11 (номеру класса) выдает соответствующее сообщение «Привет, 
    k-классник». Например, если k = 1, «Привет, первоклассник»; если 
    k = 4, «Привет, четвероклассник». */
void work_3() {
    Console.WriteLine("Напиши, в каком классе ты учишься?");
    string str = null;
    switch (ToInt(Console.ReadLine()))
    {
        case 1: str = "перво"; break; case 2:  str = "второ"; break;
        case 3:  str = "третье"; break; case 4:  str = "четверо"; break;
        case 5:  str = "пяти"; break; case 6:  str = "шести"; break;
        case 7:  str = "семи"; break; case 8:  str = "восьми"; break;
        case 9:  str = "девяти"; break; case 10:  str = "десяти"; break;
        case 11:  str = "одинадцати"; break;
        default: Console.WriteLine("Такого класса нет"); break;
    }
    if (str != null)Console.WriteLine($"Привет, {str}классник");
}

    /*Показать, что для всех n = l, 2, 3, N
    15+25+…+n5+ 17+ 27+…+n7= 2(1+2+…n)4.*/
void work_4()
{
    Console.WriteLine("Напиши значения числа n");
    int num = ToInt(Console.ReadLine());

    BigInteger sum1 = 0;
    BigInteger sum2 = 0;
    BigInteger sum3 = 0;
 
      for (int i = 1; i <= num; i++)
      {
          sum1 += (BigInteger)ToDegree(i, 5);
      }
      
      for (int i = 1; i <= num; i++)
      {
          sum2 += (BigInteger)ToDegree(i, 7);
      }
      
      for (int i = 1; i <= num; i++)
      {
          sum3 += i;
      }

      sum3 = ToDegree(sum3, 4);
    
      
      Console.WriteLine("Сумма левой части  = " + (sum1 + sum2));
      Console.WriteLine("Сумма правой части = " + 2 * sum3);
}


///////////////////////////////////////////////
//////////////////////////////////////////////


    Dictionary<int, Action> Works = new Dictionary<int, Action>
    {
        [1] = work_1,
        [2] = work_2, 
        [3] = work_3,
        [4] = work_4,
    };
    Console.WriteLine("Какое задание делаем? (1 - 4)");
    int key = int.Parse(Console.ReadLine() ?? string.Empty);
    if (Works.ContainsKey(key)) Works[key]();
    else Console.WriteLine("Не такого задания");
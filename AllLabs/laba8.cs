﻿namespace AllLabs;
/*Задание. В соответствии с условием задачи Вы должны:
 Описать все необходимые классы, их поля и методы.
 Если по задаче имеет смысл, то используйте перегрузку операций.
 При необходимости вызывайте конструктор базового класса из конструктора
класса-потомка.
 Должны инициализироваться все поля каждого класса.
 Создайте программу, демонстрирующую работу с классами, не являющимися
абстрактными (абстрактные классы демонстрируются косвенно через
использование потомков). Демонстрация должна охватывать все реализованные
методы.
 Если в программе имеются виртуальные методы, то программы должна
демонстрировать их использование с помощью механизма позднего связывания.*/

/*Вариант 12 *. Создать класс математической функции одного аргумента,
определенной для всех вещественных чисел. Данный класс должен содержать
виртуальные методы печати функции, вычисления значения функции для данного
аргумента и вычисления объекта-функции, являющегося производной данной функции.
От класса математической функции с помощью наследования получить следующие
производные классы функций вида:
 F(x) = A * sin(B * x)
 G(x)= A * cos(B * x)
 Q(x) = A * x ^2 + B * x + C
 L(x) = A * x + B
 C(x) = A
В производных классах должны быть реализованы все виртуальные методы базового
класса. Также должны быть реализованы методы доступа к коэффициентам функций на
чтение и запись.*/


public class laba8
{
    public void Main()
    { 
        FunctionQx functions = new FunctionQx();

        Console.WriteLine("Чему равно A?");
            Functions.getA(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно B?");
            Functions.getB(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно C?");
            Functions.getC(double.Parse(Console.ReadLine()!));
        
        Console.WriteLine("Чему равно X?");
        double x = double.Parse(Console.ReadLine()!);

    }
}
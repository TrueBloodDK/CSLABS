﻿namespace AllLabs;

public class laba2
{
    
    double ToDegree(double num, double degree)
    {
        var date = num;
        while(Math.Abs(degree - 1.0) > 0.01f) { num *= date; degree--; }
        return num;
    }
    
    int ToInt(string? str)
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
    
    int[] FillArray(int size)
    {
        int[] ar = new int[size];
        for (var i = 0; i < ar.Length; i++) ar[i] = int.Parse(Console.ReadLine() ?? string.Empty);
        return ar;
    }
    
    int[] FillArrayWithRands(int size)
    {
        int[] ar = new int[size];
        for (var i = 0; i < ar.Length; i++) ar[i] = int.Parse(Console.ReadLine() ?? string.Empty);
        return ar;
    }
    
    string ArrayToString(IReadOnlyList<int> array)
    {
        return array.Aggregate("", (current, t) => current + (t + " "));
    }
    
    int[] SelectSort(int[] ar) {
        for (int i = 0; i < ar.Length; i++) {
           int indx = i; 
            for (int j = i+1; j < ar.Length; j++) {
                if (ar[j] > ar[indx]) indx = j;
            }
            if (ar[indx] == ar[i]) continue;
            (ar[i], ar[indx]) = (ar[indx], ar[i]);
        }
        return ar;
    }
    
///////////////////////////////////////////////
///////////////////////////////////////////////
        
    /*Использование циклов while и do-while*/
    void work_1() {
        Console.WriteLine("Введите чилсо n:");
        double n = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Введите чилсо эпсилон:");
        double eps = double.Parse(Console.ReadLine() ?? string.Empty);

        double sum = 0;
        while (Math.Abs(n - 0) > 0.01f) {
            Console.WriteLine($"n = {n} Уравнение = {1/ToDegree(2, n)+1/ToDegree(3, n)}");
            double equation = 1 / ToDegree(2, n) + 1 / ToDegree(3, n);
            if (equation >= eps) { sum += equation; }  n--;
        }
        Console.WriteLine($"Сумма = {sum}");
    }
    
    /*Натуральное число М называется совершенным,если оно равно сумме всех своих делителей,
     включая 1, но исключая себя. Напечатать все совершенные числа меньшие заданного числа N.*/
    void work_2() { 
        Console.WriteLine("Введите чилсо n:");
        var n = int.Parse(Console.ReadLine() ?? string.Empty);
      
        for ( int num = 2; num <= n; num++ ) {
            int del = 1, sum = 0;
            while (del < num) {
                if (num % del == 0) sum += del;
                del++;
            }
            if (sum == del) Console.Write($"{sum} ");
        }
    }

    /*Дана последовательность действительных чисел . Указать те ее
     элементы, которые принадлежат отрезку [с, d].*/
    void work_3() {
        Console.WriteLine("Введите кол-во чисел в массиве:");
        var array = FillArray(ToInt(Console.ReadLine()));
        Console.WriteLine($"{ArrayToString(array)} \nНапиши диапозон чисел от c до d \nc:");
        var a = ToInt(Console.ReadLine());
        Console.WriteLine("d:");
        var b = ToInt(Console.ReadLine());

        if (b > a) {
            foreach (var t in array) {
                if (t >= a && t <= b) Console.Write($"{t} ");
            }
        } 
        else Console.WriteLine("Неправильный диапозон");
    }

    /*Сортировка выбором.*/
    void work_4() { 
       Console.WriteLine("Введите кол-во чисел в массиве:");
       var array = FillArray(ToInt(Console.ReadLine()));
       Console.WriteLine(ArrayToString(array));
       for (int i = 0; i < array.Length; i++)
       {   int indx = i;
           for (int j = i + 1; j < array.Length; j++) { if (array[j] > array[indx]) indx = j; }
           if (array[indx] == array[i]) continue;
           (array[i], array[indx]) = (array[indx], array[i]); }
       Console.WriteLine($"Массив после сортировки\n{ArrayToString(array)}");
    }
    
    
///////////////////////////////////////////////
///////////////////////////////////////////////

    public void Main()
    {
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
        else Console.WriteLine("Нет такого задания");
    }
}
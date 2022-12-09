namespace AllLabs;

public class laba4
{
    /*Задан стек целых чисел. Для всех чисел
     подсчитать количество их вхождений в данный стек.*/
    void work_1()
    {
        Console.Write("Введите кол-во чисел и сами числа которые вы хотите поместить в стек:");
        Stack<int> stack = new Stack<int>();
        var a = int.Parse(Console.ReadLine()!);
        for (int i = 0; i <a; i++) 
            stack.Push(int.Parse(Console.ReadLine()!));

        while (stack.Count != 0)
        {
            Stack<int> stack2 = new Stack<int>();
            var current = stack.Peek();
            int sum = 0;
            while (stack.Count != 0)
            {
                if (stack.Peek() == current) sum++;
                else stack2.Push(stack.Peek());
                stack.Pop();
            }
            stack = stack2;
            Console.WriteLine($"{current} появился в стеке {sum} раз");
        }
    }

    /*Имеются две очереди целых чисел. Напишите программу, добавляющую
содержимое одной очереди в конец другой.*/
    void work_2()
    {
        Console.WriteLine("Введите кол-во элементов в 1-ой очереди и введите все элементы:");
        Queue<int> FirstQeueu = Funcs.FillNewQueue(int.Parse(Console.ReadLine()!));
        Console.WriteLine("Введите кол-во элементов в 2-ой очереди и введите все элементы:");
        Queue<int> SecondQeueu = Funcs.FillNewQueue(int.Parse(Console.ReadLine()!));

        Console.WriteLine("Вы хотите добавить: \n1)Вторую в конец первой\n2)Первую в конец второй");
        switch (int.Parse(Console.ReadLine()!))
        {   case 1:Funcs.UniteAndPrint(FirstQeueu, SecondQeueu);break; 
            case 2:Funcs.UniteAndPrint(SecondQeueu, FirstQeueu);break;
            default: Console.WriteLine("Нужно ввести 1 или 2"); break; }
    }
    
    
///////////////////////////////////////////////
///////////////////////////////////////////////

    public void Main()
    {
        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_1,
            [2] = work_2,
        };
        Console.WriteLine("Какое задание делаем? (1 - 2)");
        int key = int.Parse(Console.ReadLine() ?? string.Empty);
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Нет такого задания");
    }
}
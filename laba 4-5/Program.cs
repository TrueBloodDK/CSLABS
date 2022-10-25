namespace laba4;

class Program
{
    static void Main()
    {
        /*Задан стек целых чисел. Для всех чисел
     подсчитать количество их вхождений в данный стек.*/
        void work_4_1()
        {
            Console.Write("Введите кол-во чисел и сами числа которые вы хотите поместить в стек:");
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < Funcs.ToInt(Console.ReadLine()); i++) stack.Push(Funcs.ToInt(Console.ReadLine()));

            while (stack.Count != 0)
            {   Stack<int> stack2 = new Stack<int>();
                var current = stack.Peek();
                int sum = 0;
                while (stack.Count != 0)
                {   if (stack.Peek() == current) sum++;
                    else stack2.Push(stack.Peek());
                    stack.Pop(); }
                stack = stack2;
                Console.WriteLine($"{current} появился в стеке {sum} раз"); } }
        
        /*Имеются две очереди целых чисел. Напишите программу, добавляющую
    содержимое одной очереди в конец другой.*/
        void work_4_2() { 
            Console.WriteLine("Введите кол-во элементов в 1-ой очереди и введите все элементы:");
            Queue<int> FirstQeueu = Funcs.FillNewQueue(Funcs.ToInt(Console.ReadLine()));
            Console.WriteLine("Введите кол-во элементов в 2-ой очереди и введите все элементы:");
            Queue<int> SecondQeueu = Funcs.FillNewQueue(Funcs.ToInt(Console.ReadLine()));
            
            Console.WriteLine("Вы хотите добавить: \n1)Вторую в конец первой\n2)Первую в конец второй");
            switch (Funcs.ToInt(Console.ReadLine()))
            {   case 1: Funcs.UniteAndPrint(FirstQeueu, SecondQeueu); break; 
                case 2: Funcs.UniteAndPrint(SecondQeueu, FirstQeueu); break;
                default: Console.WriteLine("Нужно ввести 1 или 2"); break; } }

        /*Определить, есть ли среди заданной последовательности
    комплексных чисел два с равными модулями. Сравнение производить с
    точностью 10e-8 с помощью собственного класса сравнения.*/
        void work_5_1()
        {
            Console.WriteLine("К11");
            var lst = new List<string>()
            {
                "20+i24", "13+i10", "4+i5", "6+i1", "13+i10"
            };
            for (var j = 0; j < lst.Count; j++)
            {
                var cmp1 = new Complex();
                cmp1.ToComplex(lst[j]);
                for (var k = 0; k < lst.Count; k++)
                {
                    var cmp2 = new Complex();
                    cmp2.ToComplex(lst[k]);
                    if (cmp1.Abs() == cmp2.Abs() && j != k)
                    {
                        Console.Write("YEAH BITCH!");
                        return;
                    }
                }
            }
        }
        
        /*Дан файл целых чисел, содержащий более 50 элементов. Уменьшить его
    размер до 50 элементов, удалив из файла необходимое количество начальных элементов.*/
        void work_6_1()
        {
            Console.WriteLine("222");
        }

        /*Дан строковый файл, содержащий даты в формате «день/месяц/год», причем
    под день и месяц отводится по две позиции, а под год — четыре (например, «16/04/2001»).
    Создать два файла целых чисел, первый из которых содержит значения месяцев, а второй
    — значения лет для дат из исходного строкового файла (в обратном порядке).*/
        void work_6_2()
        {
            Console.WriteLine("222");
        }

        /*Дан файл вещественных чисел, содержащий ненулевую часть
    трехдиагональной матрицы (по строкам). Создать новый файл, содержащий все элементы
    данной матрицы (по строкам).*/
        void work_6_3()
        {
            Console.WriteLine("222");
        }

        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_4_1,
            [2] = work_4_2,
            [3] = work_5_1,
            [4] = work_6_1,
            [5] = work_6_2,
            [6] = work_6_3,
        };
        Console.WriteLine("Какое задание делаем?\n" + "1)4 лаба - задание 1\n" + "2)4 лаба - задание 2\n" +
                          "3)5 лаба - задание 1\n" + "5)6 лаба - задание 1\n" + "6)6 лаба - задание 2\n" +
                          "4)6 лаба - задание 3");
        int key = (Funcs.ToInt(Console.ReadLine()));
        if (Works.ContainsKey(key))Works[key]();
        else Console.WriteLine("Не такого задания");
    }
}
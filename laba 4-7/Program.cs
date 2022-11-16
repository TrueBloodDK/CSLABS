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
            for (int i = 0; i < int.Parse(Console.ReadLine()!); i++) stack.Push(int.Parse(Console.ReadLine()!));

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
        void work_4_2()
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

        /*Определить, есть ли среди заданной последовательности
    комплексных чисел два с равными модулями. Сравнение производить с
    точностью 10e-8 с помощью собственного класса сравнения.*/
        void work_5_1()
        {
            var lst = new List<string>()
            {
                "20+24i", "13+10i", "4+5i", "6+1i", "10+13i", "10+13i", "20+24i"
            };
            var lst_complex = lst.Select(x => new Complex(x)).ToArray();
            for (var i = 0; i < lst_complex.Count(); i++)
            {
                for (var j = i + 1; j < lst_complex.Count(); j++)
                {
                    if ((lst_complex[i].Abs() - lst_complex[j].Abs()) < 1e8) 
                        Console.WriteLine($"{lst_complex[i]} равен по модулю {lst_complex[j]}");
                }
            }

            for (var j = 0; j < lst_complex.Count(); j++)
            {
                Console.WriteLine($"{lst_complex[j]} модуль {lst_complex[j].Abs()}");
            }
        }

        /*Дан файл целых чисел, содержащий более 50 элементов. Уменьшить его
    размер до 50 элементов, удалив из файла необходимое количество начальных элементов.*/
        void work_6_1()
        {
            var text = "";
            using (StreamReader str = new StreamReader(path: "Test61.txt"))
            {
                text = str.ReadToEnd();
            }

            var lst = text.Split(" ").ToList();
            while (lst.Count > 6) lst.RemoveAt(0);
            text = lst.Aggregate("", (current, t) => current + (t + " "));
            using (StreamWriter streamWriter = new StreamWriter(path: "Test61.txt"))
            {
                streamWriter.Write(text);
            }
        }

        /*Дан строковый файл, содержащий даты в формате «день/месяц/год», причем
    под день и месяц отводится по две позиции, а под год — четыре (например, «16/04/2001»).
    Создать два файла целых чисел, первый из которых содержит значения месяцев, а второй
    — значения лет для дат из исходного строкового файла (в обратном порядке).*/
        void work_6_2()
        {
            List<string> lst;
            using (StreamReader streamReader = new StreamReader(path: "Test.txt"))
            {
                lst = streamReader.ReadToEnd().Split(" ").ToList();
            }

            var mounth = lst.Select(t => t.Split("/")[1]).ToList();
            var years = lst.Select(t => t.Split("/")[2]).ToList();
            years.Reverse();
            mounth.Reverse();
            
            using (StreamWriter streamWriter = new StreamWriter(path: "Mounths.txt"))
            {
                streamWriter.Write(mounth.Aggregate("", (current, t) => current + (t + " ")));
            }

            using (StreamWriter streamWriter = new StreamWriter(path: "Years.txt"))
            {
                streamWriter.Write(years.Aggregate("", (current, t) => current + (t + " ")));
            }
        }

        /*Дан файл вещественных чисел, содержащий ненулевую часть
    трехдиагональной матрицы (по строкам). Создать новый файл, содержащий все элементы
    данной матрицы (по строкам).*/
        void work_6_3()
        {
            Console.WriteLine("222");
        }

        void work_7_1()
        {
            Triangle tr = new Triangle(new[] { 0.0, 0.0 }, new[] { 5.0, 5.0 }, new[] { 10.0, 5.0 });
            tr.ShowTriangleData(tr);
            tr.Move(new[] { 10.0, 5.0 });
            tr.ShowTriangleData(tr);
            tr.Reflect();
            tr.ShowTriangleData(tr);
            tr.Rotate(Math.Cos(-1));
            tr.ShowTriangleData(tr);
        }

        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_4_1,
            [2] = work_4_2,
            [3] = work_5_1,
            [4] = work_6_1,                                                                                                                                                                                                                                                                                                                         
            [5] = work_6_2,
            [6] = work_6_3,
            [7] = work_7_1,
        };
        Console.WriteLine("Какое задание делаем?\n" + "1)4 лаба - задание 1\n" + "2)4 лаба - задание 2\n" +
                          "3)5 лаба - задание 1\n" + "4)6 лаба - задание 1\n" + "5)6 лаба - задание 2\n" +
                          "6)6 лаба - задание 3\n" + "7)6 лаба - задание 1");
        int key = (int.Parse(Console.ReadLine()!));
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Не такого задания");
    }
}
namespace AllLabs;

public class laba6
{
    /*Дан файл целых чисел, содержащий более 50 элементов. Уменьшить его
    размер до 50 элементов, удалив из файла необходимое количество начальных элементов.*/
        void work_1()
        {
            var text = "";
            using (StreamReader str = new StreamReader(path: "Test61.txt"))
                text = str.ReadToEnd();

            var lst = text.Split(" ").ToList();
            while (lst.Count > 50) lst.RemoveAt(0);
            text = lst.Aggregate("", (current, t) => current + (t + " "));
            using (StreamWriter streamWriter = new StreamWriter(path: "Test61.txt"))
                streamWriter.Write(text);
            
            Console.WriteLine("Готова!");
        }

        /*Дан строковый файл, содержащий даты в формате «день/месяц/год», причем
    под день и месяц отводится по две позиции, а под год — четыре (например, «16/04/2001»).
    Создать два файла целых чисел, первый из которых содержит значения месяцев, а второй
    — значения лет для дат из исходного строкового файла (в обратном порядке).*/
        void work_2()
        {
            List<string> lst;
            using (StreamReader streamReader = new StreamReader(path: "Test.txt"))
                lst = streamReader.ReadToEnd().Split(" ").ToList();
            
            var mounth = lst.Select(t => t.Split("/")[1]).ToList();
            var years = lst.Select(t => t.Split("/")[2]).ToList();
            years.Reverse();
            mounth.Reverse();
            
            using (StreamWriter streamWriter = new StreamWriter(path: "Mounths.txt"))
                streamWriter.Write(mounth.Aggregate("", (current, t) => current + (t + " ")));
            

            using (StreamWriter streamWriter = new StreamWriter(path: "Years.txt")) 
                streamWriter.Write(years.Aggregate("", (current, t) => current + (t + " ")));
        }

        /*Дан файл вещественных чисел, содержащий ненулевую часть
    трехдиагональной матрицы (по строкам). Создать новый файл, содержащий все элементы
    данной матрицы (по строкам).*/
        void work_3()
        {
            List<string> lst;
            using (StreamReader streamReader = new StreamReader(path: "Matrix63.txt")) 
                lst = streamReader.ReadToEnd().Split(" ").ToList();
            foreach (var i in lst)
            {
                Console.Write($"{i} ");
            }
        }
        
     /*
        1 2 
        3 5 1 
        1 1 1 
        1 1 1 
        1 1 1 
        1 1 1 
        1 1 1 
        1 1 1 
        1 1 1 
        1 1 
        */

    
///////////////////////////////////////////////
///////////////////////////////////////////////

    public void Main()
    {
        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = work_1,
            [2] = work_2,
            [3] = work_3,
        };
        Console.WriteLine("Какое задание делаем? (1 - 3)");
        int key = int.Parse(Console.ReadLine() ?? string.Empty);
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Нет такого задания");
    }
}
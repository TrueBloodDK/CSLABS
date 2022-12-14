namespace AllLabs;

public class laba3
{
/*Определить номера строк матрицы,
 в которых знаки элементов чередуются.*/
    void work_1()
    {
        Console.WriteLine("Введите кол-во строк и столбцов");
        var matrix = Funcs.FillDoubleArrayOfInts(int.Parse(Console.ReadLine() ?? string.Empty), int.Parse(Console.ReadLine() ?? string.Empty));
        Console.WriteLine(Funcs.DoubleArrayToString(matrix));

        Console.Write("Строки с чередующимися знаками: ");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 1;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < 0 && matrix[i, j + 1] > 0 || matrix[i, j] > 0 && matrix[i, j + 1] < 0)
                {
                    sum++;
                }
            }

            if (sum == matrix.GetLength(1)) Console.Write($"{i + 1} ");
        }
    }

/*В заданной строке заменить все
 знаки препинания на пробелы.*/
    void work_2()
    {
        //Привет. Меня зовут Вова, обычный русский парен... И я русский! %"№№???... .. . ...!! fa
        Console.WriteLine("Введите текст который вы хотите изменить");
        string? str = Console.ReadLine();
        List<string> lst = new List<string>()
            { "!", ",", ".", "?", };
        foreach (string i in lst) str = str?.Replace(i, " ");
        Console.WriteLine(str);
    }

/*Тэг курсива. Дан текст, в котором встречаются структуры <i> и </i>. Заменить 
 каждое вхождение <i> на <курсив>, а каждое вхождение </i> на <конец курсива>. Замечание. 
 В программе следует учесть, что буква i может  быть как строчной, так и прописной.*/
    void work_3()
    {
        Console.WriteLine("Введите текст который вы хотите изменить");
        string? str = Console.ReadLine();
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            { "<i>", "<курсив>" },
            { "<I>", "<курсив>" },
            { "</i>", "<конец курсива>" },
            { "</I>", "<конец курсива>" },
        };
        foreach (string i in dic.Keys)
            str = str?.Replace(i, dic[i]);
        Console.WriteLine(str);
    }


///////////////////////////////////////////////
///////////////////////////////////////////////
    public void Main()
    { Dictionary<int, Action> Works = new Dictionary<int, Action>
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
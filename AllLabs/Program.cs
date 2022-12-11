namespace AllLabs;

class Program
{
    static void Main()
    {
        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = new AllLabs.laba1().Main,
            [2] = new AllLabs.laba2().Main,
            [3] = new AllLabs.laba3().Main,
            [4] = new AllLabs.laba4().Main,
            [5] = new AllLabs.laba5().Main,
            [6] = new AllLabs.laba6().Main,
            [7] = new AllLabs.laba7().Main,
            [8] = new AllLabs.laba8().Main,
        };
        Console.WriteLine("Какую лабу делаем? (1-8)");
        int key = (int.Parse(Console.ReadLine()!));
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Не такого задания");
    }
}
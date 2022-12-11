namespace AllLabs;

static class Program
{
    static void Main()
    {
        Dictionary<int, Action> Works = new Dictionary<int, Action>
        {
            [1] = new laba1().Main,
            [2] = new laba2().Main,
            [3] = new laba3().Main,
            [4] = new laba4().Main,
            [5] = new laba5().Main,
            [6] = new laba6().Main,
            [7] = new laba7().Main,
            [8] = new laba8().Main,
        };
        Console.WriteLine("Какую лабу делаем? (1-8)");
        int key = (int.Parse(Console.ReadLine()!));
        if (Works.ContainsKey(key)) Works[key]();
        else Console.WriteLine("Нет такой лабы");
    }
}
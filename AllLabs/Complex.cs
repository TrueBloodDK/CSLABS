namespace AllLabs;

public class Complex
{
    private float firstPart { get; set; }
    private float secondPart { get; set; }

    public Complex()
    {
        firstPart = 0;
        secondPart = 0;
    }

    public Complex(string number)
    {
        firstPart = int.Parse(number.Split("+")[0]);
        secondPart = int.Parse(number.Split("+")[1][..^1]);
    }

    public override string ToString() => firstPart.ToString() +
                                         (secondPart >= 0 ? ($"+{secondPart.ToString()}") : secondPart.ToString()) +
                                         "i";

    public double Abs()
    {
        return Math.Sqrt(firstPart * firstPart + secondPart * secondPart);
    }

    public static Complex operator +(Complex obj1, Complex obj2)
    {
        var cmp = new Complex
        {
            firstPart = obj1.firstPart + obj2.firstPart,
            secondPart = obj1.secondPart + obj2.secondPart
        };
        return cmp;
    }

    public static Complex operator -(Complex obj1, Complex obj2)
    {
        var cmp = new Complex
        {
            firstPart = obj1.firstPart - obj2.firstPart,
            secondPart = obj1.secondPart - obj2.secondPart
        };
        return cmp;
    }
}
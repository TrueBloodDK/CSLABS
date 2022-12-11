namespace AllLabs;


class Functions
{
    protected static double A { get; private set; }
    protected static double B { get; private set; }
    protected static double C { get; private set; }

    public static void getA(double value)
    {
        A = value;
    }
    
    public static void getB(double value)
    {
        B = value;
    }
    
    public static void getC(double value)
    {
        C = value;
    }

    protected virtual double GetFunction(double x)
    {
        return x;
    }
}

sealed class FunctionQx : Functions
{
    protected override double GetFunction(double x)
    {
        return A*(Math.Pow(x, 2) + B*x + C);
    }
}

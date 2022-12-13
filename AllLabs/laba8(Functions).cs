namespace AllLabs;


abstract class Functions
{
    protected static double A { get; private set; }
    protected static double B { get; private set; }
    protected static double C { get; private set; }

    public static void getA(double value) => A = value;
    
    public static void getB(double value) => B = value;
    
    public static void getC(double value) => C = value;
    
    public abstract double GetFunc(double x); //Вычисление функции
    public abstract void PrintFunc(double x); //Печать функции
}
class FunctionFx : Functions
{
    public override double GetFunc(double x) => A * (Math.Sin(B * x));
    
    public override void PrintFunc(double x)
    { Console.WriteLine($"F(x) = {GetFunc(x)}"); }
}

class FunctionGx : Functions
{
    public override double GetFunc(double x) => A * (Math.Cos(B * x));
    
    public override void PrintFunc(double x)
    { Console.WriteLine($"G(x) = {GetFunc(x)}"); }
}


class FunctionQx : Functions
{
    public override double GetFunc(double x) => A*(Math.Pow(x, 2) + (B *x) + C);

    public override void PrintFunc(double x)
    { Console.WriteLine($"Q(x) = {GetFunc(x)}"); }
}

class FunctionLx : Functions
{
    public override double GetFunc(double x) => A*x + B;

    public override void PrintFunc(double x)
    { Console.WriteLine($"L(x) = {GetFunc(x)}"); }
}

class FunctionCx : Functions
{
    public override double GetFunc(double x) => A;
    
    public override void PrintFunc(double x)
    { Console.WriteLine($"C(x) = {GetFunc(x)}"); }
}

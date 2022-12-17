namespace AllLabs;


abstract class Functions
{
  //  protected double[] koef = {};
  protected static double A { get; private set; }
  protected static double B { get; private set; }
  protected static double C { get; private set; }

  protected static void getA(double value) => A = value;

  protected static void getB(double value) => B = value;

  protected static void getC(double value) => C = value;

  public abstract void ReadFunction();
    public abstract double GetFunc(double x); //Вычисление функции
    public abstract double GetDerFunc(double x); //Вычисление функции
    public abstract void PrintFunc(double x); //Печать функции
/*
    public Functions getA(double value, int functions)
    {
        return functions switch {
            1 => new FunctionCx() {
                A = value
            },
            
            2 => new FunctionFx() {
                A = value
            },
            
            3 => new FunctionGx() {
                A = value
            },
            
            4 => new FunctionLx() {
                A = value
            },
            
            5 => new FunctionQx() {
                A = value
            }
        };
    }*/
}
class FunctionFx : Functions
{
    public override void ReadFunction()
    {
        Console.WriteLine("Чему равно A?");
            Functions.getA(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно B?");
            Functions.getB(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно X?");
            double x = double.Parse(Console.ReadLine()!);
        PrintFunc(x);
    }
    
    public override double GetFunc(double x) => A * (Math.Sin(B * x));
    
    public override double GetDerFunc(double x) => A * B * (Math.Cos(B * x));

    public override void PrintFunc(double x)
    {
        Console.WriteLine($"F(x) = {A} * sin({B} * x) = {GetFunc(x)}");
        Console.WriteLine($"F'(x) = {A} * cos({B} * x) = {GetDerFunc(x)}");
    }
}

class FunctionGx : Functions
{
    public override void ReadFunction()
    {
        Console.WriteLine("Чему равно A?"); 
            Functions.getA(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно B?");
            Functions.getB(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно X?");
            double x = double.Parse(Console.ReadLine()!);
        PrintFunc(x);
    }
    
    public override double GetFunc(double x) => A * (Math.Cos(B * x));
    
    public override double GetDerFunc(double x) => -A * B * (Math.Sin(B * x));

    public override void PrintFunc(double x)
    {
        Console.WriteLine($"G(x) = {A} * cos({B} * x) = {GetFunc(x)}");
        Console.WriteLine($"G'(x) = -({A}) * sin({B} * x) = {GetDerFunc(x)}");
    }
}


class FunctionQx : Functions
{
    public override void ReadFunction()
    {
        Console.WriteLine("Чему равно A?"); 
            Functions.getA(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно B?");
            Functions.getB(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно C?");
            Functions.getC(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно X?");
            double x = double.Parse(Console.ReadLine()!);
        PrintFunc(x);
    }
    
    public override double GetFunc(double x) => A*(Math.Pow(x, 2) + (B *x) + C);

    public override double GetDerFunc(double x) => 2*A*x + B;

    public override void PrintFunc(double x)
    {
        Console.WriteLine($"Q(x) = {A}*x^2 + {B}x + {C}) = {GetFunc(x)}");
        Console.WriteLine($"Q'(x) = {2*A}x + {B} = {GetDerFunc(x)}");
    }
}

class FunctionLx : Functions
{
    public override void ReadFunction()
    {
        Console.WriteLine("Чему равно A?"); 
            Functions.getA(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно B?");
            Functions.getB(double.Parse(Console.ReadLine()!));
        Console.WriteLine("Чему равно X?");
            double x = double.Parse(Console.ReadLine()!);
        PrintFunc(x);
    }
    
    public override double GetFunc(double x) => A*x + B;
    
    public override double GetDerFunc(double x) => A;

    public override void PrintFunc(double x)
    {
        Console.WriteLine($"L(x) = {A}x + {B} = {GetFunc(x)}");
        Console.WriteLine($"L'(x) = A = {GetDerFunc(x)}");
    }
}

class FunctionCx : Functions
{
    public override void ReadFunction()
    {
        Console.WriteLine("Чему равно A?"); 
        Functions.getA(double.Parse(Console.ReadLine()!));
        PrintFunc();
    }

    private void PrintFunc()
    {
        Console.WriteLine($"C(x) = {A} = {GetFunc()}");
        Console.WriteLine($"C'(x) = 0 = {GetDerFunc()}");
    }

    private static double GetFunc() => A;

    public override double GetFunc(double x) => A;

    private static double GetDerFunc() => 0;

    public override double GetDerFunc(double x) => 0;

    public override void PrintFunc(double x)
    {
        Console.WriteLine($"C(x) = {GetFunc(x)}");
        Console.WriteLine($"C'(x) = {GetDerFunc(x)}");
    }
}

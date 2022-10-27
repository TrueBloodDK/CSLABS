namespace laba4;

public class Triangle
{
    private double[] A { get; set; }
    private double[] B { get; set; }
    private double[] C { get; set; }
    public double Perimeter { get; set; }
    public double Square { get; set; }

    public string GetCoordinate(int cord) {
        return cord switch {
            0 => A[0] + "; " + A[1],
            1 => B[0] + "; " + B[1],
            2 => C[0] + "; " + C[1],
            _ => "Error!"
        };
    }

    public void Reflect() {
        A[0] = -A[0];
        A[1] = -A[1];
            B[0] = -B[0];
            B[1] = -B[1];
                C[0] = -C[0];
                C[1] = -C[1];
    }
    public Triangle() {
        A = Array.Empty<double>();
        B = Array.Empty<double>();
        C = Array.Empty<double>();
        Perimeter = 0;
        Square = 0;
    }

    public Triangle(double[] x, double[] y, double[] z) { //12∣∣(0Y−0X)(1Z−1X)−(0Z−0X)(1Y−1X)∣∣
        A = x;
        B = y;
        C = z;
        Perimeter = GetPerimetr(A,B,C);
        Square = GetSquare(A, B, C);
    }

    private static double GetPerimetr(IReadOnlyList<double> x, IReadOnlyList<double> y, IReadOnlyList<double> z) {
        var ans = Math.Pow (Math.Pow (x[0] - y[0] , 2) + Math.Pow (x[1] - y[1] , 2), 0.5);
        ans += Math.Pow (Math.Pow (y[0] - z[0] , 2) + Math.Pow (y[1] - z[1] , 2), 0.5);
        ans += Math.Pow (Math.Pow (z[0] - x[0] , 2) + Math.Pow (z[1] - x[1] , 2), 0.5);
        return ans;
    }

    private static double GetSquare(IReadOnlyList<double> x, IReadOnlyList<double> y, IReadOnlyList<double> z) {
        return (1.0 / 2.0) * Math.Abs((y[0] - x[0]) * (z[1] - x[1]) - (z[0] - x[0]) * (y[1] - x[1]));
    }

    public void Move(double[] vector) {
        A[0] += vector[0];
        A[1] += vector[1];
            B[0] += vector[0];
            B[1] += vector[1];
                C[0] += vector[0];
                C[1] += vector[1];
    }

    public void Rotate(double angle) {
        var x = A;
        A[0] = x[0] * Math.Cos(angle) - x[1] * Math.Sin(angle);
        A[1] = x[0] * Math.Sin(angle) - x[1] * Math.Cos(angle);
        x = B;
        B[0] = x[0] * Math.Cos(angle) - x[1] * Math.Sin(angle);
        B[1] = x[0] * Math.Sin(angle) - x[1] * Math.Cos(angle);
        x = C;
        C[0] = x[0] * Math.Cos(angle) - x[1] * Math.Sin(angle);
        C[1] = x[0] * Math.Sin(angle) - x[1] * Math.Cos(angle);
    }
}
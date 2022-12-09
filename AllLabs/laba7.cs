namespace AllLabs;

public class laba7
{
    /*Определить, есть ли среди заданной последовательности
   комплексных чисел два с равными модулями. Сравнение производить с
   точностью 10e-8 с помощью собственного класса сравнения.*/
    public void Main()
    {
        {
            Triangle tr = new Triangle(new[] { 0.0, 0.0 }, new[] { 5.0, 5.0 }, new[] { 10.0, 5.0 });
            tr.ShowTriangleData(tr);
            tr.Move(new[] { 10.0, 5.0 });
            tr.ShowTriangleData(tr);
            tr.ReflectByX();
            tr.ShowTriangleData(tr);
            tr.ReflectByY();
            tr.ShowTriangleData(tr);
            tr.Rotate(50);
            tr.ShowTriangleData(tr);
        }
    }
}
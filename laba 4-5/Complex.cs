namespace laba4;

public class Complex {
    private float firstPart { get; set; }
    private float secondPart { get; set; }
    public string View { get; set; }
    public Complex() {
        firstPart = 0;
        secondPart = 0;
    }
    public void ToComplex(string number) {
        View = number;
        firstPart = int.Parse( number.Split("+")[0]); 
        secondPart = int.Parse( number.Split("+")[1][..1]);
    }

    public float Abs() {
        return (float)Math.Sqrt(Math.Pow(firstPart, 2) + Math.Pow(secondPart, 2));
    }
    
    public static Complex operator +(Complex obj1, Complex obj2) {
        var cmp = new Complex {
            firstPart = obj1.firstPart + obj2.firstPart,
            secondPart = obj1.secondPart + obj2.secondPart
        };
        return cmp;
    }
    public static Complex operator -(Complex obj1, Complex obj2) {
        var cmp = new Complex {
            firstPart = obj1.firstPart - obj2.firstPart,
            secondPart = obj1.secondPart - obj2.secondPart
        };
        return cmp;
    }
    
}
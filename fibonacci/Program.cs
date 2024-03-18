namespace fibonacci;

public class Main {
    public static bool isPerfectSquare(int num) {
        double squareRoot = Math.Round(Math.Sqrt(num));

        return squareRoot * squareRoot == num;
    }
}
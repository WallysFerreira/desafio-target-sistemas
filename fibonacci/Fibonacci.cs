namespace fibonacci;

public class Fibonacci {
    public static bool isPerfectSquare(int num) {
        double squareRoot = Math.Round(Math.Sqrt(num));

        return squareRoot * squareRoot == num;
    }

    public static bool isFibonacci(int num) {
        return isPerfectSquare(5 * num * num + 4) || isPerfectSquare(5 * num * num - 4);
    }
}
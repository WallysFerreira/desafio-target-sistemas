namespace fibonacci;

public class ProgramTest {
    [Fact]
    public void PerfectSquareTest() {
        int[] perfectSquareNumbers = [0, 1, 4, 9, 16, 25];
        Assert.All(perfectSquareNumbers, num => Assert.True(Fibonacci.isPerfectSquare(num)));
    }

    [Fact]
    public void NotPerfectSquareTest() {
        int[] notPerfectSquareNumbers = [2, 3, 5, 6, 17, 23];
        Assert.All(notPerfectSquareNumbers, num => Assert.False(Fibonacci.isPerfectSquare(num)));
    }

    [Fact]
    public void IsFibonacciTest() {
        int[] fibonacciNumbers = [0, 1, 2, 3, 5, 8, 13, 21, 34];
        Assert.All(fibonacciNumbers, num => Assert.True(Fibonacci.isFibonacci(num)));
    }

    [Fact]
    public void NotFibonacciTest() {
        int[] notFibonacciNumbers = [4, 6, 9, 11, 12, 18, 25, 38];
        Assert.All(notFibonacciNumbers, num => Assert.False(Fibonacci.isFibonacci(num)));
    }
}
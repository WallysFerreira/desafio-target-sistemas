namespace fibonacci;

public class ProgramTest {
    [Fact]
    public void PerfectSquareTest() {
        int[] perfectSquareNumbers = [0, 1, 4, 9, 16, 25];

        Assert.All(perfectSquareNumbers, num => Assert.True(Main.isPerfectSquare(num)));
    }

    [Fact]
    public void NotPerfectSquareTest() {
        int[] notPerfectSquareNumbers = [2, 3, 5, 6, 17, 23];
        Assert.All(notPerfectSquareNumbers, num => Assert.False(Main.isPerfectSquare(num)));
    }
}
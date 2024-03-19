namespace string_reverser;

public class ReverserTest {
    [Fact]
    public void ReverseWordTest() {
        string expected = "odnatseT";
        string got = Reverser.reverse("Testando");

        Assert.Equal(expected, got);
    }

    [Fact]
    public void ReversePhraseTest() {
        string expected = ".odnatset ,sêrt siod mU";
        string got = Reverser.reverse("Um dois três, testando.");

        Assert.Equal(expected, got);
    }
}
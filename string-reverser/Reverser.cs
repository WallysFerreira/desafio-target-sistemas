namespace string_reverser;

public class Reverser {
    public static string reverse(string s) {
        string newString = "";

        for (int i = s.Length - 1; i >= 0; i--) {
            newString += s[i];
        } 

        return newString;
    }
}

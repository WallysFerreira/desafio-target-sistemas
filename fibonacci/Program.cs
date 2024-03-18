using fibonacci;

Start:
Console.Write("Digite o número para checar: ");

int? num = null;
string userAnswer = Console.ReadLine()!;

try {
    num = int.Parse(userAnswer!);
} catch {}

if (num != null) {
    Console.WriteLine("{0} {1} parte da sequência de Fibonacci", num, Fibonacci.isFibonacci(num) ? "faz" : "não faz");
} else {
    Console.WriteLine("Digite um número válido");
    goto Start;
}
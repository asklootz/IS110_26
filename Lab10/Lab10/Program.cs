using Lab10;

var calc = new Calculator();
double result = 0;

Console.WriteLine("Vennligst gi verdi til tall 1");
int verdi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst gi verdi til tall 2");
int verdi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst velg en operasjon");
string op = Console.ReadLine();

if (op == "+")
{
    result = calc.AddNumbers(verdi1, verdi2);
}
else if (op == "-")
{
    result = calc.SubtractNumbers(verdi1, verdi2);
}
else if (op == "*")
{
    result = calc.MultiplyNumbers(verdi1, verdi2);
}
else if (op == "/")
{
    result = calc.DivideNumbers(verdi1, verdi2);
}

Console.WriteLine($"Resultatet er: {result}");
using Calculadora.Services;

CalculadoraImplementação c = new CalculadoraImplementação();

int num1 = 4;
int num2 = 9;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {c.Subtrair(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {c.Multiplicar(num1, num2)}");
Console.WriteLine($"{num1} / {num2} = {c.Dividir(num1, num2)}");
double num1, num2;
string op;

Console.WriteLine("Calculadora simples");
Console.WriteLine("Insira um dos operadores (+) , (-), (*), (/), (^), (raiz)");

Console.WriteLine("Enter a number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Operator: ");
op = Console.ReadLine();

if (op == "raiz" || op == "RAIZ") 
{
    Console.WriteLine(Math.Sqrt(num1));
    Console.ReadLine();
    
}
Console.WriteLine("Enter a number: ");
num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+")
{

    Console.WriteLine(num1 + num2);
}
else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (op == "*")
{
    Console.WriteLine(num1 * num2);
}
else if (op == "/")
{
    Console.WriteLine(num1 / num2);
}
else if (op == "^")
{
    Console.WriteLine(Math.Pow(num1, num2));
}
else 
{ 
    Console.WriteLine("Operador inválido: ERRO ");
}

Console.ReadLine();

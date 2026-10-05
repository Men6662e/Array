// Home Work 3 
//ex.1

Console.WriteLine("==  Калькулятор == ");
Console.WriteLine("Введите первое число!");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double twoNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите символ одного из четырёх значений: +, -, *, /.");
string symbol = Console.ReadLine();

switch(symbol)
{
    case "+":
            Console.WriteLine($"Результат:{firstNumber} + {twoNumber} = {firstNumber + twoNumber}");
        break;
    case "-":
        Console.WriteLine($"Результат:{firstNumber} - {twoNumber} = {firstNumber - twoNumber}");
        break;
    case "*":
        Console.WriteLine($"Результат:{firstNumber} * {twoNumber} = {firstNumber * twoNumber}");
        break;
    case "/":
        Console.WriteLine($"Результат:{firstNumber} / {twoNumber} = {firstNumber / twoNumber}");
        break;
    default: Console.WriteLine("Вы ввели недопустимый символ"); break;
}
Console.ReadLine();
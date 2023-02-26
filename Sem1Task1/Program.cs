// задача 1
// написать программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго

// считываем данные с консоли 1 число команду можно скопировать
// из задачи Sem1Task0
string? inputNum1 = Console.ReadLine();
// считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

// проверяем, чтобы данные были не пустыми
if (inputNum1!=null && inputNum2!=null)
{
    // парсим введённое число
    int number = int.Parse(inputNum1);
    //  парсим введённое число
    int number = int.Parse(inputNum2);

    if(number1==number2*number2)
    {
    Console.WriteLine("первое число квадрат второго");
    }
    else
    {
    Console.WriteLine("первое число не квадрат второго!");
    }
    

}

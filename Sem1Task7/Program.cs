// Задача 7
// считываем данные с консоли
string? inputNumLine = Console.ReadLine();
// проверяем чтобы данные небыли пустыми
if (inputNumLine != null)
{
    // парсим введённое число
    int inputNumberA = int.Parse(inputNumLine);
    int LastDigit = inputNumberA % 10;

    Console.WriteLine(LastDigit);
}

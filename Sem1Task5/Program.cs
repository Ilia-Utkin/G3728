// Задача 5 программа приниает число, а на выход выдаёт все
// целые числа от минус введённое число до плюс введённое число.

// считываем данные с консоли
string? inputNumLine = Console.ReadLine();
// проверяем чтобы данные небыли пустыми
if(inputNumLine!=null)
{
    // парсим введённое число
    int inputNumberA = int.Parse(inputNumLine);
    // вводим промежуточное значение
    int inputNumberC = inputNumberA*(-1);
    // выходные значения
    string outNumLine = string.Empty;
    // 
    while(inputNumberC < inputNumberA)
    {
        outNumLine = outNumLine + inputNumberC + ",";
        inputNumberC = inputNumberC + 1;
    } 
    outNumLine = outNumLine + inputNumberA;
    Console.WriteLine(outNumLine);
}
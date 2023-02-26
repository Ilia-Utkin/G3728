// считываем данные с консоли
string? inputLine = Console.ReadLine();
// проверяем чтобы данные небыли пустыми
if(inputLine!=null)
{
    // создаём массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0]= "понедельник";
    dayOfWeek[1]= "вторник";
    dayOfWeek[2]= "среда";
    dayOfWeek[3]= "четверн";
    dayOfWeek[4]= "пятница";
    dayOfWeek[5]= "суббота";
    dayOfWeek[6]= "воскресенье";
    // парсим введённое число
    int inputNumber = int.Parse(inputLine);
    // находим назвение дня недели по введённому номеру
    string outDayofWeek = dayOfWeek[inputNumber-1];
    //  выводим данные на консоль
    Console.WriteLine(outDayofWeek); 
    }

// // Вводим массив из строк,
Console.Write("Enter string after shift: ");

string? str = Console.ReadLine();                       // вводим строку
var array = str.Split(" ");                             // строку делим по пробелу
string[] arrayStr = new string [array.Length];          // объявление и инициализация массива

for (int i = 0; i < array.Length; i++)                  // Сгенерировали массив
{
    arrayStr[i] = Convert.ToString(array[i]);
}

Console.Write("Massive: ");                                                 

foreach (var item in arrayStr)                          // Вывели массив
{
    Console.Write(" " + item);
}

Console.WriteLine();

int t = 3;                                                                              // Длина искомых эле-ов массива
string[] findSomeNumb = Array.FindAll(arrayStr, strings => strings.Length <= t );       // объявление и инициализация массива


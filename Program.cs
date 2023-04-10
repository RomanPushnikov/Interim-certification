// // Вводим массив из строк,
Console.Write("Enter string after shift: ");

string? str = Console.ReadLine();                       // вводим строку
var array = str.Split(" ");                             // строку делим по пробелу
string[] arrayStr = new string [array.Length];          // объявление и инициализация массива

for (int i = 0; i < array.Length; i++)                  // Сгенерировали массив
{
    arrayStr[i] = Convert.ToString(array[i]);
}


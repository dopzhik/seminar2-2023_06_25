// Напишите программу, которая будет принимать на вход пять чисел и 
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4
int ReadInt(string message)
{
    System.Console.Write(message);              // Выводим в консоль приглашение для ввода
    string inputedStr = Console.ReadLine();     // Вводим строку с консоли
    int number = Convert.ToInt32(inputedStr);   // Преобразует строку в целое значение
    return number;                              // Возвращает из функции значение
}
int number1 = ReadInt("Введите первое число => ");
int number2 = ReadInt("Введите второе число => ");
int number3 = ReadInt("Введите третье число => ");
int number4 = ReadInt("Введите четвертое число => ");
int number5 = ReadInt("Введите пятое число => ");
int sum = number1 + number2 + number3 + number4 + number5;
double aver = sum/5.0;
System.Console.WriteLine($"Сумма чисел равна {sum}, Среднее арифметическое равно {aver}");
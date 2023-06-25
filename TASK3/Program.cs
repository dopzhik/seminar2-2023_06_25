// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int ReadInt(string message)
{
    System.Console.Write(message);              // Выводим в консоль приглашение для ввода
    string inputedStr = Console.ReadLine();     // Вводим строку с консоли
    int number = Convert.ToInt32(inputedStr);   // Преобразует строку в целое значение
    return number;                              // Возвращает из функции значение
}
int number1 = ReadInt("Введите первое число => ");
int number2 = ReadInt("Введите второе число => ");
int digit = number1 % number2;
if (digit == 0)
{
    System.Console.WriteLine("Первое число кратно второму");
}
else
{
     System.Console.WriteLine($"Первое число не кратно второму, остаток от деления {digit}");
}
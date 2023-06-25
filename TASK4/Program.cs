// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
int ReadInt(string message)
{
    System.Console.Write(message);              // Выводим в консоль приглашение для ввода
    string inputedStr = Console.ReadLine();     // Вводим строку с консоли
    int number = Convert.ToInt32(inputedStr);   // Преобразует строку в целое значение
    return number;                              // Возвращает из функции значение
}
int number1 = ReadInt("Введите число => ");
if (number1 % 7 == 0 && number1 % 23 == 0)
{
    System.Console.WriteLine($"Число {number1} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number1} не кратно 7 и 23");
}
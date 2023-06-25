/* 4.1. Напишите программу, которая генерирует несколько случайных чисел,
 и в цикле проверяет, кратны ли эти числа предварительно введенному числу, 
 при кратности - цикл прерывается.
Введенное число 2
13 -> нет 
15 -> нет 
12 -> да*/
int ReadInt(string message)
{
    System.Console.Write(message);              // Выводим в консоль приглашение для ввода
    string inputedStr = Console.ReadLine();     // Вводим строку с консоли
    int number = Convert.ToInt32(inputedStr);   // Преобразует строку в целое значение
    return number;                              // Возвращает из функции значение
}
int number1 = ReadInt("Введите число => ");
while (true)
{
    int value = new Random().Next(0, 100);
    System.Console.Write(value);
    if (value % number1 == 0)
    {
        System.Console.WriteLine(" кратно");
        break;
    }
    System.Console.WriteLine(" не кратно");
}
// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
int num = new Random().Next(10, 100);
int digit1 = num / 10;
int digit2 = num % 10;
if (digit1 > digit2)
{
    WriteMessage(num, digit1);
}
else
{
    WriteMessage(num, digit2);
}

void WriteMessage(int num, int digit)
{
    System.Console.WriteLine($"Максимальная цифра числа {num} равна {digit}");
}
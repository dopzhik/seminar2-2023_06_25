// 2.1. Напишите программу, которая выводит случайное число из 
// отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
// 1213-> 3 
// 845 -> 8
int MaxDigit (int num)
{
int maxdigit = 0;
while (num > 0)
{
    int var1 = num % 10;
    if (var1 > maxdigit)
    {
        maxdigit = var1;
    }
    num = num / 10;

}
return maxdigit;
}
int num = new Random().Next(10, 10000);
int maxdigit = MaxDigit (num);
System.Console.WriteLine(num);
System.Console.WriteLine(maxdigit);
System.Console.WriteLine(num);
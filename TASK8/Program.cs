/*Вывести числа от 1 до 100
Если число кратно 3 - вместо числа пишет FIZZ
Если число кратно 5 - пишет BUZZ
если число кратно и 3 и 5 вместо чисал пишет FIZZBUZZ
1, 2, FIZZ, 3, 4, BUZZ*/
int count = 1;
while (count <= 100)
{
    string value = count.ToString();
    if (count % 3 == 0)
    {
        value = "FIZZ";
    }
    if (count % 5 == 0)
    {
       value = "BUZZ";
    }
    if (count % 3 == 0 && count % 5 == 0)
    {
        value = "FIZZBUZZ";
    }
    System.Console.WriteLine(value);
    count++;
}
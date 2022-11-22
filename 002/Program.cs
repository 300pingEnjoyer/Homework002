int ThirdDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int sot = num / 100;
    int result = -1;
    if (num >= 100)
{
        while (num > 1000)
    {
        num = num / 10;
    }
    result = num % 10;
}
    return result;
}


Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
int NewNumber = ThirdDigit(number);
Console.WriteLine($"New version of {number} is {NewNumber}");

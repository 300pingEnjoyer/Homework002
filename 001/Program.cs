// 456, 782, 918 найти второе число

int SecondDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int sot = num / 100;
    int res = dec % 10;
    return res;
}

Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int NewNumber = SecondDigit(num);
Console.WriteLine($"New version of {num} is {NewNumber}");

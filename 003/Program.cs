Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (num <= 5)
{
    Console.WriteLine("рабочий день");
    result = num; 
}
else
{
    Console.WriteLine("выходной день");
    result = num;
}   
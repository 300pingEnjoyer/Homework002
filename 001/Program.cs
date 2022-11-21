Console.WriteLine("input first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input second number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input third number");
int num3 = Convert.ToInt32(Console.ReadLine());

//                0     1    2
int [] array = {num1, num2, num3};

int n = array.Length;
int find = num2;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.Write("second number = ");
        Console.WriteLine(num2);
    }
    index++;
}

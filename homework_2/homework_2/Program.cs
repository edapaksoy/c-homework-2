Console.Write("Enter a degree (°C):");
double celsius = double.Parse(Console.ReadLine());
double kelvin = celsius + 273.15;
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"Kelvin:{kelvin:F2}");
Console.WriteLine($"Fahrenheit:{fahrenheit:F2}");

Console.WriteLine("---------------------------------------");
Console.Write("enter a first grade:");
int first_grade = int.Parse(Console.ReadLine());

Console.Write("enter a second grade:");
int second_grade = int.Parse(Console.ReadLine());

Console.Write("enter a third grade:");
int third_grade = int.Parse(Console.ReadLine());

int sum = first_grade + second_grade + third_grade;
double average = (double)sum / 3;

if (average >= 60)
{
    Console.WriteLine($"average ={average:F2} and you passed");
}
else
{
    Console.WriteLine($"average ={average:F2} and you failed");
}

Console.WriteLine("---------------------------------------");
Console.Write("Enter a 3-digit number:");
int number = int.Parse(Console.ReadLine());
int hundreds, tens, ones;
hundreds = number / 100;
tens = (number / 10) % 10;
ones = number % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");

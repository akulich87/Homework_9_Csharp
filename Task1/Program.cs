// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// / Ввод данных
int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

void Recurse(int num1, int num2, int sum)
{
  if(num1 > num2) 
  {
    System.Console.Write($"{sum}");
    return;
  } 
  sum = sum + (num1++);
  Recurse(num1, num2, sum);
}

int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе число: ");
System.Console.WriteLine();

Recurse(num1, num2, 0);
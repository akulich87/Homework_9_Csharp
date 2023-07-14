// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// / Ввод данных
int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int num1, int num2)
{
  if(num1 == 0) 
  {
    return num2 + 1;
  } 
  else if(num1 > 0 && num2 == 0)
  {
    return Ackerman(num1 - 1, 1);
  }
  else if(num1 > 0 && num2 > 0)
  {
   return Ackerman(num1 - 1, Ackerman(num1, num2 - 1)); 
  }
  return Ackerman(num1, num2);
}

int num1 = ReadInt("Введите первое положительное число: ");
int num2 = ReadInt("Введите второе положительное число: ");
System.Console.WriteLine();

int result = Ackerman(num1, num2);
System.Console.Write(result);
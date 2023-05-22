// Задача 2
/*void Exponentiation (int a, int b)
{
    int exp = a;
    for (int count = 1; count <= b - 1; count++)
    exp = exp * a;
Console.WriteLine($"Exponentiation of {a} to {b} is {exp}");    
}
Console.WriteLine("Input number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B:");
int numberB = Convert.ToInt32(Console.ReadLine());
Exponentiation(numberA, numberB);
*/

// Задача 27
 /*void SumOfNumbers (int n)
 {
    int sum = 0;
    while (n > 0)
    {
        int x = n % 10;
        sum = sum + x;
        n = n / 10;
    }
    Console.WriteLine($"Sum of numbers from digit  is {sum}");
 } 
Console.WriteLine("Input digit:");
int digit = Convert.ToInt32(Console.ReadLine());
   if (digit > 9)
      {
      SumOfNumbers(digit);
      }
   else
      {
        Console.WriteLine($"Sum of numbers to digit is {digit}");
      }   
*/


// Задача 29
int [] CreatNewArray (int size, int min, int max)
{
    int [] array = new int[size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max);
    return array;
}
void ShowArray (int [] array)
{
    for (int i  = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
}
Console.WriteLine("Input count of elements to array:");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of element:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] array1 = CreatNewArray(count, minValue, maxValue);
ShowArray(array1);


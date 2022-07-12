/* Seminar 1 Home Work
Task 1.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1, num2;

Console.Write("input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine("Максимальное число " + num1 + ", а минимальное число " + num2); 
if(num1 < num2)    
    Console.WriteLine("Минимальное число " + num1 + ", а максимальное число " + num2);
else Console.WriteLine("Числа равны");
 

// Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int num1, num2, num3;

Console.Write("input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
    Console.WriteLine("Максимальное число " + num1); 
if(num2 > num1 && num2 > num3)    
    Console.WriteLine("Максимальное число " + num2);
if(num3 > num1 && num3 > num2)    
    Console.WriteLine("Максимальное число " + num3);
else 
{
    Console.WriteLine("Числа равны");
}
 
// Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Число " + num + " четное"); 
else 
    Console.WriteLine("Число " + num + " нечетное"); 
*/
// Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int current = 1;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}

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
_________________________

// Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int current = 0;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}

_____________________________________________________
_____________________________________________________
Домашняя работа к семинару 2.

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.


int LeaveSecondDigit(int num)
{
    int dec = num /10 % 10; 
        
    return dec; 
}
    
    int number = new Random().Next(100, 1000);
    int digit = LeaveSecondDigit(number);

Console.WriteLine(number);
Console.WriteLine(digit);
_____________________________________

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

int ShowThirdDigit(int n)
{
    int n3 = n % 10; 
    return n3; 
}
    
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 999) 
{
    while(num > 999)
    {
        num /= 10;
    }
    int digit = ShowThirdDigit(num);

    Console.WriteLine(num);
    Console.WriteLine(digit);
}
else Console.WriteLine("The third digit not exist");
_____________________________________________________________

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

*/

bool isDayOff(int n)
{
    if(n == 6 || n == 7) return true;
    else return false;
}

Console.Write("Input number 1-7: ");
int num = Convert.ToInt32(Console.ReadLine());

bool holliday = isDayOff(num);

Console.WriteLine(holliday);


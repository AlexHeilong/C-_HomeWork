﻿/* Seminar 1 Home Work
Task 1.  Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
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
 

// Task 2. Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
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
 
// Task 3. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
Console.Write("input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Число " + num + " четное"); 
else 
    Console.WriteLine("Число " + num + " нечетное"); 
_________________________

// Task 4. Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

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

Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

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



bool isDayOff(int n)
{
    if(n == 6 || n == 7) return true;
    else return false;
}

Console.Write("Input number 1-7: ");
int num = Convert.ToInt32(Console.ReadLine());

bool holliday = isDayOff(num);

Console.WriteLine(holliday);

_______________________________________
_______________________________________
*/
/*
Домашняя работа к семинару 3.
_____________________

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

void Palindrome(int num)
{
    if(num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) 
    Console.WriteLine("It's Palindrome");
    else Console.WriteLine("It is not Palindrome"); 
}
Console.Write("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Palindrome(number); 
______________________________

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53



double Dist(double xa, double ya, double za, double xb, double yb, double zb)
{
    double dist = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
    return dist;
}
Console.Write("Введите координаты x точки А: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y точки А: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z точки A: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x точки B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y точки B: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z точки B: ");
double zb = Convert.ToDouble (Console.ReadLine());

double dist = Dist(xa, xb, ya, yb, za, zb);
Console.WriteLine($"Расстояние между точками А и В равно {dist} ");
____________________________________

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


void Numbers(double num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write(current*current*current + " ");
        current++;
    }
}
double check;
Console.Write("Введите положительное число: ");
check = Convert.ToDouble(Console.ReadLine()); 
if(check < 0) check = check * -1;
Numbers(check);
*/
//_____________________________________________
//_____________________________________________
// Домашняя работа к семинару 4.
//
// Задача 1-1 (нерешенная)
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
double SquareDigitB(double numA, double numB)
{
    double result = 1;
    for(int i = 0; i < numB; i++)
    {
        result = numA * result;
    }
    return result;
}
Console.Write("Введите любое число: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите целое положительное число: ");
double numB = Convert.ToInt32(Console.ReadLine());

double squareDigitB = SquareDigitB(numA, numB);
Console.WriteLine(squareDigitB);


// Задача 1-2 (с целыми числами)
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int SquareDigitB(int numA, int numB)
{
    int result = 1;
    for(int i = 0; i < numB; i++)
    {
        result = numA * result;
    }
    return result;
}
Console.Write("Введите любое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int squareDigitB = SquareDigitB(numA, numB);
Console.WriteLine(squareDigitB);
*/
//______________________
// Задача 2.
// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int num)
{
    int result = 0;
    int i = 0;
    while(num > 0)
    {
        i = num % 10;
        result = result + i;
        num = num /10;
    }
    return result;
}
Console.Write("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(num);
Console.WriteLine(sumOfDigits);
__________________________

//Задача 3.
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive min value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive max value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
ShowArray(array);
_______________________________________________
_______________________________________________
*/
// Домашняя работа к семинару 5.

// Задача 1
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int EvenDigit(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] % 2 == 0) count += 1; 
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, 100, 999);
ShowArray(array);
int evenDigit = EvenDigit(array);
Console.WriteLine($"Количество четных чисел в массиве равно: {evenDigit} ");
________________________
*/
// Задача 2. 
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2) 
    {
        sum = sum + array[i]; 
    }
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, 0, 99);
ShowArray(array);
int sumOfElements = SumOfElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sumOfElements} ");
_________________________
*/
// Задача 3.
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        return newArray;
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int DifOfElements(int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];

    }
    int result = max - min;
    return result; 
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, 0, 99);
ShowArray(array);
int difOfElements = DifOfElements(array);
Console.WriteLine($"Разница между макс и мин элементами равна: {difOfElements} ");

___________________________________________
*/
// Домашняя работа к семинару 6.

// Задача 1.
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
        
        return newArray;
} 

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int Count(int[] newArray)
{
    int count = 0;
    for(int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] > 0) count = count + 1;
    }
    return count;
}

Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(m, min, max); 
ShowArray(array);

Console.WriteLine($"Чисел больше 0: {Count(array)} ");
*/

//_________________________

/*
// Задача 2.
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) 

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/

//_________________________________________________

// Домашняя работа к семинару 7.

// Задача 1.
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandom2dArray(int rows, int colums)
{
    double[,] newArray = new double[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m, n); 
Show2dArray(array);
*/
//_______________________________


// Задача 2.
// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max); 
Show2dArray(array);

Console.Write("Input number of row: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colum: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows > array.GetLength(0) || colums > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows} строки и {colums} столбца равно {array[rows,colums]}");
}

*/
//__________________________


// Задача 3.
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)  
    {
        for(int j = 0; j < colums; j++) 
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max); 
Show2dArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}

*/
//_______________________________________________






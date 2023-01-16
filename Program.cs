// Массив из 12 элементов , случайные числа от -9 до 9. НАйти 
//суммы положительных и отрцательных элементов

int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positivSum = 0;
int negativSum = 0;

foreach(int el in array)
{
    if(el > 0)
    { positivSum += el;}
    else
    { negativSum += el;}
}

Console.WriteLine($"Сумма положительных равна {positivSum}, сумма отрицательных равна {negativSum}");

//---------------Methods-------------

int GetArray (int size, int minValue, int maxValue)
    {int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {res[i] = new Random().Next(minValue, maxValue +1);}

    return res;
}

// //Задача 32:** Напишите программу замена элементов массива: 
// //положительные элементы замените на соответствующие отрицательные, и наоборот.

// //[-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] Array = GetArray(6);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
int[] Array2 =  Change(Array);
System.Console.WriteLine($"[{String.Join(",", Array2)}]");


//---------------Методы

int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(-10, 10);
    }
    return res;
}

int[] Change(int[] Array)
{
    for(int item = 0; item < Array.Length; item++)

{
    Array[item] = -Array[item];
}
return Array;
}

//Задача 33:** Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

int[] Array = GetArray(5);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if(FindNumber(number, Array)) 
{Console.WriteLine($"Число {number} есть в массиве");}
else
{Console.WriteLine($"Число {number} отсутствует в массиве");}


//-------------------- Methods-----


int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(20);
    }
    return res;
}

bool FindNumber(int number, int[] Array)
{
    foreach (int i in Array)
    {
        if(i==number)
        return true;
            }
    return false;
}

// int FindNumber(int number, int[] Array)
// {
//     for(int i = 0; i <Array.Length; i++)
//     {
//         if(Array[i]==number)
//         return i;
//             }
//     return false;
// }

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
//элементов массива, значения которых лежат в отрезке [10,99].

int[] Array = GetArray(10);
Array[1] = 11;
Console.WriteLine($"[{String.Join(",", Array)}]");

Console.WriteLine($"Количество элементов от 10 до 99 в массиве равно {Quantity(Array)}");

//----------------Методы-----
int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(0, 1001);
    }
    return res;
}

int Quantity(int[] Array)
{
    int count = 0;
    foreach (int el in Array)
    {
        if((10 <= el)&&(el  < 100))
        {count++;}
    }
    return count;
}
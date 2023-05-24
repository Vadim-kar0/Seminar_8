// //что-то принимают ничего не возвращают
// void Method1()
// {
//     Console.WriteLine("2023");
// }

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
// Method1();


// Функции (или методы - это одно и то же): 
// Объявление функций:
// тип_данных название_функции(входные_параметры)

// !!! ВАЖНО !!! 
// функция должна возвращать переменную (или значение) того же типа данных, что у неё перед названием

// Функция возвращающая результат:
// return - специальное ключевое слово. Оно возвращает результат, который записан после неё
// и останавливает выполнение функции
// int - тип_данных, GetSquare - название_функции, number - входной_параметр
// перед GetSquare тип данных int -> значит можем вернуть только целое число
// int GetSquare(int number)
// {
//     int square = number * number; // получаем квадрат числа
//     // return "hello";
//     return square; // возвращение результата и завершение функции
// }

// // Пример функции с несколькими параметрами
// int GetSum(int first, int second)
// {
//     return first + second;
// }

// // Пример функции с типом string
// string MakeString(string first, string second)
// {
//     string newString = $"{first} {second}";
//     return newString;
// }

// int x = GetSquare(6); // вызов функции
// Console.WriteLine(x); // 25
// int y = GetSum(5, 6); // вызов функции с несколькими параметрами (параметры указываются через запятую)
// Console.WriteLine(y); // 11
// string z = MakeString("Hello", "world"); // вызов функции с типом string
// Console.WriteLine(z); // Hello world

// !Пример нескольких return в функции + альтернативное решение задачи про число с консоли и день недели
// string GetWeekDay(int dayNumber) 
// {
//     if (dayNumber < 1 || dayNumber > 7)
//     {
//         return $"Не существует дня с номером {dayNumber}";
//     }

//     string[] weekDays = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
//     return weekDays[dayNumber - 1];
// }

// Console.WriteLine ("Введи номер дня: ");
// string textFromConsole = Console.ReadLine();
// int weekDayNumber = Convert.ToInt32(textFromConsole);
// Console.WriteLine();
// string weekDay = GetWeekDay(weekDayNumber);
// Console.WriteLine(weekDay);

// !Окончание примера

// Функция НЕ возвращающая результат:
// void - тип данных специально для функций, которые ничего не возвращают
// void PrintMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 5); // вызов функции
// PrintMessage("Моё сообщение номер: ", 6);
// PrintMessage("Моё сообщение номер: ", 7);


// Использование return для остановки функции
// void PrintMessage(string message, int number)
// {
//     if (number > 3)
//     {
//         Console.WriteLine("Слишком большой номер");
//         return; // если number > 3, то выводим сообщение и заканчиваем выполнение функции
//         // т.е. дальше выполнение кода не пойдёт
//     }
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 4); // вызов функции

// какая-то программа: считывает число с консоли и возвращает его квадрат
// Все функции лучше описывать в начале программы (сверху)
// int GetSquare(int number)
// {
//     return number * number;
// }

// string str = Console.ReadLine();
// int x = int.Parse(str);
// x = GetSquare(x);
// Console.WriteLine(x);

// Итог:
// 1. Функция, которая возвращает результат (int, string, любой) -- 
// это официант, который приносит блюдо (возвращает результат)
// 2. Функция, которая не возвращает результат (void) -- 
// это уборщица. Ничего конкретного на подносе не принесёт, но что-то делает и может изменять окружение



// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

//                     int[,] FillArray(int[,] arr, int startRandom, int endRandom)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(startRandom, endRandom + 1);
//         }
//     }
//     return arr;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] arr = new int[3, 4];
// FillArray(arr, 1, 10);
// PrintArray(arr);

// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     int temp = arr[0, j];
//     arr[0, j] = arr[arr.GetLength(0) - 1, j];
//     arr[arr.GetLength(0) - 1, j] = temp;
// }
// Console.WriteLine();
//                         PrintArray(arr);

// void Zapolnenie(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0, 11);

//     }
// }
// }
// void PechatMassiva(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();

// }
// }
// int[,] array = new int[3,4];

// Zapolnenie(array);
// PechatMassiva(array);


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     memory = array[i,j];
//     array [i,j] = array [i,array.GetLength(1)-1];
//     array [i,array.GetLength(1)-1] = memory;
//     }
//     Console.WriteLine();

// }

// int memory = 0 ;

// for (int i = 0; i < length; i++)
// {
//     memory = array[i,j];
//     array [i,j] = array [i,array.GetLength(1)-1];
//     array [i,array.GetLength(1)-1] = memory;
// }

// PechatMassiva(array);

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2

// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 
// удалить строку и столбец, на пересечении которых расположен наименьший элемент.


// void Zapolnenie(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 111);

//         }
//     }
// }
// void PechatMassiva(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();

//     }
// }
// int[,] array = new int[3, 4];
// Zapolnenie(array);
// PechatMassiva(array);


// int min = array[0, 0];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i, j] < min)
//         {
//             min = array[i, j];
//         }
//     }
// }

// int ignore_i = 0;
// int ignore_j = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i, j] == min)
//         {
//             ignore_i = i;
//             ignore_j = j;
//             Console.WriteLine($"Индексы минимального числа [{i} , {j}]");
//         }
//     }
// }

// int[,] arraySecond = new int[2, 3];

// int rows = arraySecond.GetLength(0);
// int rows = arraySecond.GetLength(0);


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     if (ignore_i == i )
//     {
//         continue;
//     }
//     else 
//     arraySecond[i,j] = array[i,j];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         arraySecond[i,j] = array[i,j];
//     }
// }


// PechatMassiva(arraySecond);


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Минимальный элемент находится -> {string.Join(" ", GetIndexMinEl(array))}");
// Console.WriteLine();
// var indexes = GetIndexMinEl(array);
// var resultArray = GetResultArray(array, indexes);
// PrintArray(resultArray);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[] GetIndexMinEl(int[,] inArray)
// {
//     int[] result = new int[] { 0, 0 };
//     int min = inArray[0, 0];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (min > inArray[i, j])
//             {
//                 min = inArray[i, j];
//                 result[0] = i;
//                 result[1] = j;
//             }
//         }
//     }
//     return result;
// }

// int[,] GetResultArray(int[,] inArray, int[] indexes)
// {
//     int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
//     int row = 0;
//     int column = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (i == indexes[0]) continue;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (j == indexes[1]) continue;
//             result[row, column] = inArray[i, j];
//             column++;
//         }
//         column = 0;
//         row++;
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }







// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int m = 1;
System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

string Recursia(int numEnd)
{
    if (numEnd == 1)
    {
        return numEnd.ToString();
    }
    else
    {
        return numEnd + ", " + Recursia(numEnd - 1);
    }
}
Console.WriteLine(Recursia(n));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Recursia (int numStart, int numEnd)
{
    if (numStart == numEnd) return numStart;
    else return numStart + Recursia (numStart + 1, numEnd);
}

int sum = Recursia (m, n);
Console.WriteLine ($"Сумма чисел от {m} до {n} равна {sum}");
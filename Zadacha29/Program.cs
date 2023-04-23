// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]

// 6, 1, 3 -> [6, 1, 3]

int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(-10,10);
Console.Write(randomArray[i] + " ");
}

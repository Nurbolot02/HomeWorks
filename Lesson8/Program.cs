/*
    Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int GetUniqNumber(int[] numbersOfArray)
{
    int nextNumber;
    do
    {
        nextNumber = new Random().Next(10, 100);
    } 
    while (numbersOfArray[nextNumber] != 0);
    numbersOfArray[nextNumber] = 1;
    return nextNumber;
}
int[,,] GenerateArray(int numberOfRows, int numberOfColumns, int numberOfDepth, int[] numbersOfArray)
{
    int[,,] returnArray = new int[numberOfRows, numberOfColumns, numberOfDepth];
    if (numberOfRows * numberOfColumns * numberOfDepth < 90)
    {

        for (int i = 0; i < returnArray.GetLength(0); i++)
        {
            for (int j = 0; j < returnArray.GetLength(1); j++)
            {
                for (int k = 0; k < returnArray.GetLength(2); k++)
                {
                    returnArray[i, j, k] = GetUniqNumber(numbersOfArray);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив для уникальных двухзначиных чисел");
    }
    return returnArray;

}
void Print3DArray(int[,,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {incomingArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}
void PrintArray(int[] incomingArray)
{
    int count = 0;
    for (int i = 10; i < incomingArray.GetLength(0); i++)
    {
        if (incomingArray[i] == 1) 
        {
           count++; 
           Console.WriteLine($"[{i}] {incomingArray[i]} ");
        }
        
    }
    Console.WriteLine($"Количество чисел {count}");

}
int[] numbersOfArray = new int[100];
int[,,] array3D = GenerateArray(3, 3, 3, numbersOfArray);
Print3DArray(array3D);
System.Console.WriteLine();
PrintArray(numbersOfArray);

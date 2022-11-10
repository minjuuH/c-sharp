using System;

//배열의 배열: 다차원 배열과 다름 / 원소에 해당하는 배열이 서로 다른 크기를 가질 수 있다
class ArrayOfArrayApp
{
    public static void Main()
    {
        int[][] arrayOfArray = new int[3][];        //declaration
        int i, j;
        for (i = 0; i < arrayOfArray.Length; i++)   //creation
            arrayOfArray[i] = new int[i + 3];
        for (i = 0; i < arrayOfArray.Length; i++)
            for (j = 0; j < arrayOfArray[i].Length; j++)
                arrayOfArray[i][j] = i * arrayOfArray[i].Length + j;
        for (i = 0; i < arrayOfArray.Length; i++)   //printing
        {
            for (j = 0; j < arrayOfArray[i].Length; j++)
                Console.Write($" {arrayOfArray[i][j]}");
            Console.WriteLine();
        }
    }
}
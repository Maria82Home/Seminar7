/*
int[,] CreateRandom2DArray()
{
  Console.Write("Input amount of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input min: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input max: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
};
*/

void Show2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

/*
int[,] newArray = CreateRandom2DArray(rowsamount,columnsamount,minelement,maxelement);
Show2DArray(newarray);
*/

//Task1. Задать двумерный массив m и n. Каждый элемент массива находится по формуле a[i,j]=i+j.

/*
int[,] GenerateArray(int rows, int columns)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = i + j;
  return array;
}

Console.Write("Input amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray=GenerateArray(rows,columns);
Show2DArray(newArray);
*/

//Task2. В двумерном массиве элементы с четными индексами возвести в квадрат.

/*
int[,] ChangeArray(int[,] array) 
{
  for(int i=0;i<array.GetLength(0);i+=2)
    for(int j=0;j<array.GetLength(1);j+=2)
    array[i,j]*=array[i,j];
  return array;
}

int[,] oldArray = CreateRandom2DArray();
Show2DArray(oldArray);
int[,] newArray = ChangeArray(oldArray);
Show2DArray(oldArray);
*/

//Task3. Задать квадратный двумерный массив и выдать сумму элементов главной диагонали.

int[,] CreateRandomSquareArray()
{
  Console.Write("Input size of array: ");
  int size = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input min: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input max: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[size, size];
  for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;    
}



int SumDiagonal(int[,] array)
{
  int sum = 0;
  for(int i=0;i < array.GetLength(0);i++)
    sum=sum+array[i,i];
  return sum;
}

int[,] squareArray = CreateRandomSquareArray();
Show2DArray(squareArray);
int sum = SumDiagonal(squareArray);
Console.Write(sum);
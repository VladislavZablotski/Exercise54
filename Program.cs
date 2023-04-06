int[,] array = new int[3,4];
// Заполняем массив
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}
// Проводим сортировку
int temp;
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      for (int k = j; k < array.GetLength(1); k++)
      {
        if (array[i,k]>array[i,j])
        {
            temp = array[i,k];
            array[i,k]=array[i,j];
            array[i,j]=temp;
        }
      }
   }
}
// Выводим отсортированный массив
Console.WriteLine();
Console.WriteLine("Массив, осортированный по строкам: ");
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}
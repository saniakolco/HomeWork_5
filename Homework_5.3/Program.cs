//Напиcать программу, которая задаёт массив из N элементов 
//и выводит их на экран.

System.Console.WriteLine("Установите длинну массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[lengthArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
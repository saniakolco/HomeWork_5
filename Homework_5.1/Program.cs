//Написать цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число A ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

int degree = a;

for (int i = 1; i < b; i++)
{ 
    degree = degree * a;
}

Console.WriteLine("A в степени B = " + degree);
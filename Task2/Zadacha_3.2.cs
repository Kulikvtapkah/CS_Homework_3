// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Chat(string request)
{

    System.Console.Write($" >> {request}");
    int response = Convert.ToInt32(Console.ReadLine());

    return (response);
}

System.Console.WriteLine("Введите координаты точки А: ");
int X1 = Chat("XА= ");
int Y1 = Chat("YА= ");
int Z1 = Chat("ZА= ");
System.Console.WriteLine("Отлично! Теперь координаты точки В: ");
int X2 = Chat("XВ= ");
int Y2 = Chat("YВ= ");
int Z2 = Chat("ZВ= ");


double Length = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2) + (Z1 - Z2) * (Z1 - Z2));
Length = Math.Round(Length, 2, MidpointRounding.ToEven);
System.Console.Write($"Длина отрезка АВ составляет {Length}!");

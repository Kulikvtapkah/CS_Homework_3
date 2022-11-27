// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число N, пожалуйста) >> ");
string FirstInput = Console.ReadLine();
int Num = Convert.ToInt32(FirstInput);

int test = 1;
int Znak = 1;             //Чтобы работало как для N больше или = 1,
if (Num <1) {Znak = -1;}  //так и для N меньше 1

Console.WriteLine("Список кубов целых чисел от 1 до N:");

while (test != Num)
{
    Console.Write(test * test * test + ", ");
    test = test + Znak;
}
Console.Write(test * test * test + ". ");

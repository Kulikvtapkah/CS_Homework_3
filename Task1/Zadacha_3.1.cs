// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Chat(string request)
{
    int response = 0;
    bool rightInput = false;
    while (rightInput == false)
    {
        System.Console.Write($" {request} >> ");
        response = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if ((response > 9999) && (response < 100000))
        {
            rightInput = true;
        }
        else { System.Console.WriteLine("Это число не пятизначное. Попробуйте еще раз!"); }
    }

    return (response);
}

int Num = Chat("Введите пятизначное число, пожалуйста");

 if ((Num/10000 == Num%10) && ((Num/1000)%10 == (Num/10)%10))
 { System.Console.Write(" Да! Это число - палиндром!"); }
 else
 { System.Console.Write("Нет, это не палиндром."); }







//Задача 19. Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int count = Convert.ToInt32(Console.ReadLine());

bool Palindrom()
{
    int numb1 = count / 10000;
    int numb2 = count % 10000 / 1000;
    int numb3 = count % 1000 / 100;
    int numb4 = count % 100 / 10;
    int numb5 = count % 10;

    return (numb1 == numb5 && numb2 == numb4);
}

Console.WriteLine(Palindrom() 
        ? "Данное число является палиндромом" 
        : "Число не является палиндромом");
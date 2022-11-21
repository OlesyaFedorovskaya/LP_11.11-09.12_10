// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("Вы ввели несуществующий день недели");
}
else
{
    Console.WriteLine("Будний день");
}

//или

//Console.Write("Введите цифру обозначающую день недели: ");
//int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(IsHoliday(number) ? "Да" : "Нет");

//bool IsHoliday (int day)
//{
//    return day == 6 || day == 7;
//}
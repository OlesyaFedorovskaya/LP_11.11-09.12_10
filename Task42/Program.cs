// Задача 42: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//string Binary(int nunb)
//{
//    string bin = string.Empty;
//   while (numb > 0)
//{
//    bin = numb % 2 + bin;
//    numb /= 2;
//}
//return bin;
//}

void PrintArray(int[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("");
}

int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[i] = numb % 2;
        numb /= 2;
    }
    return bin;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
Array.Reverse(binary);
//Console.WriteLine(Binary(number));
PrintArray(binary);

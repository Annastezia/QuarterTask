/*Задание. Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символам.*/

void Print (string[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void CheckString1(string[] String1, string[] String2)
{
    int count = 0;
    for (int i = 0; i < String1.Length; i++)
    {
    if(String1[i].Length <= 3)
        {
        String2[count] = String1[i];
        count++;
        }
    }
}

string[] String1 = new string[5] {"523", "82", "hello", "world", "var"};
string[] String2 = new string[String1.Length];

CheckString1(String1, String2);
Print(String2);
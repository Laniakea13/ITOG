﻿string[] array = {"Hola", "Ole", "123", "Privet", "Hi", "12345", "void", "arr", "Boo", "Example"};

void PrintArray(string[] arr)
{
   for(int i=0; i<arr.Length; i++)
   {
        Console.Write($"{arr[i]}  ");
   }
}

string[] RunArray(string[] finarray)
{
    int count = 0;
    for (int i = 0; i < finarray.Length; i++)
    {
        if(finarray[i].Length <= 3) count = count + 1;
        else count = count + 0;
    }
    string[] fin = new string[count];
    int index = 0;
     for (int i = 0; i < finarray.Length; i++)
     {
        if(finarray[i].Length <= 3) fin[index++] = finarray[i];
     }
 return fin;
}

PrintArray(RunArray(array));
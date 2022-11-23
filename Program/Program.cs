/* Написать программу, которую из имеющегося массива строк 
формирует массив строк, длинна которых меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма*/
Console.Clear();
Console.WriteLine("Написать программу, которую из имеющегося массива строк "
                 +"формирует массив строк, длинна которых меньше либо равна 3 символам.");
string input = GetAndPrintValue("Введите массив строк черз запятую: ");
string[] firstArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
string[] secondArray = new string[firstArray.Length];

string GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    return input;
}

void ShowShortArray(string[] firstArray, string[] secondArray)
{
int position = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[position] = firstArray[i];
        position++;
    } 
}
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
   Console.WriteLine();
}
ShowShortArray(firstArray, secondArray);
PrintArray(secondArray);
 
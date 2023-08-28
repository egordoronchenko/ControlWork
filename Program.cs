using System.Diagnostics.Contracts;
using System.Globalization;

string ReadString(string message)
{
    Console.WriteLine(message);
    return Convert.ToString(Console.ReadLine());
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{Array[i]} ");
    }
    Console.WriteLine();
}

int N = ReadInt("Введите сколько будет строк");
int numForArrayTwo = 0;

string[] FirstArray = new string[N];
for (int i = 0;i < N; i++)
{
    FirstArray[i] = ReadString("Введите строку");
    if(FirstArray[i].Length == 0)
    {
       FirstArray[i] = "Тут ввели пустую строку";
    }

    if (FirstArray[i].Length <= 3||FirstArray[i] == "Тут ввели пустую строку")
    {
        numForArrayTwo++;
    }
}

string[] SecondArray = new string[numForArrayTwo];
for (int i = 0, j = 0;i <FirstArray.Length ; i++)
{
    if (FirstArray[i].Length <= 3||FirstArray[i] == "Тут ввели пустую строку")
    {
        SecondArray[j] = FirstArray[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine("ну а теперь покажем второй массив");
Console.WriteLine();
ShowArray(SecondArray);


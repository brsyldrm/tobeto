using System.Runtime.CompilerServices;

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

int number = 10;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}

do
{
    Console.WriteLine(number);
    number--;
} while (number >= 0);

string[] students = new string[3] { "Engin", "Derin", "Salih" };
foreach (var student in students)
{
    Console.WriteLine(student);
}


//ASAL SAYI
public class Prime
{
    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i <= number-1; i++)
        {
            if (number%i==0)
            {
                result = false;
            }
        }
        return result;
    }
}


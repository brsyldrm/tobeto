Add();
var result = Add2(20, 30);
var result2 = Add3(20);
Console.WriteLine(result);
Console.WriteLine(result2);

//int number1 = 20;
//int number2 = 100;
//var result3 = Add3(number1, number2);
//var result4 = Add4(ref number1, number2);
//Console.WriteLine(result3);
//Console.WriteLine(result4);
//Console.WriteLine(number1);

Console.WriteLine(Overload.Multiply(2,3));
Console.WriteLine(Overload.Multiply(2, 3,4));




static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1, int number2)
{
    return number1 + number2;
}
//Default parametreli method ( default değerler her zaman en sonda olmak zorunda )
static int Add3(int number1, int number2 = 30)
{
    return number1 + number2;
}



public class Overload
{
    public static int Add4(ref int number1, int number2)
    {
        number1 = 30;
        return (number1 + number2);
    }
    public static int Multiply(int number1, int number2)
    {
        return (number1 * number2);
    }
    public static int Multiply(int number1, int number2, int number3)
    {
        return (number1 * number2 * number3);
    }

    public static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }
}


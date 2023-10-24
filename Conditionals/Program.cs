var number = 10;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else
{
    Console.WriteLine("Number is not 10");
}


//farklı yazım tekniği - Single Line If
var number1 = 11;
Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");

//else if
var number2 = 12;
if (number2 == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

//Switch
var number3 = 11;
switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

//Çoklu şart
var number4 = 12;
if (number4 >= 0 && number4 <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number4 > 100 && number4 <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number4 >200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}
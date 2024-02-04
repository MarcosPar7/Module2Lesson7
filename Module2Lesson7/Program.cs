// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

//1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. Dane testowe: a : 5 b : 5 Rezultat w terminalu : 5 i 5 są równe

int a = 5;
int b = 5;

if (a == b)
{
    Console.WriteLine("a and b are equal");
}

else
{
    Console.WriteLine("a and b are not equal");
};

//2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta. Dane testowe : 15 Rezultat w terminalu : 15 jest liczbą nieparzystą

Console.WriteLine("Write a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even number");
}
else
{
    Console.WriteLine($"{number} is odd number");
}

//3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. Dane testowe : 14 Rezultat w terminalu : 14 jest liczbą dodatnią

int choice = 14;

if (choice > 0)
{
    Console.WriteLine("Number is more than 0");
}

else if (choice < 0)
{
    Console.WriteLine("Number is less than 0");
}

else 
{
    Console.WriteLine("Number is 0");
}

//4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym. Dane testowe : 2016 Rezultat w terminalu : 2016 jest rokiem przestępnym

Console.WriteLine("Write a year:");
int year = Convert.ToInt32(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine($"{year} is leap year");
}
else
{
    Console.WriteLine($"{year} isn't a leap year");
}
    //5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta. Dane testowe : 21 Rezultat w terminalu : Możesz zostać posłem

    Console.WriteLine("Write your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
   
    if (age >= 21)
    { Console.WriteLine("You can be a posel");  }
        else
    {
        Console.WriteLine("You can't be a posel");
    }

    if (age >= 30)
    { Console.WriteLine("You can be a senator"); }
    else
    {
        Console.WriteLine("You can't be a senator");
    }

    if (age >= 35)
    { Console.WriteLine("You can be a president"); }
    else
    {
        Console.WriteLine("You can't be a president");
    }

    if (age >= 35)
    { Console.WriteLine("You can be a prime minister"); }
    else
    {
        Console.WriteLine("You can't be a prime minister");
    }

    //6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu. Dane testowe : 140 Rezultat w terminalu : Jesteś krasnoludem

    int hight = 140;

    if (hight >= 200)
    {
        Console.WriteLine("You are giant");
    }

    else if (hight >= 180)
    { Console.WriteLine("You are high"); }

    else if (hight >= 160)
    { Console.WriteLine("You are ok"); }

    else if (hight >= 140)
    { Console.WriteLine("You are dwarf"); }

    else { Console.WriteLine("Probably You are not a human"); }

    //7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa Dane testowe: 25 63 79 Rezultat w terminalu : 79 jest największa z podanych

    int number1 = 25;

    int number2 = 63;

    int number3 = 79;

    int largest;

    if (number1 > number2 && number1 > number3)
    {
        largest = number1;
    }
    else if (number2 > number3)
    {
        largest = number2;
    }
    else
    {
        largest = number3;
    }
    Console.WriteLine($"{largest} is the largest of all");


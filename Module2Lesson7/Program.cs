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

//8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów: Wynik z Matury z matematyki powyżej 70 Wynik z fizyki powyżej 55 Wynik z chemii powyżej 45 Łączny wynik z 3 przedmiotów powyżej 180 Albo Wynik z matematyki i jednego przedmiotu powyżej 150 Dane testowe: Matematyka 80 Fizyka 71 Chemia 0 Rezultat w terminalu : Kandydat dopuszczony do rekrutacji

int scoreMath = 80;

int scorePhysics = 71;

int scoreChemistry = 0;

bool recruitment = (scoreMath > 70 && scorePhysics > 55 && scoreChemistry > 45 && (scoreMath + scorePhysics + scoreChemistry) > 180 || (scoreMath + Math.Max(scorePhysics, scoreChemistry) > 150));

if (recruitment)
{ Console.WriteLine("Candidate pass the exams"); }

else
{ Console.WriteLine("Candidate doesn't pass the exams"); }

//9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach Temp < 0 – cholernie piździ Temp 0 – 10 – zimno Temp 10 – 20 – chłodno Temp 20 – 30 – w sam raz Temp 30 – 40 – zaczyna być słabo, bo gorąco
//Temp >= 40 – a weź wyprowadzam się na Alaskę.

Console.WriteLine("Write a temperature");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature < 0)
{ Console.WriteLine("cholernie piździ"); }

else if (temperature >= 0 && temperature < 10)
{ Console.WriteLine("zimno"); }

else if (temperature >= 10 && temperature < 20)
{ Console.WriteLine("chłodno"); }

else if (temperature >= 20 && temperature < 30)
{ Console.WriteLine("w sam raz"); }

else if (temperature >= 30 && temperature < 40)
{ Console.WriteLine("zaczyna być słabo, bo gorąco"); }

else if (temperature >= 40)
{ Console.WriteLine("a weź wyprowadzam się na Alaskę."); }

// 10.Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt Dane testowe: 40 55 65 Rezultat w terminalu: Można zbudować trójkąt

Console.WriteLine("Write lenghts sides of triangle, separated by commas");
string[] sides = Console.ReadLine().Split(",");
int d = Convert.ToInt32(sides[0]);
int e = Convert.ToInt32(sides[1]);
int f = Convert.ToInt32(sides[2]);

if (d + e > f && d + f > e && e + f > d)
{
    Console.WriteLine("You can create a triangle");
}
else
{
    Console.WriteLine("You can't create a triangle");
}

// 11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:

Console.WriteLine("Write a grade");

int studentGrade = Convert.ToInt32(Console.ReadLine());

switch (studentGrade)
{
    case 1:
        Console.WriteLine("Student Grade : Niedostateczny");
        break;
    case 2:
        Console.WriteLine("Student Grade : Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Student Grade : Dostateczny");
        break;
    case 4:
        Console.WriteLine("Student Grade : Dobry");
        break;
    case 5:
        Console.WriteLine("Student Grade : Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Student Grade : Celujący");
        break;
    default:
        Console.WriteLine("Student Grade : There is no such grade");
        break;
}
//12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę Dane testowe : 4

int day = 4;

if (day == 1)
{
    Console.WriteLine("Monday");
}
else if (day == 2)
{
    Console.WriteLine("Tuesday");
}
else if (day == 3)
{
    Console.WriteLine("Wednesday");
}
else if (day == 4)
{
    Console.WriteLine("Thursday");
}
else if (day == 5)
{
    Console.WriteLine("Friday");
}
else if (day == 6)
{
    Console.WriteLine("Saturday");
}
else if (day == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Error");
}

// 13.Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I będzie prostym kalkulatorem Podaj pierwszą liczbę: … Podaj drugą liczbę: … Podaj numer operacji do wykonania:
//  1.Dodawanie
//2.Odejmowanie
//3.Mnożenie
//4.Dzielenie
//…
//Twój wynik to:

Console.WriteLine("Write first number: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Write second number: ");
double numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an operation: ");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");

int operacja = Convert.ToInt32(Console.ReadLine());
double result;

switch (operacja)
{
    case 1:
        result = numberA + numberB;
        break;
    case 2:
        result = numberA - numberB;
        break;
    case 3:
        result = numberA * numberB;
        break;
    case 4:
        if (numberB != 0)
        {
            result = numberA / numberB;
        }
        else
        {
            Console.WriteLine("You can't divided by 0");
            return;
        }
        break;
    default:
        Console.WriteLine("There is no such operation");
        return;
}
Console.WriteLine($"Yours result is:{result}");

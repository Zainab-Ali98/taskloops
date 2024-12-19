// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//taskControl flow
for (int i = 1; i <= 10; i++)
{

    Console.WriteLine("Number: " + i);

}

//arrays
string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday"};

for( int y= 0; y< daysOfWeek.Length; y++)
{
    Console.WriteLine(" week days " + daysOfWeek[y]);
}

//bonus
int countdown = 5;
while(countdown> 0)
{
    Console.WriteLine(countdown);
    countdown--;
}

//bonus
//To store tabels (rows and colums)
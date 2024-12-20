// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//taskControl flow
for (int i = 1; i <= 10; i++)
{

    Console.WriteLine("Number: " + i);

}

//arrays
string[] daysOfWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

for( int y= 0; y< daysOfWeek.Length; y++)
{
    Console.WriteLine(" week days " + daysOfWeek[y]);
}


int[] number = { 1, 2, 3, 4, 5,};
int sum = 0;
for (int z = 0; z <=number.Length; z++)
{
    sum += z;

}
Console.WriteLine("the sum is : " + sum);

//bonus
int countdown = 5;
while(countdown> 0)
{
    Console.WriteLine(countdown);
    countdown--;
}

//bonus
// Multidimensional array are useful to store data in a tabular form such as tabels(rows and colums)
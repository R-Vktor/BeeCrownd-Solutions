using System.Globalization;
using System;


string [] firstCord = Console.ReadLine().Split(' ');
string [] secCord = Console.ReadLine().Split(' ');

double X1 = double.Parse(firstCord[0],CultureInfo.InvariantCulture);
double Y1 = double.Parse(firstCord[1],CultureInfo.InvariantCulture);

double X2 = double.Parse(secCord[0],CultureInfo.InvariantCulture);
double Y2 = double.Parse(secCord[1],CultureInfo.InvariantCulture);

double subX = X2-X1;
double subY = Y2-Y1;

//Console.WriteLine("valo de subX: " + subX);
//Console.WriteLine("valo de subY: " + subY);

double XposiQ = Math.Pow(subX,2);
double YposiQ = Math.Pow(subY,2);

//Console.WriteLine("valo de XposiQ: " + XposiQ);
//Console.WriteLine("valo de YposiQ: " + YposiQ);

double result = Math.Sqrt(XposiQ + YposiQ);

Console.WriteLine(result.ToString("F4",CultureInfo.InvariantCulture));
Console.Read();


//Console.WriteLine(consumo.ToString("F3",CultureInfo.InvariantCulture) + " km/l");



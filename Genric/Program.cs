// See https://aka.ms/new-console-template for more information

using Genric;


int[] intArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
//Program.toPrint(intArray);
//Program.toPrint(doubleArray);
//Program.toPrint(charArray);

sample.toPrint<int>(intArray);
sample.toPrint<double>(doubleArray);
sample.toPrint<char>(charArray);
Console.ReadKey();
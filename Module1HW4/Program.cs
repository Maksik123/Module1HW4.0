using System;
using System.Text;

Console.WriteLine("Plese enter number:");
int number;
string? text = Console.ReadLine();
bool isString = int.TryParse(text, out number);

int[] array = new int[number];
int numberOfEven = 0;
int numberOfOdd = 0;
Random rand = new Random();

for (var i = 0; i < number; i++)
{
    array[i] = rand.Next(1, 26);
    if(array[i] % 2 == 0)
    {
        numberOfEven++;
    }
    else
    {
        numberOfOdd++;
    }
    if(i == number - 1)
    {
        Console.Write(array[i]);
        continue;
    }
    Console.Write(array[i] + " ");
}
int[] arrayEven = new int[numberOfEven];
int[] arrayOdd = new int[numberOfOdd];

int n = 0;
int j = 0;

for (int i = 0 ; i< number; i++)
{
    if (array[i] % 2 == 0)
    {
        arrayEven[n] = array[i];
        n++;
    }
    else
    {
        arrayOdd[j] = array[i];
        j++;
    }
}
int counter = 0;
string stringEven = string.Empty;
for (int h = 0; h < numberOfEven; h++)
{
    foreach (int i in Enum.GetValues(typeof(alpfabet)))
    {
        Enum myAlphabet = (alpfabet)i;
        if (arrayEven[h] == i)
        {
            stringEven += myAlphabet.ToString() + " ";
            if (i == 1 || i == 4 || i == 5 || i == 8 || i == 9 || i == 10)
            {
                counter++;
            }
        }
    }
}
string stringOdd = string.Empty;
for (int h = 0; h < numberOfOdd; h++)
{
    foreach (int i in Enum.GetValues(typeof(alpfabet)))
    {
        Enum myAlphabet = (alpfabet)i;
        if (arrayOdd[h] == i)
        {
            stringOdd += myAlphabet.ToString() + " ";
            if (i == 1 || i == 4 || i == 5 || i == 8 || i == 9 || i ==10)
            {
                counter--;
            }
        }
    }
}
if (counter == 0)
{
    Console.WriteLine("\nstring Even and string Odd have the same number of Upper letters");
}
else
{
    if (counter > 0)
    {
        Console.WriteLine("\nstring Even has more Upper letters:\n" + stringEven);
    }
    else
    {
        Console.WriteLine("\nstring Odd has more Upper letters:\n" + stringOdd);
    }
}
Console.WriteLine("\nString Odd:\n" + stringOdd);
Console.WriteLine("\nString Even:\n" + stringEven);

enum alpfabet
{
    A = 1,
    b,
    c,
    D,
    E,
    f,
    g,
    H,
    I,
    J,
    k,
    l,
    m,
    n,
    o,
    p,
    q,
    r,
    s,
    t,
    u,
    v,
    w,
    x,
    y,
    z
}


int x = 25;
int y = x;

Console.WriteLine(x);
Console.WriteLine(y);

x = 12;

Console.WriteLine(x);
Console.WriteLine(y);


var array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = i * 9;
}

foreach (var item in array)
{
    Console.WriteLine(item);
}

var array2 = array;

array[6] = 3;

foreach (var item in array2)
{
    Console.WriteLine(item);
}
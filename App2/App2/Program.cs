using System;
using App2;


Triangle A = new(2f, 1f, 3f);
Triangle B = new(8.7f, 5.6f, 9.2f);

float resultA = A.CalcPerimeter();
float resultB = B.CalcPerimeter();

Console.WriteLine(resultA);
Console.WriteLine(resultB);

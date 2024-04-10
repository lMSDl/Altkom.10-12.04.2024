

using Altkom._10_12._04._2024.SOLID.L;

int a = 4;
int b = 9;


var rectangle = CreateRectangle(a, b);


Console.WriteLine($"{a} * {b} = {rectangle.Area}");

Rectangle CreateRectangle(int a, int b)
{
    return new Square() { A = a, B = b };
}
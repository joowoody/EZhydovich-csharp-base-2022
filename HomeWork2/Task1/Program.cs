// See https://aka.ms/new-console-template for more information

Console.WriteLine("enter x: ");
var x = int.Parse(Console.ReadLine());
Console.WriteLine("enter y: ");
var y = int.Parse(Console.ReadLine());
Console.WriteLine("enter z: ");
var z = int.Parse(Console.ReadLine());
var resultOfFunction = (x + y + z) * (x - z) / (y * y) + 2 * z;

Console.WriteLine($"x={x}  y={y}    z={z}");
Console.WriteLine($"Result: {resultOfFunction}");
Console.ReadKey();
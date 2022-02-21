const double pi = Math.PI;
Console.WriteLine("Введите длину радиуса в см.");
var r = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину образующей в см.");
var l = int.Parse(Console.ReadLine());
double S;
S= pi*r*(r+l);
Console.WriteLine($"Площадь поверхности круглого конуса = {Math.Round(S,2)} см.");
using System;
using CSharp_Delegates;

MathService service = new MathService();
var result = service.MathDelegate(2,4);
Console.WriteLine($"Result = {result}");
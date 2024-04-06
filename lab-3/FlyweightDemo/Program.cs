using OptimizedLightHTML;
using System.Diagnostics;

Console.WriteLine("before:");
CheckCurrentProcess();
var res = BookConverter.Convert("book.txt");

Console.WriteLine("after:");
CheckCurrentProcess();
static void CheckCurrentProcess()
{
    Process proc = Process.GetCurrentProcess();
    
    Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64 / Math.Pow(2,20)} Mb");
    Console.WriteLine($"Allocated Physical Memory: {proc.WorkingSet64 / Math.Pow(2, 20)} Mb");
}
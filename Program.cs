
using System;
using DateParserDemo.Extensions;

class Program
{
  static void Main()
  {
    string date1 = "15-02-2025";
    string date2 = "2025-02-15 12:30:45";

    Console.WriteLine($"Parsed Date 1: {date1.ParseCustomDate()}");
    Console.WriteLine($"Parsed Date 2: {date2.ParseCustomDate()}");
  }
}

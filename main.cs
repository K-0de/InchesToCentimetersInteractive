using System;

class Program {
  public static void Main (string[] args) {
    const double centPerInch = 2.54;
   Console.WriteLine("Enter a number in inches: ");
    var x = Convert.ToDouble(Console.ReadLine());
   
    Console.WriteLine("{0} inches is {1} centimeters", x, x * centPerInch);
    }
  }
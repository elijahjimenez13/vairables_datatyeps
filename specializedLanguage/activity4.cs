using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Declare Values
      int litterSize;
      int yearlyLitters;
      int annualMice;
      
      //blablablabla
     litterSize = 3;
     yearlyLitters = 5;
     annualMice = litterSize * yearlyLitters;
     Console.WriteLine("One female mouse may give birth to " + annualMice + " to");
     litterSize = 14;
     yearlyLitters = 10;
     annualMice = litterSize * yearlyLitters;
     Console.WriteLine(annualMice + " mice per year.");

     }
  }
}
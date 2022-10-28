using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 250;
          Console.WriteLine(myByte);

          sbyte mySbyte = -120;
          Console.WriteLine(mySbyte);

          int myInt = -1000000;
          Console.WriteLine(myInt);

          uint myUint = 4000000;
          Console.WriteLine(myUint);

          short myShort = -32000;
          Console.WriteLine(myShort);

          ushort myUShort = 64000;
          Console.WriteLine(myUShort);

          float myFloat = 1.34F;
          Console.WriteLine(myFloat);

          double myDouble = 42.1;
          Console.WriteLine(myDouble);

          char myCharacter = 'a';
          Console.WriteLine(myCharacter);

          bool myBool = false;
          Console.WriteLine(myBool);

          string myText = "I control text.";
          Console.WriteLine(myText);

          string numText = "10";
          Console.WriteLine(Text2Num(numText));
      }

      public static int Text2Num(string numText){
        int number;
         bool numPresent = Int32.TryParse(numText, out number);
         if(numPresent) {
          return number;
          Console.WriteLine(number);
         } else {
          return number;
          Console.WriteLine("No numbers parsed.");
         }
      }
    }
}

/*
LUHNY.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Importing the namespace.
using LuhnyLib;

// Importing the Luhny class.
using static LuhnyLib.Luhny;

// Declaring a namespace
// for the CLI and main
// point of entry for
// "dotnet".
namespace LuhnyCLI{

    // The main class for program
    // execution.
    class Program{

        // The main method for the main point
        // of entry.
        static void Main(string[] args){
            if (args.Length == 2){
                if (Luhny.isNumberSequence(args[1])){
                    if (Luhny.validateIMEI(args[1])){
                        Console.WriteLine("Valid IMEI!");
                    }
                    else {
                        Console.WriteLine("Invalid IMEI!");
                    }
                }
                else {
                    Console.WriteLine("No valid number sequence supplied.");
                }
            }
            else {
                Console.WriteLine("Invalid usage!");
            }
        }
    }
}
/*
LUHNY.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Importing and declaring
// the system namespace.
using System;

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
                if (Luhny.isNumberSequence(args[0])){
                    if (Luhny.validateIMEI(args[0])){
                        Console.writeLine("Valid IMEI!");
                    }
                    else {
                        Console.writeLine("Invalid IMEI!");
                    }
                }
                else {
                    Console.WriteLine("No valid number sequence supplied.");
                }
            }
            else {
                Console.writeLine("Invalid usage!");
            }
        }
    }
}
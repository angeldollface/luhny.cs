# LUHNY.CS

![GitHub CI](https://github.com/angeldollface/luhny.cs/actions/workflows/csharp.yml/badge.svg)

***Validate your phone's IMEI using the Luhn algorithm and C#! :iphone: :lock: :wind_face:***

## ABOUT :books:

Since I wanted to learn  new language, I built this in three hours suing previous implmenetations of the Luhn algorithm I had made as a reference. This repository contains my reimplemention of the Luhn algorithm in C#.

## INSTALLATION :inbox_tray:

### As a library

Feel free to download the library from this repo and use in your own projects. The file is located in the `src/lib`folder.

### On the command line

Assuming you have the `.NET` SDK version 7 or later installed, you can use this project on your own machine in the following way:

- 1.) Download the source code:

```bash
git clone https://github.com/angeldollface/luhny.cs
```

- 2.) Change directory into the source's root:

```bash
cd luhny.cs
```

- 3.) Build the project

```bash
dotnet build
```

- 4.) This should produce a binary executable for your system that you can use and move to a location that is on your `$PATH`.

## USAGE :hammer:

### As a library

Make sure to include the path to the file in your `*.csproj`file.
You can then use this library in the in your code. Below is a small code sample of how you would validate an IMEI number using this library:

```Csharp
using LuhnyLib;

using static LuhnyLib.Luhny;

namespace LuhnyExample{

    class Program{

        static void Main(string[] args){
            string fakeIMEI = "353879234252633";
            bool chars = Luhny.validateIMEI(fakeIMEI);
            Console.WriteLine(chars.ToString());
        }
    }
}
```

### On the command line

Assuming you installed the executable, you can use it in the following way:

```bash
# A valid IMEI.
luhny 353879234252633
```

```bash
# An invalid IMEI.
luhny 354879234252633
```

## CHANGELOG :black_nib:

### Version 0.1.0

- Initial release.
- Upload to GitHub.

# NOTE :scroll:

- *Luhny.cs :iphone: :lock: :wind_face:* by Alexander Abraham :black_heart: a.k.a. *"Angel Dollface" :dolls: :ribbon:*
- Licensed under the MIT license.

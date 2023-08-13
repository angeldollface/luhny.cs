# LUHNY.CS

```Csharp
using LuhnyLib;
using static LuhnyLib.Luhny;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
            string fakeIMEI = "353879234252633";
            bool chars = Luhny.validateIMEI(fakeIMEI);
            Console.WriteLine(chars.ToString());
        }
    }
}
```
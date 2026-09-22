using System.Threading.Channels;

namespace Repetetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello(name: "Kristin");
            
            int result = Add(a: 3, b: 8); //kallar på metod och returnerar resultatet
            Math.Max(1548, 58445);
            Console.WriteLine(result); //statiska metoder är gula t.ex WriteLine, Max, behöver parametrar


        }

        static void SayHello(string name) //ny metod med parametrar
            //static betyder att metoden tillhör klassen, behöver inte använda oop eller objekt för att använda metoden
        {
            Console.WriteLine($"Hej från Sverige {name}");
        }
        
        static int Add(int a, int b) //statisk metod
        {
            return a + b;
        }

    }
}

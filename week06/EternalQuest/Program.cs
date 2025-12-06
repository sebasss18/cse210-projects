// For the creative part, I added some small animations and also some basic error handling
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello World! This is the EternalQuest Project.");
        
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}
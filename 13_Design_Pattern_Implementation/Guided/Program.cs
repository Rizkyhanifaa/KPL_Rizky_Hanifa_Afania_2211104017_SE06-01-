using System;
using System.Windows.Input;
using guided_designpattern;  // Ensure you're using the correct namespace

namespace guided_designpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nama: Rizky Hanifa Afania ");
            Console.WriteLine(" NIM: 2211104017 ");
            Console.WriteLine(" Kelas: SE0601 ");
            
            // Singleton Pattern Example
            Console.WriteLine("=== Singleton Pattern ===");

            // Create two instances of Singleton
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            // Show the message from the Singleton
            s1.ShowMessage();

            // Check if both instances are the same
            Console.WriteLine(s1 == s2 ? "Objek yang sama." : "Objek berbeda.");

            Console.WriteLine("\n=== Adapter Pattern ===");

            // Adapter Pattern Example
            // Adaptee object
            var adaptee = new Adaptee();

            // Adapter wraps the Adaptee object to make it compatible with ITarget
            ITarget target = new Adapter(adaptee);

            // Using the target interface which now adapts the Adaptee's method
            Console.WriteLine(target.GetRequest());

            Console.WriteLine("\n=== Command Pattern ===");

            // Command Pattern Example
            // Receiver object
            var receiver = new Receiver();

            // Simple command
            ICommand simpleCommand = new SimpleCommand("Hello World");

            // Complex command
            ICommand complexCommand = new ComplexCommand(receiver, "Send Email", "Save Report");

            // Invoker that will execute the commands
            var invoker = new Invoker();
            invoker.SetOnStart(simpleCommand);  // Command to execute before main task
            invoker.SetOnFinish(complexCommand);  // Command to execute after main task

            invoker.DoSomethingImportant();  // Invoking the sequence of commands

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guided_designpattern
{
    public interface ICommand
    {
        void Execute();
    }

    // Perintah sederhana
    class SimpleCommand : ICommand
    {
        private string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: Melakukan perintah ({_payload})");
        }
    }

    // Penerima perintah
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Menangani tugas ({a})");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Menangani tugas lainnya ({b})");
        }
    }

    // Perintah kompleks
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Delegasi ke Receiver...");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }

    // Invoker
    class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Ada perintah sebelum mulai?");
            _onStart?.Execute();

            Console.WriteLine("Invoker: Melakukan tugas utama...");

            Console.WriteLine("Invoker: Ada perintah setelah selesai?");
            _onFinish?.Execute();
        }
    }
}
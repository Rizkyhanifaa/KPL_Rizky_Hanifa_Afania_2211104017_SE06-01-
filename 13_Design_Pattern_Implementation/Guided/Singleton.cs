using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guided_designpattern
{
    class Singleton
    {
        private static Singleton _instance;

        // Constructor private agar tidak bisa diinstansiasi dari luar
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance aktif.");
        }
    }
}

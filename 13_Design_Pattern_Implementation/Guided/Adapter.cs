using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guided_designpattern
{
    // Interface target yang diharapkan client
    public interface ITarget
    {
        string GetRequest();
    }

    // Adaptee (punya method tapi tidak sesuai interface)
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // Adapter: menjembatani antara ITarget dan Adaptee
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}

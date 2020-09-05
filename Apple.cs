using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationIp
{
    public class Apple
    {
        public string OperationSystem { get;set; }

        public string CPU{ get; set; }

        public string  RAM{ get; set; }

        public string InternalMemory { get; set; }

        public Iphone9 Iphone9 { get; set; }


    }

    public class Iphone9:Apple
    { 

        public string Camera { get; set; }

        public string SIM { get; set; }

        public string Chip { get; set; }
    }
}

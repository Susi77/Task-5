using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationIphone9
{
    public class Apple:IMobile
    {
        protected bool Chip = false;

        public string Camera()
        {
            return ("They have one and more cameras .");
        }

        public string CPU()
        {
            return ("They have some kind of CPUs . ");
        }

        public string OperationSystem()
        {
            return ("They work with IOS. ");
        }

        public string RAM()

        {
            return ("Iphones have 2GB,4GB,6GB RAM . ");
        }

        public string SIM()
        {
            return ("Iphones have a SIM card or e-SIM .");
        }

        public string InternalMemory()
        {

            return ("They have 16GB,32GB,64GB,128GB,256GB internal memory . ");

        }

        
    }
}

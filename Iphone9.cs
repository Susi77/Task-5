using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationIphone9
{
    public class Iphone9: Apple
    {
        public  new  string Camera()
        {
            return ("It has a camera .");
        }

        public  new string CPU()
        {
            return ("It has Apple A12Z Bionic CPU  . ");
        }

        public  new string OperationSystem()
        {
            return ("It warks with IOS. ");
        }

        public  new string RAM()

        {
            return ("It has 2GB RAM. ");
        }

        public  new string SIM()
        {
            return ("It has a SIM card.");
        }

        public new string InternalMemory()
        {

            return ("It has 32GB,64GB,128GB,256GB internal memory . ");

        }

        public bool UseProtectedMember()
        {
            return this.Chip;
        
        }
     

    }
}

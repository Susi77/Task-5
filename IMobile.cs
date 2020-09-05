using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationIphone9
{
  public interface IMobile
    {
        public abstract string CPU();

        public string RAM()

        {
            return ("All phones have 2GB,4GB,6GB,8GB,12GB RAM. ");
        }

        public abstract string OperationSystem();

        public abstract string Camera();

        public string InternalMemory()
        {

            return ("It has 8GB,16GB,32GB,64GB,128GB,256GB internal memory.");

        }

        public string SIM()
        {
            return ("All phones have at least one SIM card!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class Bicycle : IBreakable
    {
        private string registrationNumber;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public Bicycle(int numberOfWheels)
        {

        }

        public void Brake()
        {
            
        }
    }
}

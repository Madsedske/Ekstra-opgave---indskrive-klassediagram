using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class Car : Vehicle
    {
        Wheel wheel1 = new Wheel();
        Wheel wheel2 = new Wheel();
        Wheel wheel3 = new Wheel();
        Wheel wheel4 = new Wheel();

        GearBox GearBox = new GearBox();

        private string registrationNumber;
         
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; } 
        }

        private string registrationYear;

        public string RegistrationYear
        {
            get { return registrationYear; }
            set { registrationYear = value; }
        }

        private IEngine engine;

        public Car()
        {

        }

        public void Start()
        {
            
        }

        public void Inject()
        {
            
        }

        public void TurnOff()
        {
           
        }
    }
}

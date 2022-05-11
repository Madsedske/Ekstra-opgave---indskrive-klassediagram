using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class Volvo : IGasolineEngine
    {
        private float capacity;

        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Volvo()
        {
                
        }        

        public void Inject()
        {

        }

        public void Start()
        {

        }


        public void TurnOff()
        {

        }
    }
}

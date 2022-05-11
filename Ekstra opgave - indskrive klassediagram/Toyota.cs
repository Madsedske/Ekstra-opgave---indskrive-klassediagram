using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class Toyota : IGasolineEngine, IBreakable
    {
        private float capacity;

        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Toyota(float capacity)
        {
          
        }

        public void Brake()
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

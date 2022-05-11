using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class Factory
    {
        Vehicle vehicle = new Car();

        private Factory()
        {

        }

        public Vehicle Create(int type)
        {
            return new Car();
        }

        public static void Instance()
        {

        }
    }
}

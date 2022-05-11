using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    public class GearBox
    {
        private int currentGear;

        public int CurrentGear
        {
            get { return currentGear; }
            set { currentGear = value; }
        }

        public void ShiftUp(int steps)
        {

        }

        public void ShiftDown(int steps)
        {


        }

        public class GearType
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            static public new void GetType()
            {

            }
        }
    }
}

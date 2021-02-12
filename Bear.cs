using System;
using System.Collections.Generic;
using System.Text;

namespace CW5_Andrew_Newbill
{
    class Bear : IBear
    {
        public void maul()
        {
            Console.WriteLine("The bear feasts on your entrails adorably.");
        }

        public void hibernate()
        {
            Console.WriteLine("The bear peacefully sleeps, dreaming wistfully of mangled corpses.");
        }

    }
}

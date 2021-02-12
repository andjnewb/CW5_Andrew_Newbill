using System;
using System.Collections.Generic;
using System.Text;

namespace CW5_Andrew_Newbill
{
    public class BearAdapter : IToyBear
    {
        IBear bear;

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }

        public void hug()
        {
            bear.maul();
        }


    }
}

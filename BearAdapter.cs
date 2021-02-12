using System;
using System.Collections.Generic;
using System.Text;

namespace CW5_Andrew_Newbill
{
    class BearAdapter : IToyBear
    {
        IBear bear;

        BearAdapter(IBear bear)
        {
            this.bear = bear;
        }

        public void hug()
        {
            bear.maul();
        }


    }
}

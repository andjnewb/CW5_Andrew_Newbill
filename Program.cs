using System;

namespace CW5_Andrew_Newbill
{
    class Program
    {
        static void Main(string[] args)
        {
            GrizzlyBear grizzly = new GrizzlyBear();
            TeddyBear teddy = new TeddyBear();
            BearAdapter bearAdapter = new BearAdapter(grizzly);

            grizzly.hibernate();
            grizzly.maul();





        }
    }
}

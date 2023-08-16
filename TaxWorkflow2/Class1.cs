using System.Diagnostics;

namespace TaxWorkflow2
{
    public class Class1
    {
        public int KillerFlag { get; set; }

        public Class1()
        {
            KillerFlag = 0;

            var x = new Class1();
            x.KillerFlag = KillerFlag;
        }
    }
}
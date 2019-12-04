using SOLIDPrinciple.Builders;
using SOLIDPrinciple.Contracts;
using SOLIDPrinciple.Core;
using System;

namespace SOLIDPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreeService service = new TreeService();
            service.AdjustTreeBasedOnTemperature(TreeBuilder.BuildAppleTree(), 1);
        }
    }
}

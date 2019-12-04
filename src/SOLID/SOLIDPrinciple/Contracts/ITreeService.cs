using SOLIDPrinciple.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ITreeService
    {
        void AdjustTreeBasedOnTemperature(ITree tree, double temperature);
    }
}

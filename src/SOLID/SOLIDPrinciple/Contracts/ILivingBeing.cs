using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ILivingBeing
    {
        IHealthStrategy HealthStrategy { get; set; }

        bool ExecuteHealthCheck();
    }
}

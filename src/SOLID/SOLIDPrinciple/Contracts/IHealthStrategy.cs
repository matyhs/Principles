using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface IHealthStrategy
    {
        bool HealthCheck(ICollection<ITreePart> treeParts);
    }
}

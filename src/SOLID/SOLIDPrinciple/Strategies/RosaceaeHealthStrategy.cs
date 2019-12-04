using SOLIDPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Strategies
{
    public class RosaceaeHealthStrategy : IHealthStrategy
    {
        public bool HealthCheck(ICollection<ITreePart> treeParts)
        {
            // Implement behavior for checking the health of a Rosaceae tree
            return true;
        }
    }
}

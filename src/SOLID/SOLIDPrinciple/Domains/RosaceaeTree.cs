using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciple.Contracts;
using SOLIDPrinciple.Strategies;

namespace SOLIDPrinciple.Domains
{
    public class RosaceaeTree : Tree
    {
        #region Properties

        // Setter Dependency Injection
        public IHealthStrategy RosaceaeHealthStrategy
        {
            set
            {
                HealthStrategy = value;
            }
        }

        #endregion

        #region Constructors
        
        // Constructor Dependency Injection
        public RosaceaeTree(IHealthStrategy strategy)
        {
            RosaceaeHealthStrategy = strategy;
        }

        #endregion

        public override ICollection<ITreePart> GetTreeParts()
        {
            return new List<ITreePart>() { Trunk, Root, Crown, Bark };
        }
    }
}

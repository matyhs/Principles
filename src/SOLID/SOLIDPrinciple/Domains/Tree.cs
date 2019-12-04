using System;
using System.Collections.Generic;
using System.Text;

using SOLIDPrinciple.Contracts;

namespace SOLIDPrinciple.Domains
{
    public abstract class Tree : ITree, IIdentity, ILivingBeing
    {
        #region ITree Properties

        public ICrown Crown { get; set; }
        public ITrunk Trunk { get; set; }
        public IRoot Root { get; set; }
        public IBark Bark { get; set; }

        #endregion

        #region IIdentity Properties

        public string Name { get; set; }
        public string ScientificName { get; set; }

        #endregion

        #region ILivingBeing Properties

        public IHealthStrategy HealthStrategy { get; set; }

        #endregion

        #region ILivingBeing Methods

        public bool ExecuteHealthCheck()
        {
            return HealthStrategy.HealthCheck(GetTreeParts());
        }

        #endregion

        #region Tree Abstract Methods

        public abstract ICollection<ITreePart> GetTreeParts();

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ITrunk : ITreePart
    {
        void Transport(ICollection<IMaterial> materials);
    }
}

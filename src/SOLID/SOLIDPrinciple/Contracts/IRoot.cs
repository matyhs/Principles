using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface IRoot : ITreePart
    {
        void Collect(ICollection<IMaterial> materials);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ILeaf : ITreePart
    {
        void ProduceHormones();

        void Photosynthesis();
    }
}

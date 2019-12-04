using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface IBark : ITreePart
    {
        int Health { get; set; }

        void Protect();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ITreePart
    {
        int Width { get; set; }
        int Height { get; set; }
        int Thickness { get; set; }

        void Grow();
        void Wither();
    }
}

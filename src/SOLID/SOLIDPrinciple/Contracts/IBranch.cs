﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface IBranch : ITreePart
    {
        ICollection<ILeaf> Leaves { get; set; }
        ICollection<IFruit> Fruits { get; set; }
        ICollection<IFlower> Flowers { get; set; }
    }
}

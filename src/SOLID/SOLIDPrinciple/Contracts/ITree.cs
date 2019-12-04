
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface ITree
    {
        ICrown Crown { get; set; }
        ITrunk Trunk { get; set; }
        IRoot Root { get; set; }
        IBark Bark { get; set; }
    }
}

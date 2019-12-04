using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Contracts
{
    public interface IIdentity
    {
        string Name { get; set; }
        string ScientificName { get; set; }
    }
}

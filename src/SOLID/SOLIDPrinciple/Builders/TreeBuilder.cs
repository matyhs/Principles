using SOLIDPrinciple.Contracts;
using SOLIDPrinciple.Domains;
using SOLIDPrinciple.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.Builders
{
    public static class TreeBuilder
    {
        public static Tree BuildAppleTree()
        {
            Tree rosaceaeTree = new RosaceaeTree(new RosaceaeHealthStrategy());
            rosaceaeTree.Name = "Apple Tree";
            rosaceaeTree.ScientificName = "Malus domestica";

            // Add other parts of the tree here

            return rosaceaeTree;
        }
    }
}

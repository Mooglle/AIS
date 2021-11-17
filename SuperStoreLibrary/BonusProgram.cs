using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStoreLibrary
{
    public class BonusProgram
    {
        public string Name { get; set; }
        public List<Type> ProductTypes { get; set; }
        public List<Type> Brands { get; set; }
        public BonusProgram(string name, List<Type> productTypes)
        {
            Name = name;
            ProductTypes = productTypes;
        }
    }
}
